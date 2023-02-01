Imports System.Collections
Imports System.Windows
Imports System.Configuration
Module mVariable
#Region "Menu Screen ID"
    Enum AuthorizeID
        Access = 0
        Add = 1
        Edit = 2
        Delete = 3
        Cancel = 4
    End Enum

    Enum MainMenuID
        MasterData = 100
        LoadingSystem = 200
        HMI = 300
        PrintReport = 400
        ConfigSystem = 500
        History = 600
    End Enum

    Enum MasterDataMenuID
        Driver = 101
        Customer = 102
        Truck = 103
        Card = 104
        Supplier = 105
    End Enum

    Enum ConfigSystemMenuID
        CardReader = 501
        Meter = 502
        BatchController = 503
        ComportAndIP = 504
        Tank = 505
        IslandAndBay = 506
        BaseProduct = 507
        SaleProduct = 508
        Report = 509
        ScreenAuthorize = 510
        UserAndGroup = 511
        Preference = 512
    End Enum

#End Region

    Public Enum WorkFlow
        Add = 1
        Edit = 2
        Delete = 3
    End Enum
    Public Enum JournalType
        Jevent = 0
        JAlarm = 1
    End Enum

    Public fSize As Size    'defult height=768, width=1024
    Public Oradb As New COracle
    Public CRService As New CReportService
    'Public Oradb As COracle
    Public mIni As New CINI
    Public mLog As New CLog
    Public mUserName As String = "??????"
    Public mUserGroupName As String = "??????"
    Public mComputerName As String = ""
    Public mLogInSuccess As Boolean
    Public mMenuStack As New Stack(Of String)
    Public mForm As New Stack(Of Form)
    Public mScreenID As Long
    Public oraServer As String = "??????"

    Public CW As Integer '= fSize.Width ' Current Width
    Public CH As Integer '= fSize.Height ' Current Height
    Public IW As Integer '= fSize.Width ' Initial Width
    Public IH As Integer '= fSize.Height ' Initial Height
    Public cEncrypt As New CEncryption
    'Public FindData As New Form
    Public Grid_Height As Integer = 22
    'Copy Past สร้างกระบวนการจ่าย
    Public vClipOverride As String
    Public OvertxtDo As String
    Public OvercbCardBil As String
    Public OvercbTUHead As String
    Public OvercbTail As String
    Public OvercbDriverBil As String
    Public OvertxtSealNumber As String
    Public vTankName As String
    Public vCheckAlarmTank As Boolean = False

End Module
