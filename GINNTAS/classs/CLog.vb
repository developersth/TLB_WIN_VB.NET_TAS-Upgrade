Imports System
Imports System.IO
Imports System.Threading

Public Class CLog
    Private PathLog As String
    Private CurrentDate As Date
    'Private mThreadLog As Thread
    'Private bCancelDeleteLog As Boolean = False

    Public Sub New()
        InitialLogPath()
        'mThreadLog = New Thread(New ThreadStart(AddressOf RunProcessLog))
        'mThreadLog.Start()
    End Sub

    'Private Sub RunProcessLog()
    '    While (1)
    '        If bCancelDeleteLog Then
    '            Exit While
    '        End If
    '        MainMaintailData()
    '        System.Threading.Thread.Sleep(60000)
    '    End While
    'End Sub

    Private Sub InitialLogPath()
        PathLog = My.Application.Info.DirectoryPath & "\Log"
        Directory.CreateDirectory(PathLog)
    End Sub

    Public Sub MainMaintailData()
        If CheckDelete() Then
            ScanDeleteLog(PathLog, 90)
        End If
    End Sub

    Private Function CheckDelete() As Boolean
        If CurrentDate.Day <> Now.Day Then
            CurrentDate = Now
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ScanDeleteLog(ByVal PathFile As String, ByVal NumDay As Integer)
        Dim DateLastModified As DateTime
        Dim DateDelete As DateTime

        Try
            DateDelete = DateTime.Now.AddDays(-1 * NumDay)
            Dim fileEntries As String() = Directory.GetFiles(PathFile)
            For Each Filename As String In fileEntries
                DateLastModified = File.GetCreationTime(Filename)
                If DateLastModified < DateDelete Then
                    File.Delete(Filename)
                End If
            Next

        Catch ex As Exception

        End Try
    End Sub

    Public Sub WriteSQLMessage(ByVal mMsg As String)
        'Me.ListView1.Items.Insert(0, Format(Now, "dd/MM/yyyy HH:mm:ss"))
        'Me.ListView1.Items.Item(0).SubItems.Add(mSource)
        'Me.ListView1.Items.Item(0).SubItems.Add(mMsg)
        Try
            Dim m_FILE_NAME As String
            m_FILE_NAME = PathLog & "\SQL_" & Format(DateTime.Now, "ddMMyyyy") & ".log"
            Dim sw As StreamWriter = File.AppendText(m_FILE_NAME)
            'sw.WriteLine(Format(Now, "dd/MM/yyyy HH:mm:ss") & " " & mSource & " " & mMsg)
            sw.WriteLine(DateTime.Now & " " & mMsg)
            sw.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub WriteErrMessage(ByVal mMsg As String)
        'Me.ListView1.Items.Insert(0, Format(Now, "dd/MM/yyyy HH:mm:ss"))
        'Me.ListView1.Items.Item(0).SubItems.Add(mSource)
        'Me.ListView1.Items.Item(0).SubItems.Add(mMsg)
        Try
            Dim m_FILE_NAME As String
            m_FILE_NAME = PathLog & "\Err_" & Format(DateTime.Now, "ddMMyyyy") & ".log"
            Dim sw As StreamWriter = File.AppendText(m_FILE_NAME)
            'sw.WriteLine(Format(Now, "dd/MM/yyyy HH:mm:ss") & " " & mSource & " " & mMsg)
            sw.WriteLine(DateTime.Now & " " & mMsg)
            sw.Close()
        Catch ex As Exception

        End Try
    End Sub

    Protected Overrides Sub Finalize()
        'bCancelDeleteLog = False
        MyBase.Finalize()
    End Sub
End Class
