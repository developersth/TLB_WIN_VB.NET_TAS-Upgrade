Imports System
Imports System.Data
Imports Oracle.DataAccess.Client
Imports System.Threading
Imports System.IO
Imports System.Data.OleDb

Public Class COracle_

    Structure _ParamMember
        Public Name As String
        Public Value As Object
        Public Size As Int32
        Public Direction As _OracleDbDirection
        Public Type As _OracleDbType
    End Structure

    Private CurrentDB As DB_TYPE
    Private mIsConnectedDB As Boolean
    Private mIsMasterDatabase As Boolean

    Private mCount As Integer
    Private bConnect As Boolean
    Private bShutdown As Boolean
    'Private connectStr_Master As String = "User Id=tas;Password=gtas;Data Source=LLTLB"
    Private connectStr_Master As String = "Provider=MSDAORA.1;Data Source=LLTLB;User Id=tas;Password=gtas;OLEDB.NET=True;"
    'Private connectStr_SubMaster As String = "User Id=tas;Password=mcstas;Data Source=tlas1"

    'Public mConnOracle As OracleConnection = Nothing
    Public mConnOracle As OleDbConnection = Nothing

    Private mThread As Thread
    Private mRunning As Boolean

    Public Event OnConnect()
    Public Event OnDisconnect()
    Private mLog As New CLog

    Public OraParam() As _ParamMember
    Private mTotalParam As Integer

    'Public OraDysReader As OracleDataReader
    Public OraDysReader As OleDbDataReader

#Region "Enum Database"
    'Database ENUM
    Public Enum DB_TYPE
        DB_None = -1
        DB_MASTER = 0
        DB_SUBMASTER = 1
    End Enum

    Public Enum _OracleDbDirection
        OraInput
        OraOutput
    End Enum

    Public Enum _OracleDbType
        OraVarchar2
        OraInt16
        OraInt32
        OraInt64
        OraDate
        OraLong
        OraDouble
        OraSingle
        OraByte
        OraDecimal
        OraBlob
    End Enum
#End Region

    Sub New()
        bConnect = False
        bShutdown = False
        mRunning = False
        mCount = 0
        CurrentDB = DB_TYPE.DB_None
        'ScanDatabase()
        StartThread()
    End Sub

    Protected Overrides Sub Finalize()
        Dispose()
    End Sub

    Public Sub Dispose()
        Close()
    End Sub

    Private Sub StartThread()
        If mRunning Then Exit Sub
        mThread = New Thread(New ThreadStart(AddressOf RunProcess))
        mRunning = True
        mThread.Name = "thrOracle"
        mThread.Start()
    End Sub

    Private Sub RunProcess()
        While (1)
            'If CurrentDB = DB_TYPE.DB_None Then
            '    CurrentDB = GetSelectServerDb()
            'End If

            'If CurrentDB <> DB_TYPE.DB_None Then
            Reconnect()
            If bConnect Or bShutdown Then
                Exit While
            End If
            'End If

            System.Threading.Thread.Sleep(10000)
        End While
        RaiseEvent OnConnect()
        mRunning = False
    End Sub

    Public ReadOnly Property ConnectStatus() As Boolean
        Get
            Return bConnect
        End Get
    End Property

    Public Function Connect() As Boolean
        Dim vMsg As String

        Try
            'mConnOracle = New OracleConnection(connectStr_Master)
            mConnOracle = New OleDbConnection(connectStr_Master)
            mConnOracle.Open()
            bConnect = True
            'AddEventMessage("System", vMsg)
        Catch e As Exception
            'Console.WriteLine("Error: {0}", e.Message)
            bConnect = False
            StartThread()
        End Try
        Return bConnect
    End Function

    Public Sub Close()
        mThread.Abort()
        bShutdown = True
        bConnect = False
        If mConnOracle IsNot Nothing Then
            mConnOracle.Close()
            mConnOracle.Dispose()
            mConnOracle = Nothing
        End If
    End Sub

    Private Sub Reconnect()
        If Not bConnect Then
            Try
                mConnOracle.Close()
            Catch e As Exception
            End Try
            Connect()
        End If
    End Sub

    Private Sub CheckExecute(ByVal mExe As Boolean)
        If mExe Then
            mCount = 0
            If Not bConnect Then
                bConnect = True
            End If
        Else
            mCount += 1
            If mCount >= 3 Then
                If bConnect Then
                    bConnect = False
                    RaiseEvent OnDisconnect()
                    StartThread()
                End If
                mCount = 0
            End If
        End If
    End Sub

    Public Function OpenDys(ByVal strSQL As String, ByVal pTableName As String, ByRef mDataSet As DataSet, _
                            Optional ByRef SQL_Execution_Error As String = "") As Boolean
        'Dim oda As OracleDataAdapter
        Dim oda As OleDbDataAdapter
        Dim ds As New DataSet
        Dim bCheck As Boolean = False
        'ds = Nothing
        SQL_Execution_Error = ""
        If bConnect Then
            Try
                'oda = New OracleDataAdapter(strSQL, mConnOracle)
                oda = New OleDbDataAdapter(strSQL, mConnOracle)
                oda.Fill(ds, pTableName)
                mDataSet = ds
                CheckExecute(True)
                bCheck = True
                'Return True
            Catch ex As Exception
                mLog.WriteSQLMessage("<Open Dynaset Error> " & strSQL)
                mLog.WriteSQLMessage("<Open Dynaset Error> " & ex.ToString)
                SQL_Execution_Error = ex.ToString
                CheckExecute(False)
                MsgBox(SQL_Execution_Error, MsgBoxStyle.Information)
                'Return False
            End Try

            mDataSet = ds
            ds = Nothing
            oda = Nothing

        End If
        Return bCheck
    End Function

    Public Function OpenDys(ByVal strSQL As String, ByVal MaxRecord As Integer, ByVal pTableName As String, ByRef mDataSet As DataSet, _
                            Optional ByRef SQL_Execution_Error As String = "") As Boolean
        'Dim oda As OracleDataAdapter
        Dim oda As OleDbDataAdapter
        Dim ds As New DataSet
        Dim bCheck As Boolean = False
        'ds = Nothing
        SQL_Execution_Error = ""
        If bConnect Then
            Try
                'oda = New OracleDataAdapter(strSQL, mConnOracle)
                oda = New OleDbDataAdapter(strSQL, mConnOracle)
                oda.Fill(ds, 0, MaxRecord, pTableName)
                mDataSet = ds
                CheckExecute(True)
                bCheck = True
                'Return True
            Catch ex As Exception
                mLog.WriteSQLMessage("<Open Dynaset Error> " & strSQL)
                mLog.WriteSQLMessage("<Open Dynaset Error> " & ex.ToString)
                SQL_Execution_Error = ex.ToString
                CheckExecute(False)
                MsgBox(SQL_Execution_Error, MsgBoxStyle.Information)
                'Return False
            End Try

            mDataSet = ds
            ds = Nothing
            oda = Nothing
            Return bCheck
        End If
    End Function

    Public Function ExeSQL(ByVal strSQL As String, Optional ByRef SQL_Execution_Error As String = "") As Boolean

        'Dim oCommand As OracleCommand
        Dim oCommand As OleDbCommand
        If bConnect Then
            'oCommand = New OracleCommand(strSQL, mConnOracle)
            oCommand = New OleDbCommand(strSQL, mConnOracle)
            Try
                oCommand.ExecuteNonQuery()
                CheckExecute(True)
                Return True
            Catch e As Exception
                mLog.WriteSQLMessage("<ExeSQL Error> " & strSQL)
                mLog.WriteSQLMessage("<ExeSQL Error> " & e.ToString)
                SQL_Execution_Error = e.ToString
                CheckExecute(False)
                MsgBox(SQL_Execution_Error, MsgBoxStyle.Information)
                Return False
            End Try

        Else
            Return False
        End If
    End Function

    Public Function ExeSQL(ByVal strSQL As String, ByVal iParam As COraParameter, Optional ByVal SQL_Execution_Error As String = "") As Boolean

        Dim _oraparam As _ParamMember
        'Dim OraCmd As OracleCommand
        Dim OraCmd As OleDbCommand
        Dim i As Integer
        Dim bCheck As Boolean = False
        Dim sKey() As String

        If bConnect Then
            'OraCmd = New OracleCommand()
            OraCmd = New OleDbCommand()
            'New delvelop-----------
            ReDim sKey(iParam.OraParam.Count - 1)
            iParam.OraParam.Keys.CopyTo(sKey, 0)
            '-----------
            Try
                If iParam.OraParam IsNot Nothing Then  'execute with parameter
                    For i = 0 To iParam.GetOracleParamLength - 1
                        'Select Case iParam.OraParam(i).Direction
                        Select Case iParam.OraParam.Item(sKey(i)).Direction
                            Case _OracleDbDirection.OraInput
                                'New delvelop-----------
                                _oraparam = iParam.OraParam.Item(sKey(i))
                                OraCmd.Parameters.Add(_oraparam.Name, GetOracleDbType(_oraparam.Type), _
                                                      _oraparam.Value, _
                                                      GetOracleDbDirection(_oraparam.Direction))
                                '-----------
                                'OraCmd.Parameters.Add(iParam.OraParam(i).Name, GetOracleDbType(iParam.OraParam(i).Type), _
                                '                      iParam.OraParam(i).Value, _
                                '                      GetOracleDbDirection(iParam.OraParam(i).Direction))
                            Case _OracleDbDirection.OraOutput
                                'New delvelop-----------
                                _oraparam = iParam.OraParam.Item(sKey(i))
                                If iParam.OraParam.Item(sKey(i)).Type = _OracleDbType.OraVarchar2 Then

                                    'OraCmd.Parameters.Add(_oraparam.Name, GetOracleDbType(_oraparam.Type), _
                                    '                      _oraparam.Size, _oraparam.Value, _
                                    '                      GetOracleDbDirection(_oraparam.Direction))
                                    OraCmd.Parameters.Add(_oraparam.Name, GetOracleDbType(_oraparam.Type), _
                                                          _oraparam.Size, _oraparam.Value _
                                                          )
                                    '-----------
                                    'If iParam.OraParam(i).Type = _OracleDbType.OraVarchar2 Then
                                    'OraCmd.Parameters.Add(iParam.OraParam(i).Name, GetOracleDbType(iParam.OraParam(i).Type), _
                                    '                      iParam.OraParam(i).Size, iParam.OraParam(i).Value, _
                                    '                      GetOracleDbDirection(iParam.OraParam(i).Direction))
                                Else
                                    OraCmd.Parameters.Add(_oraparam.Name, GetOracleDbType(_oraparam.Type), _
                                                      _oraparam.Value, _
                                                      GetOracleDbDirection(_oraparam.Direction))
                                    'OraCmd.Parameters.Add(iParam.OraParam(i).Name, GetOracleDbType(iParam.OraParam(i).Type), _
                                    '                      GetOracleDbDirection(iParam.OraParam(i).Direction))
                                End If

                        End Select
                    Next i
                End If

                OraCmd.CommandText = strSQL
                OraCmd.CommandType = CommandType.Text
                OraCmd.Connection = mConnOracle
                OraCmd.ExecuteNonQuery()
                'New delvelop-----------
                If iParam IsNot Nothing Then
                    For i = 0 To iParam.GetOracleParamLength - 1
                        _oraparam = iParam.OraParam.Item(sKey(i))
                        If _oraparam.Direction = _OracleDbDirection.OraOutput Then
                            _oraparam.Value = OraCmd.Parameters(_oraparam.Name).Value
                            iParam.OraParam.Item(sKey(i)) = _oraparam
                        End If
                    Next
                End If
                '-----------

                'If iParam IsNot Nothing Then
                '    For i = 0 To iParam.GetOracleParamLength - 1
                '        If iParam.OraParam(i).Direction = _OracleDbDirection.OraOutput Then
                '            iParam.OraParam(i).Value = OraCmd.Parameters(iParam.OraParam(i).Name).Value
                '        End If
                '    Next
                'End If

                bCheck = True
                CheckExecute(True)
                SQL_Execution_Error = "Execute Successful."
            Catch ex As Exception
                mLog.WriteSQLMessage("<ExeSQL Error> " & strSQL)
                mLog.WriteSQLMessage("<ExeSQL Error> " & ex.ToString)
                SQL_Execution_Error = ex.ToString
                CheckExecute(False)
                bCheck = False
            End Try


            OraCmd.Dispose()
            OraCmd = Nothing

        End If

        Return bCheck
    End Function

    Private Function GetOracleDbType(ByVal iOracleDbType As _OracleDbType) As OracleDbType
        If iOracleDbType = _OracleDbType.OraByte Then Return OracleDbType.Byte
        If iOracleDbType = _OracleDbType.OraBlob Then Return OracleDbType.Blob
        If iOracleDbType = _OracleDbType.OraDate Then Return OracleDbType.Date
        If iOracleDbType = _OracleDbType.OraDecimal Then Return OracleDbType.Decimal
        If iOracleDbType = _OracleDbType.OraDouble Then Return OracleDbType.Double
        If iOracleDbType = _OracleDbType.OraInt16 Then Return OracleDbType.Int16
        If iOracleDbType = _OracleDbType.OraInt32 Then Return OracleDbType.Int32
        If iOracleDbType = _OracleDbType.OraInt64 Then Return OracleDbType.Int64
        If iOracleDbType = _OracleDbType.OraLong Then Return OracleDbType.Long
        If iOracleDbType = _OracleDbType.OraSingle Then Return OracleDbType.Single
        If iOracleDbType = _OracleDbType.OraVarchar2 Then Return OracleDbType.Varchar2
        Return OracleDbType.Varchar2
    End Function

    Private Function GetOracleDbDirection(ByVal iOracleDbDirection As _OracleDbDirection) As ParameterDirection
        If iOracleDbDirection = _OracleDbDirection.OraInput Then Return ParameterDirection.Input
        If iOracleDbDirection = _OracleDbDirection.OraOutput Then Return ParameterDirection.Output
        Return ParameterDirection.Input
    End Function

    'Public Sub RemoveOracleParameter()
    '    If OraParam IsNot Nothing Then
    '        OraParam = Nothing
    '    End If
    '    mTotalParam = 0
    'End Sub
#Region "ChangeServer"

    Public Sub ScanDatabase()
        Dim NewDB As DB_TYPE
        NewDB = GetSelectServerDb()
        If CurrentDB <> NewDB Then
            bConnect = False
            CurrentDB = NewDB
            If CurrentDB <> DB_TYPE.DB_None Then
                Reconnect()
            End If
        Else
            If CurrentDB <> DB_TYPE.DB_None Then
                mIsConnectedDB = GetConectServer(CurrentDB)
                mIsMasterDatabase = GetIsMaster(CurrentDB)
                If Not mIsConnectedDB Then
                    CurrentDB = DB_TYPE.DB_None
                    bConnect = False
                    Reconnect()
                End If
                'Connect()
            End If
        End If
    End Sub

    Public Function GetConnectDBName() As String
        GetConnectDBName = ""
        Select Case CurrentDB
            Case DB_TYPE.DB_None
                GetConnectDBName = "Connect None"
            Case DB_TYPE.DB_MASTER
                GetConnectDBName = "Connect MASTER"
            Case DB_TYPE.DB_SUBMASTER
                GetConnectDBName = "Connect BACKUP"
        End Select
    End Function

    Public Function GetSelectServerDb() As DB_TYPE
        'Dim ret As String

        'ret = ReadIni("C:\WINDOWS\system32\TLASConfig.ini", "SELECT", "SERVER", "")
        'Select Case ret
        '    Case 0
        '        GetSelectServerDb = DB_TYPE.DB_MASTER
        '    Case 1
        '        GetSelectServerDb = DB_TYPE.DB_SUBMASTER
        '    Case Else
        '        GetSelectServerDb = DB_TYPE.DB_None
        'End Select
        GetSelectServerDb = DB_TYPE.DB_MASTER
    End Function

    Private Function GetConectServer(ByVal iServer As DB_TYPE) As Boolean
        'Dim ret As String

        'ret = 0
        'Select Case iServer
        '    Case DB_TYPE.DB_None
        '        ret = 0
        '    Case DB_TYPE.DB_MASTER
        '        ret = ReadIni("C:\WINDOWS\system32\TLASConfig.ini", "MASTER", "CONNECT", "")
        '    Case DB_TYPE.DB_SUBMASTER
        '        ret = ReadIni("C:\WINDOWS\system32\TLASConfig.ini", "BACKUP", "CONNECT", "")
        'End Select

        'GetConectServer = IIf(ret = "0", False, True)
        Return True
    End Function

    Private Function GetIsMaster(ByVal iServer As DB_TYPE) As Boolean
        Dim ret As String

        ret = 0
        'Select Case iServer
        '    Case DB_TYPE.DB_None
        '        ret = 0
        '    Case DB_TYPE.DB_MASTER
        '        ret = ReadIni("C:\WINDOWS\system32\TLASConfig.ini", "MASTER", "ISMASTER", "")
        '    Case DB_TYPE.DB_SUBMASTER
        '        ret = ReadIni("C:\WINDOWS\system32\TLASConfig.ini", "BACKUP", "ISMASTER", "")
        'End Select

        'GetIsMaster = IIf(ret = "0", False, True)

        Return True
    End Function

#End Region

End Class

Public Class COraParameter
    'Public OraParam() As COracle._ParamMember
    Public OraParam As Dictionary(Of String, COracle_._ParamMember)

    Private _OraParam As COracle_._ParamMember
    Private mTotalParam As Integer
    'New delvelop-----------
    Public Sub New()
        OraParam = New Dictionary(Of String, COracle_._ParamMember)
    End Sub

    Protected Overrides Sub Finalize()
        OraParam = Nothing
        MyBase.Finalize()
    End Sub
    '-----------
    'Private Sub CreateOracleParam(ByVal iTotalParam As Integer)
    '    If OraParam IsNot Nothing Then
    '        OraParam = Nothing
    '    End If
    '    mTotalParam = iTotalParam
    '    ReDim OraParam(iTotalParam - 1)
    'End Sub

    Public Sub RemoveOracleParam()
        If OraParam IsNot Nothing Then
            OraParam.Clear()
        End If
    End Sub

    'Private Sub AddOracleParamInput(ByVal iParam As Integer, ByVal NameParam As String, ByVal TypeParam As COracle._OracleDbType, ByVal Value As Object)
    '    If OraParam IsNot Nothing Then
    '        If iParam < mTotalParam Then
    '            OraParam(iParam).Name = NameParam
    '            OraParam(iParam).Type = TypeParam
    '            OraParam(iParam).Value = Value
    '            OraParam(iParam).Direction = COracle._OracleDbDirection.OraInput
    '        End If
    '    End If
    'End Sub

    'Private Sub AddOracleParamInput(ByVal iParam As Integer, ByVal NameParam As String, ByVal TypeParam As COracle._OracleDbType, ByVal SizeValue As Integer, ByVal Value As Object)
    '    If OraParam IsNot Nothing Then
    '        If iParam < mTotalParam Then
    '            OraParam(iParam).Name = NameParam
    '            OraParam(iParam).Type = TypeParam
    '            OraParam(iParam).Size = SizeValue
    '            OraParam(iParam).Value = Value
    '            OraParam(iParam).Direction = COracle._OracleDbDirection.OraInput
    '        End If
    '    End If
    'End Sub

    'Private Sub AddOracleParamOutput(ByVal iParam As Integer, ByVal NameParam As String, ByVal TypeParam As COracle._OracleDbType)
    '    If OraParam IsNot Nothing Then
    '        If iParam < mTotalParam Then
    '            OraParam(iParam).Name = NameParam
    '            OraParam(iParam).Type = TypeParam
    '            OraParam(iParam).Direction = COracle._OracleDbDirection.OraOutput
    '        End If
    '    End If
    'End Sub

    'Private Sub AddOracleParamOutput(ByVal iParam As Integer, ByVal NameParam As String, ByVal TypeParam As COracle._OracleDbType, ByVal SizeValue As Integer)
    '    If OraParam IsNot Nothing Then
    '        If iParam < mTotalParam Then
    '            OraParam(iParam).Name = NameParam
    '            OraParam(iParam).Type = TypeParam
    '            OraParam(iParam).Size = SizeValue
    '            OraParam(iParam).Direction = COracle._OracleDbDirection.OraOutput
    '        End If
    '    End If
    'End Sub

    'New delvelop-----------
    Public Overloads Sub CreateOracleParamOutput(ByVal ParamName As String, ByVal ParamType As COracle_._OracleDbType)
        If OraParam IsNot Nothing Then
            With _OraParam
                .Name = ParamName
                .Type = ParamType
                .Direction = COracle_._OracleDbDirection.OraOutput
            End With
            If OraParam.ContainsKey(ParamName) Then
                OraParam.Item(ParamName) = _OraParam
            Else
                OraParam.Add(ParamName, _OraParam)
            End If
        End If
    End Sub

    Public Overloads Sub CreateOracleParamOutput(ByVal ParamName As String, ByVal ParamType As COracle_._OracleDbType, ByVal SizeValue As Integer)
        If OraParam IsNot Nothing Then
            With _OraParam
                .Name = ParamName
                .Type = ParamType
                .Size = SizeValue
                .Direction = COracle_._OracleDbDirection.OraOutput
            End With
            If OraParam.ContainsKey(ParamName) Then
                OraParam.Item(ParamName) = _OraParam
            Else
                OraParam.Add(ParamName, _OraParam)
            End If

        End If
    End Sub

    Public Function GetOracleParamLength() As Integer
        If OraParam IsNot Nothing Then
            Return OraParam.Count
        End If
        Return 0
    End Function

    Public Overloads Function GetOraclParamValue(ByVal iParamName As String) As Object
        If OraParam IsNot Nothing Then
            Return OraParam.Item(iParamName).Value
        End If
        Return Nothing
    End Function

    '-----------

    'Public Function GetOracleParamValue(ByVal iParam As Integer) As Object
    '    If OraParam IsNot Nothing Then
    '        If iParam < mTotalParam Then
    '            Return OraParam(iParam).Value
    '        End If
    '    End If
    '    Return Nothing
    'End Function

    'Public Sub SetOracleParamValue(ByVal iParam As Integer, ByVal Value As Object)
    '    If OraParam IsNot Nothing Then
    '        If iParam < mTotalParam Then
    '            OraParam(iParam).Value = Value
    '        End If
    '    End If
    'End Sub
End Class