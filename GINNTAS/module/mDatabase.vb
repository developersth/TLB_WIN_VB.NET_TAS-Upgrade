Imports System
Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports System.Threading
Imports System.IO

Module mDatabase
    Public Function P_CHECK_SCREEN_AUTHORIZE(ByVal pUserName As String _
                                           , ByVal pScreenID As Long, ByVal pAuthorizeID As Int16) As Boolean

        'Return True
        Dim bRet As Boolean = False
        Dim strSQL As String = "begin P_CHECK_SCREEN_AUTHORIZE(" & _
                                "'" & pUserName & "'," & pScreenID & "," & pAuthorizeID & _
                                ",:RET_CHECK,:RET_MSG" & _
                                ");end;"
        Dim Oraparam As New COraParameter
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt16)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(strSQL, Oraparam) Then
            RET_CHECK = Oraparam.GetOraclParamValue("RET_CHECK")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            'If RET_CHECK = 2 Then
            '    frmCheckUserPw.ShowDialog()
            '    If frmCheckUserPw.LogInSuccess = True Then
            '        RET_CHECK = 2
            '    Else
            '        RET_CHECK = -1
            '    End If
            'End If
            If RET_CHECK = -1 Then
                bRet = False
                MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            ElseIf RET_CHECK = 2 Then
                frmCheckUserPw.Close()
                frmCheckUserPw.ShowDialog()
                If frmCheckUserPw.LogInSuccess Then
                    bRet = True
                End If
            Else
                    bRet = True
            End If
        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing

        Return bRet
    End Function

    Public Function GetPathPictureDriver() As String
        Dim strSQL As String = "select t.value from mst.SYSTEM_PREFERENCE t where t.id=1"
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim vValue As String

        Try
            If Oradb.OpenDys(strSQL, "TableName", mDataSet) Then
                dt = mDataSet.Tables("TableName")
                vValue = IIf(IsDBNull(dt.Rows(0).Item("value")), "", dt.Rows(0).Item("value").ToString)
            Else
                GetPathPictureDriver = ""
            End If

            If vValue.ToLower = "default" Then
                vValue = GetCurrDirectory() & "\pictures\Driver\"
            End If
        Catch ex As Exception

        End Try
        mDataSet = Nothing
        Return vValue
    End Function

    Public Sub AddJournal(ByVal JType As JournalType, ByVal JSource As Long, ByVal JCategory As Long, ByVal JUser As String, ByVal JMsg As Long, _
                                              Optional ByVal JData1 As String = "???", Optional ByVal JData2 As String = "???", Optional ByVal JData3 As String = "???")
        Dim strSQL As String
        strSQL = _
            "Begin " & _
                "ADD_JOURNAL(" & _
                    JType & "," & JSource & "," & JCategory & "," & _
                    "'" & JUser & "','" & mComputerName & "'," & JMsg & "," & _
                    "'" & JData1 & "','" & JData2 & "','" & JData3 & "'); " & _
            "End;"
        Try
            Oradb.ExeSQL(strSQL)
        Catch ex As Exception

        End Try
    End Sub
    Public Function DeletePictureTAS(ByVal PICTURE_ID As String) As Boolean
        Dim strSQL As String
        If (Oradb.ConnectStatus = True) Then
            strSQL = "DELETE FROM PICTURE_TAS WHERE PICTURE_ID=" + PICTURE_ID
            DeletePictureTAS = Oradb.ExeSQL(strSQL)
        End If
        Return DeletePictureTAS
    End Function
    Public Function LogOffTAS() As Boolean
        Dim strSQL As String
        Dim mDataSet As New DataSet

        If mUserName <> "" And Oradb.ConnectStatus = True Then
            strSQL =
                "update USER_TAM T set " &
                    "T.IS_LOGON=0," &
                    "T.LOGOFF_TIME=sysdate," &
                    "T.UPDATE_DATE=sysdate," &
                    "T.UPDATED_BY='" & mUserName & "'," &
                    "T.J_COMPUTER='" & mComputerName & "' " &
                "where T.USER_ID='" & mUserName & "'"
            LogOffTAS = Oradb.OpenDys(strSQL, "TableName", mDataSet)
            Call AddJournal(JournalType.Jevent, 0, 100, mUserName, 102199, mUserName)
            'old_UserLogin = P_UserLogin
            mUserName = ""
            'P_HasConnected = False
        End If
        Return LogOffTAS
    End Function
End Module
