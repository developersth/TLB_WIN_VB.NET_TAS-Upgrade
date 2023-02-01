Imports System
Imports System.Data
Imports System.Data.OleDb
Imports Oracle.ManagedDataAccess.Types
Imports Oracle.ManagedDataAccess.Client
Imports System.Threading
Imports System.IO
Imports System.Configuration

Public Class COracle

    Structure _ParamMember
        Public Name As String
        Public Value As Object
        Public Size As Int32
        Public Direction As _OracleDbDirection
        Public Type As _OracleDbType
    End Structure

    Private currentDB As DB_TYPE
    Private isConnectedDB As Boolean
    Private isMasterDatabase As Boolean

    Private countDisconnect As Integer
    'Private connStrMaster As String = "User Id=tas;Password=tam;Data Source=LLTLBA"
    'Private connStrBackup As String = "User Id=tas;Password=tam;Data Source=LLTLBB"
    Private connStrMaster As String = ConfigurationManager.ConnectionStrings("StrConnA").ConnectionString().Trim()
    Private connStrBackup As String = ConfigurationManager.ConnectionStrings("StrConnB").ConnectionString().Trim()
    Private oraConn As OracleConnection = Nothing
    Private oraConnect As Boolean
    Private oraServiceName As String = "N/A"

    Private thrOracle As Thread
    Private thrRunn As Boolean
    Private thrShutdown As Boolean
    Private thrScanDB(2) As ScanDatabase

    Public Event OnConnect()
    Public Event OnDisconnect()
    Private logFile As New CLog

    Public OraParam() As _ParamMember
    Private totalParam As Integer

    'Public OraDysReader As OracleDataReader

#Region "Enum Database"
    'Database ENUM
    Public Enum DB_TYPE
        DB_None = -1
        DB_MASTER = 0
        DB_BACKUP = 1
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
        oraConnect = False
        thrShutdown = False
        thrRunn = False
        countDisconnect = 0
        currentDB = DB_TYPE.DB_None
        'ScanDatabase()
        StartThread()
    End Sub

    Protected Overrides Sub Finalize()
        Dispose()
        'If thrOracle.ThreadState = ThreadState.Running Then
        '    thrOracle.Abort()
        'End If
    End Sub

    Public Sub Dispose()
        thrShutdown = True
        Close()
    End Sub

    Private Sub StartThread()

        If thrRunn Then Exit Sub
        thrScanDB(0) = New ScanDatabase(connStrMaster)
        thrScanDB(1) = New ScanDatabase(connStrBackup)
        thrOracle = New Thread(New ThreadStart(AddressOf RunProcess))
        thrRunn = True
        thrOracle.Name = "thrOracle"
        thrOracle.Start()
    End Sub

    Private Sub RunProcess()
        While (Not thrShutdown)
            'If CurrentDB = DB_TYPE.DB_None Then
            '    CurrentDB = GetSelectServerDb()
            'End If

            'If CurrentDB <> DB_TYPE.DB_None Then
            ScanActiveDatabase()
            'Reconnect()
            'If bConnect Or bShutdown Then
            If thrShutdown Then
                Exit While
            End If
            'End If

            System.Threading.Thread.Sleep(5000)
        End While
        'If bConnect Then
        '    RaiseEvent OnConnect()
        '    thrRunn = False
        'End If
    End Sub

    Public Function Connect() As Boolean

        'Dim vOledbConn As OleDbConnection
        Try
            'vOledbConn = New OleDbConnection("Provider=OraOLEDB.Oracle;Data Source=LLTLB;User id=tas;Password=gtas")
            'vOledbConn.Open()
            Select Case currentDB
                Case DB_TYPE.DB_MASTER
                    oraConn = New OracleConnection(connStrMaster)
                    oraServiceName = "Server A"
                    oraServer = "LLTLBA"
                Case DB_TYPE.DB_BACKUP
                    oraConn = New OracleConnection(connStrBackup)
                    oraServiceName = "Server B"
                    oraServer = "LLTLBB"
                Case Else
                    oraServiceName = "N/A"
            End Select
            'If CurrentDB = DB_TYPE.DB_MASTER Then
            '    OraConn = New OracleConnection(ConnStrMaster)
            '    mServer = "SERVER A"
            '    nServer = "LLTLBA"
            'ElseIf CurrentDB = DB_TYPE.DB_BACKUP Then
            '    OraConn = New OracleConnection(ConnStrBackup)
            '    mServer = "SERVER B"
            '    nServer = "LLTLBB"
            'End If
            If currentDB <> DB_TYPE.DB_None Then
                oraConn.Open()
                oraConnect = True
                'oraServiceName = oraServiceName & "[" & oraConn.DatabaseName & "]"
            Else
                logFile.WriteErrMessage("[System]" & " Can not detect Master and Backup Database.")
            End If
            'AddEventMessage("System", vMsg)
        Catch e As Exception
            'Console.WriteLine("Error: {0}", e.Message)
            If oraConnect Then
                oraConnect = False
                StartThread()
            End If
        End Try
        Return oraConnect
    End Function

    Public Sub Close()
        thrOracle.Abort()
        thrOracle = Nothing
        thrShutdown = True
        oraConnect = False
        If oraConn IsNot Nothing Then
            oraConn.Close()
            oraConn.Dispose()
            oraConn = Nothing
        End If
    End Sub

    Private Sub Reconnect()
        If Not oraConnect Then
            Try
                oraConn.Close()
            Catch e As Exception
            End Try
            Connect()
        End If
    End Sub

    Private Sub CheckExecute(ByVal mExe As Boolean)
        If mExe Then
            countDisconnect = 0
            If Not oraConnect Then
                oraConnect = True
            End If
        Else
            countDisconnect += 1
            If countDisconnect >= 3 Then
                If oraConnect Then
                    oraConnect = False
                    RaiseEvent OnDisconnect()
                    StartThread()
                End If
                countDisconnect = 0
            End If
        End If
    End Sub
  
    Public Function OpenDys(ByVal strSQL As String, ByVal pTableName As String, ByRef mDataSet As DataSet, _
                            Optional ByRef SQL_Execution_Error As String = "", Optional ByVal pShowErr As Boolean = True) As Boolean
        Dim oda As OracleDataAdapter
        Dim ds As New DataSet
        Dim bCheck As Boolean = False
        'ds = Nothing
        SQL_Execution_Error = ""
        If oraConnect Then
            Try
                oda = New OracleDataAdapter(strSQL, oraConn)
                oda.Fill(ds, pTableName)
                mDataSet = ds
                CheckExecute(True)
                bCheck = True
                'Return True
            Catch ex As Exception
                logFile.WriteErrMessage("[OpenDyns] " & strSQL)
                logFile.WriteErrMessage("[OpenDyns] " & ex.ToString)
                SQL_Execution_Error = ex.ToString
                CheckExecute(False)
                If pShowErr Then
                    MsgBox(SQL_Execution_Error, MsgBoxStyle.Information)
                End If
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
        Dim oda As OracleDataAdapter
        Dim ds As New DataSet
        Dim bCheck As Boolean = False
        'ds = Nothing
        SQL_Execution_Error = ""
        If oraConnect Then
            Try
                oda = New OracleDataAdapter(strSQL, oraConn)
                oda.Fill(ds, 0, MaxRecord, pTableName)
                mDataSet = ds
                CheckExecute(True)
                bCheck = True
                'Return True
            Catch ex As Exception
                logFile.WriteErrMessage("[OpenDyns] " & strSQL)
                logFile.WriteErrMessage("[OpenDyns] " & ex.ToString)
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
    Public Function Query_TBL(ByVal sql As String) As DataTable
        Dim dt As DataTable = New DataTable("tmp")
        Try
            Dim comm As OracleCommand = New OracleCommand()
            comm.Connection = oraConn
            comm.CommandText = sql
            Dim dr As OracleDataReader = comm.ExecuteReader()
            dt.Load(dr)
        Catch ex As Exception
            logFile.WriteErrMessage("[OpenDyns] " & sql)
            logFile.WriteErrMessage("[OpenDyns] " & ex.ToString)
            CheckExecute(False)
            MsgBox(ex.ToString, MsgBoxStyle.Information)
        End Try
        Return dt
    End Function
    Public Function ExeSQL(ByVal strSQL As String, Optional ByRef SQL_Execution_Error As String = "") As Boolean

        Dim oraCmd As OracleCommand

        If oraConnect Then
            oraCmd = New OracleCommand(strSQL, oraConn)
            oraCmd.CommandTimeout = 3
            Try
                oraCmd.ExecuteNonQuery()
                CheckExecute(True)
                Return True
            Catch e As Exception
                logFile.WriteErrMessage("[ExecuteSQL] " & strSQL)
                logFile.WriteErrMessage("[ExecuteSQL] " & e.ToString)
                SQL_Execution_Error = e.ToString
                CheckExecute(False)
                MsgBox(SQL_Execution_Error, MsgBoxStyle.Information)
                Return False
            End Try

        Else
            Return False
        End If
    End Function
    Public Function UploadImagePicture(Work_ID As Integer, PICTURE_ID As String, ByVal PICTURE_TYPE As String, byteimg As Byte(), SYSTEM_COMPUTER As String, SYSUSER As String) As Boolean

        Dim strSQL As String
        Dim oraCmd As OracleCommand

        If oraConnect Then
            Try
                oraCmd = New OracleCommand()
                oraCmd.Connection = oraConn
                strSQL = " DELETE FROM PICTURE_TAS WHERE PICTURE_ID=" + PICTURE_ID
                ExeSQL(strSQL)
                If Not (Work_ID.Equals(1)) Then
                    strSQL = "INSERT INTO TAS.PICTURE_TAS(PICTURE_ID,PICTURE_TYPE,PICTURE_DATA,UPDATED_BY,J_COMPUTER) VALUES(" & PICTURE_ID & "," & PICTURE_TYPE & ",:PICTURE_DATA,'" & SYSUSER & "','" & SYSTEM_COMPUTER & "') "

                    Dim blobParameter = New OracleParameter()
                    blobParameter.OracleDbType = OracleDbType.Blob
                    blobParameter.ParameterName = "PICTURE_DATA"
                    blobParameter.Value = byteimg
                    oraCmd.CommandText = strSQL
                    oraCmd.Parameters.Add(blobParameter)
                    oraCmd.ExecuteNonQuery()
                    Return True
                Else
                    strSQL = "INSERT INTO TAS.PICTURE_TAS(PICTURE_ID,PICTURE_TYPE,PICTURE_DATA,UPDATED_BY,J_COMPUTER) VALUES(" & PICTURE_ID & "," & PICTURE_TYPE & ",:PICTURE_DATA,'" & SYSUSER & "','" & SYSTEM_COMPUTER & "') "
                    Dim blobParameter = New OracleParameter()
                    blobParameter.OracleDbType = OracleDbType.Blob
                    blobParameter.ParameterName = "PICTURE_DATA"
                    blobParameter.Value = byteimg
                    oraCmd.CommandText = strSQL
                    oraCmd.Parameters.Add(blobParameter)
                    oraCmd.ExecuteNonQuery()
                    Return True
                End If

            Catch ex As Exception
                logFile.WriteErrMessage("[ExecuteSQL] " & strSQL)
                logFile.WriteErrMessage("[ExecuteSQL] " & ex.ToString)
                CheckExecute(False)
                Return False
            End Try
        Else
            Return False
        End If

    End Function
    Public Function ExeSQL(ByVal strSQL As String, ByVal iParam As COraParameter, Optional ByVal SQL_Execution_Error As String = "") As Boolean

        Dim oraParam As _ParamMember
        Dim oraCmd As OracleCommand
        Dim i As Integer
        Dim vCheck As Boolean = False
        Dim vKey() As String

        If oraConnect Then
            oraCmd = New OracleCommand()
            oraCmd.CommandTimeout = 3
            'New delvelop-----------
            ReDim vKey(iParam.OraParam.Count - 1)
            iParam.OraParam.Keys.CopyTo(vKey, 0)
            '-----------
            Try
                If iParam.OraParam IsNot Nothing Then  'execute with parameter
                    For i = 0 To iParam.GetOracleParamLength - 1
                        'Select Case iParam.OraParam(i).Direction
                        Select Case iParam.OraParam.Item(vKey(i)).Direction
                            Case _OracleDbDirection.OraInput
                                'New delvelop-----------
                                oraParam = iParam.OraParam.Item(vKey(i))
                                oraCmd.Parameters.Add(oraParam.Name, GetOracleDbType(oraParam.Type), _
                                                      oraParam.Value, _
                                                      GetOracleDbDirection(oraParam.Direction))
                                '-----------
                                'OraCmd.Parameters.Add(iParam.OraParam(i).Name, GetOracleDbType(iParam.OraParam(i).Type), _
                                '                      iParam.OraParam(i).Value, _
                                '                      GetOracleDbDirection(iParam.OraParam(i).Direction))
                            Case _OracleDbDirection.OraOutput
                                'New delvelop-----------
                                oraParam = iParam.OraParam.Item(vKey(i))
                                If iParam.OraParam.Item(vKey(i)).Type = _OracleDbType.OraVarchar2 Then

                                    oraCmd.Parameters.Add(oraParam.Name, GetOracleDbType(oraParam.Type), _
                                                          oraParam.Size, oraParam.Value, _
                                                          GetOracleDbDirection(oraParam.Direction))
                                    '-----------
                                    'If iParam.OraParam(i).Type = _OracleDbType.OraVarchar2 Then
                                    'OraCmd.Parameters.Add(iParam.OraParam(i).Name, GetOracleDbType(iParam.OraParam(i).Type), _
                                    '                      iParam.OraParam(i).Size, iParam.OraParam(i).Value, _
                                    '                      GetOracleDbDirection(iParam.OraParam(i).Direction))
                                Else
                                    oraCmd.Parameters.Add(oraParam.Name, GetOracleDbType(oraParam.Type), _
                                                      oraParam.Value, _
                                                      GetOracleDbDirection(oraParam.Direction))
                                    'OraCmd.Parameters.Add(iParam.OraParam(i).Name, GetOracleDbType(iParam.OraParam(i).Type), _
                                    '                      GetOracleDbDirection(iParam.OraParam(i).Direction))
                                End If

                        End Select
                    Next i
                End If

                oraCmd.CommandText = strSQL
                oraCmd.CommandType = CommandType.Text
                oraCmd.Connection = oraConn
                oraCmd.ExecuteNonQuery()
                'New delvelop-----------
                If iParam IsNot Nothing Then
                    For i = 0 To iParam.GetOracleParamLength - 1
                        oraParam = iParam.OraParam.Item(vKey(i))
                        If oraParam.Direction = _OracleDbDirection.OraOutput Then
                            oraParam.Value = oraCmd.Parameters(oraParam.Name).Value
                            iParam.OraParam.Item(vKey(i)) = oraParam
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

                vCheck = True
                CheckExecute(True)
                SQL_Execution_Error = "Execute Successful."
            Catch ex As Exception
                logFile.WriteErrMessage("[ExecuteSQL] " & strSQL)
                logFile.WriteErrMessage("[ExecuteSQL] " & ex.ToString)
                SQL_Execution_Error = ex.ToString
                CheckExecute(False)
                vCheck = False
            End Try

            oraCmd.Dispose()
            oraCmd = Nothing

        End If

        Return vCheck
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

    Public Function ConnectStatus() As Boolean
        Return oraConnect
    End Function

    Public Function ConnectServiceName() As String
        'ConnectServiceName = ""
        'Select Case CurrentDB
        '    Case DB_TYPE.DB_None
        '        ConnectServiceName = "Connect None"
        '    Case DB_TYPE.DB_MASTER
        '        ConnectServiceName = "Connect MASTER"
        '    Case DB_TYPE.DB_BACKUP
        '        ConnectServiceName = "Connect BACKUP"
        'End Select
        Select Case currentDB
            Case DB_TYPE.DB_MASTER
                oraServiceName = "Server A"
                oraServiceName = oraServiceName & " [" & oraConn.DatabaseName & "]"
            Case DB_TYPE.DB_BACKUP
                oraServiceName = "Server B"
                oraServiceName = oraServiceName & " [" & oraConn.DatabaseName & "]"
            Case Else
                oraServiceName = "Server = N/A"
        End Select
        Return oraServiceName.ToUpper
    End Function

#Region "Change Avtive database Server"

    Private Sub ScanActiveDatabase()
        Dim NewDB As DB_TYPE
        NewDB = SelectServer()
        If currentDB <> NewDB Then
            oraConnect = False
            currentDB = NewDB
            If currentDB <> DB_TYPE.DB_None Then
                Reconnect()
            End If
        Else
            If currentDB <> DB_TYPE.DB_None Then
                'isConnectedDB = GetConectServer(currentDB)
                'isMasterDatabase = GetIsMaster(currentDB)
                'If Not isConnectedDB Then
                If Not oraConnect Then
                    'currentDB = DB_TYPE.DB_None
                    oraConnect = False
                    Reconnect()
                End If
                'Connect()
            End If
        End If
    End Sub

    Private Function SelectServer() As DB_TYPE
        Dim ret As Integer = -1
        'ret = mIni.INIRead("D:\LLTLB\LLTLBConfig.ini", "SELECT", "SERVER", "")
        'Select Case ret
        '    Case 0
        '        GetSelectServerDb = DB_TYPE.DB_MASTER
        '    Case 1
        '        GetSelectServerDb = DB_TYPE.DB_BACKUP
        '    Case Else
        '        GetSelectServerDb = DB_TYPE.DB_None
        'End Select
        'GetSelectServerDb = DB_TYPE.DB_MASTER
        If thrScanDB(0).MasterDatabase <> -1 Or thrScanDB(1).MasterDatabase <> -1 Then 'check database connection (-1 = disconnect)
            If thrScanDB(0).MasterDatabase = 1 And thrScanDB(1).MasterDatabase = 1 Then 'compare last update_date
                Dim vResult As Integer = DateTime.Compare(thrScanDB(0).UpdateDate, thrScanDB(1).UpdateDate)
                If vResult >= 0 Then
                    ret = DB_TYPE.DB_MASTER
                Else
                    ret = DB_TYPE.DB_BACKUP
                End If
            Else
                If thrScanDB(0).MasterDatabase = 1 Then
                    ret = DB_TYPE.DB_MASTER
                End If
                If thrScanDB(1).MasterDatabase = 1 Then
                    ret = DB_TYPE.DB_BACKUP
                End If
            End If
        End If
        Return ret
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

Class ScanDatabase

    Dim thrScanDB As Thread
    Dim dbUser As String
    Dim dbPwd As String
    Dim dbName As String
    Dim strConnection As String
    Dim OraConn As OracleConnection
    Private connStrMaster As String = ConfigurationManager.ConnectionStrings("StrConnA").ConnectionString().Trim()
    Private connStrBackup As String = ConfigurationManager.ConnectionStrings("StrConnB").ConnectionString().Trim()
    'Dim chkDatabase As Integer = -1

    Public Sub New(ByVal pStrConnection)
        'dbUser = pUser
        'dbPwd = pPwd
        'dbName = pDbName
        strConnection = pStrConnection
        StartThread()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        thrScanDB.Abort()
    End Sub

    Protected Sub StartThread()
        thrScanDB = New Thread(AddressOf RunProcess)
        thrScanDB.Start()
    End Sub

    Protected Sub RunProcess()
      
        While (1)
            Try
                OraConn = New OracleConnection
                Dim vDataSet As New DataSet
                Dim dt As DataTable
                OraConn.ConnectionString = strConnection
                If OraConn.State <> ConnectionState.Open Then
                    OraConn.Open()
                    Dim OraDataReader As OracleDataReader = Nothing
                    Dim strSQL As String = "select t.config_data,t.update_date from tas.tas_config t where t.config_id=90" 'check database 1=master active
                    Try
                        If OpenDys(strSQL, "TableName1", vDataSet) Then
                            dt = vDataSet.Tables("TableName1")
                            _MasterDatabase = dt.Rows(0).Item("config_data").ToString()
                            _UpdateDate = dt.Rows(0).Item("update_date").ToString()

                            'If OraDataReader.HasRows Then
                            '    OraDataReader.Read()
                            '    _MasterDatabase = OraDataReader.Item("config_data")
                            '    _UpdateDate = OraDataReader.Item("update_date")
                            '    OraDataReader.Close()
                            'End If
                        Else
                            _MasterDatabase = -1
                        End If
                        Thread.Sleep(3000)
                    Catch ex As Exception
                        OraConn.Close()
                        Thread.Sleep(1000)
                    End Try
                End If



            Catch ex As Exception
                _MasterDatabase = -1
            End Try
            OraConn.Close()
            'oleDataReader.Close()
        End While
    End Sub

    Public Function OpenDys(ByVal strSQL As String, ByVal pTableName As String, ByRef mDataSet As DataSet,
                            Optional ByRef SQL_Execution_Error As String = "", Optional ByVal pShowErr As Boolean = True) As Boolean
        Dim oda As OracleDataAdapter
        Dim ds As New DataSet
        Dim bCheck As Boolean = False
        'ds = Nothing
        SQL_Execution_Error = ""

        Try
                oda = New OracleDataAdapter(strSQL, OraConn)
                oda.Fill(ds, pTableName)
                mDataSet = ds

            bCheck = True
                'Return True
            Catch ex As Exception

            If pShowErr Then
                'MsgBox(SQL_Execution_Error, MsgBoxStyle.Information)
            End If
                'Return False
            End Try

            mDataSet = ds
            ds = Nothing
            oda = Nothing


        Return bCheck
    End Function

#Region "property"
    Dim _MasterDatabase As Integer = -1
    Public ReadOnly Property MasterDatabase As Integer
        Get
            Return _MasterDatabase
        End Get
    End Property

    Dim _UpdateDate As Date
    Public ReadOnly Property UpdateDate As Date
        Get
            Return _UpdateDate
        End Get

    End Property
#End Region

End Class

Public Class COraParameter
    'Public OraParam() As COracle._ParamMember
    Public OraParam As Dictionary(Of String, COracle._ParamMember)

    Private _OraParam As COracle._ParamMember
    Private mTotalParam As Integer
    'New delvelop-----------
    Public Sub New()
        OraParam = New Dictionary(Of String, COracle._ParamMember)
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
    Public Overloads Sub CreateOracleParamOutput(ByVal ParamName As String, ByVal ParamType As COracle._OracleDbType)
        If OraParam IsNot Nothing Then
            With _OraParam
                .Name = ParamName
                .Type = ParamType
                .Direction = COracle._OracleDbDirection.OraOutput
            End With
            If OraParam.ContainsKey(ParamName) Then
                OraParam.Item(ParamName) = _OraParam
            Else
                OraParam.Add(ParamName, _OraParam)
            End If
        End If
    End Sub

    Public Overloads Sub CreateOracleParamOutput(ByVal ParamName As String, ByVal ParamType As COracle._OracleDbType, ByVal SizeValue As Integer)
        If OraParam IsNot Nothing Then
            With _OraParam
                .Name = ParamName
                .Type = ParamType
                .Size = SizeValue
                .Direction = COracle._OracleDbDirection.OraOutput
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