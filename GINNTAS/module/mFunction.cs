using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GINNTAS
{
    static class mFunction
    {
        public static string AlarmMssg;

        public static string GetComputerName()
        {
            string ComputerName;
            ComputerName = System.Net.Dns.GetHostName();
            return ComputerName;
        }

        private static void GetScreenResolution(ref int pHeight, ref int pWidth)
        {
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            pHeight = intY;
            pWidth = intX;
        }

        public static void SetScreenResulotion()
        {
            // fSize.Height = SystemParameters.PrimaryScreenHeight
            // fSize.Width = SystemParameters.PrimaryScreenWidth
            string value;
            string sfilename;
            try
            {
                sfilename = GetCurrDirectory() + "/config.ini";
                if (GINNTAS.My.MyProject.Computer.FileSystem.FileExists(sfilename))
                {
                    // fSize.Height = 768
                    // fSize.Width = 1024
                    value = GINNTAS.mVariable.mIni.INIRead(sfilename, "ScreenResolution", "Height");
                    if (value == "default")
                    {
                        int argpHeight = (int)Math.Round(GINNTAS.mVariable.fSize.Height);
                        int argpWidth = (int)Math.Round(GINNTAS.mVariable.fSize.Width);
                        GetScreenResolution(ref argpHeight, ref argpWidth);
                        GINNTAS.mVariable.fSize.Height = argpHeight;
                        GINNTAS.mVariable.fSize.Width = argpWidth;
                    }
                    else
                    {
                        GINNTAS.mVariable.fSize.Height = Convert.ToSingle(value);
                    }

                    value = GINNTAS.mVariable.mIni.INIRead(sfilename, "ScreenResolution", "Width");
                    if (value == "default")
                    {
                        int argpHeight1 = (int)Math.Round(GINNTAS.mVariable.fSize.Height);
                        int argpWidth1 = (int)Math.Round(GINNTAS.mVariable.fSize.Width);
                        GetScreenResolution(ref argpHeight1, ref argpWidth1);
                        GINNTAS.mVariable.fSize.Height = argpHeight1;
                        GINNTAS.mVariable.fSize.Width = argpWidth1;
                    }
                    else
                    {
                        GINNTAS.mVariable.fSize.Width = Convert.ToSingle(value);
                    }
                }
                else
                {
                    int argpHeight2 = (int)Math.Round(GINNTAS.mVariable.fSize.Height);
                    int argpWidth2 = (int)Math.Round(GINNTAS.mVariable.fSize.Width);
                    GetScreenResolution(ref argpHeight2, ref argpWidth2);
                    GINNTAS.mVariable.fSize.Height = argpHeight2;
                    GINNTAS.mVariable.fSize.Width = argpWidth2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string GetCurrDirectory()
        {
            string sDirectory;
            sDirectory = new FileInfo(Application.ExecutablePath).DirectoryName; // Environment.CurrentDirectory()
            return sDirectory;
        }

        public static bool GetStatusDatabase()
        {
            return GINNTAS.mVariable.Oradb.ConnectStatus();
        }

        public static string GetCurrentMenu()
        {
            var sMenu = default(string);
            foreach (string s in GINNTAS.mVariable.mMenuStack)
                sMenu = Convert.ToString(s) + @" \ " + sMenu;
            sMenu = sMenu.Trim();
            sMenu = sMenu.Substring(0, sMenu.Length - 1);
            return sMenu;
        }

        public static string GetReportFileName(double pReportID)
        {
            string strSQL = "select t.REPORT_PATH,t.IS_ENABLED" + " from REPORT_SETTING t" + " where t.REPORT_ID=" + pReportID;
            var mDataSet = new DataSet();
            DataTable dt;
            string bRet = "";
            string argSQL_Execution_Error = "";
            if (GINNTAS.mVariable.Oradb.OpenDys(strSQL, "TableName", ref mDataSet, SQL_Execution_Error: ref argSQL_Execution_Error))
            {
                dt = mDataSet.Tables["TableName"];
                if (dt.Rows.Count > 0)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dt.Rows[0]["IS_ENABLED"], 1, false)))
                    {
                        bRet = dt.Rows[0]["REPORT_PATH"].ToString();
                    }
                    else
                    {
                        Interaction.MsgBox("รายงานหมายเลข " + pReportID + " หยุดใช้งาน", MsgBoxStyle.Information);
                    }
                }
                else
                {
                    Interaction.MsgBox("ไม่พบข้อมูลรายงานหมายเลข " + pReportID, MsgBoxStyle.Information);
                }
            }

            return bRet;
        }

        public static void PushForm(Form pF)
        {
            GINNTAS.mVariable.mForm.Push(pF);
        }

        public static void PopForm()
        {
            Form f;
            GINNTAS.mVariable.mMenuStack.Pop();
            f = GINNTAS.mVariable.mForm.Pop();
            // f.Visible = False
            f.ShowInTaskbar = true;
            f.Show();
            f.WindowState = FormWindowState.Normal;
            // f.Visible = True
        }

        public static bool OpenForm(short pScreenID, string pTitleName)
        {
            try
            {
                GINNTAS.mVariable.mScreenID = pScreenID;
                switch (pScreenID)
                {
                    case 100:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMasterData.Show();
                            GINNTAS.My.MyProject.Forms.frmMasterData.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMasterData.lblTitleName.Text = GetCurrentMenu();
                            return true;
                        }

                    case 101:
                        {
                            // PushForm(frmMasterData)
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmConfigBaseProduct_main.Show();
                            GINNTAS.My.MyProject.Forms.frmConfigBaseProduct_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmConfigBaseProduct_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 102:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmConfigTank_main.Show();
                            GINNTAS.My.MyProject.Forms.frmConfigTank_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmConfigTank_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 103:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmConfigSaleProduct_main.Show();
                            GINNTAS.My.MyProject.Forms.frmConfigSaleProduct_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmConfigSaleProduct_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 104:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmConfigIsland_main.Show();
                            GINNTAS.My.MyProject.Forms.frmConfigIsland_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmConfigIsland_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 105:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmConfigPump_main.Show();
                            GINNTAS.My.MyProject.Forms.frmConfigPump_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmConfigPump_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 106:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmConfigMeter_main.Show();
                            GINNTAS.My.MyProject.Forms.frmConfigMeter_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmConfigMeter_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 107:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmConfigBay_main.Show();
                            GINNTAS.My.MyProject.Forms.frmConfigBay_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmConfigBay_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 108:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmConfigReportSetting_main.Show();
                            GINNTAS.My.MyProject.Forms.frmConfigReportSetting_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmConfigReportSetting_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 109:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmConfigReportHeaders_main.Show();
                            GINNTAS.My.MyProject.Forms.frmConfigReportHeaders_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmConfigReportHeaders_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 110:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmConfigCardReader_main.Show();
                            GINNTAS.My.MyProject.Forms.frmConfigCardReader_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmConfigCardReader_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 111:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmConfigPrinters_main.Show();
                            GINNTAS.My.MyProject.Forms.frmConfigPrinters_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmConfigPrinters_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 112:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmConfigCommport_main.Show();
                            GINNTAS.My.MyProject.Forms.frmConfigCommport_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmConfigCommport_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 200:
                        {
                            break;
                        }
                    // mMenuStack.Push(pTitleName)
                    // frmLoadingSystem.Show()
                    // frmLoadingSystem.FormScreenID = pScreenID
                    // frmLoadingSystem.lblTitleName.Text = GetCurrentMenu()
                    // Return True
                    case 201:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmProofJournal.Show();
                            GINNTAS.My.MyProject.Forms.frmProofJournal.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmProofJournal.UcHeader1.MenuText = GetCurrentMenu();
                            // frmProofJournal.WindowState = FormWindowState.Normal
                            return true;
                        }

                    case 202:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmProofQueue.Show();
                            GINNTAS.My.MyProject.Forms.frmProofQueue.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmProofQueue.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 203:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmProofLoading.Show();
                            GINNTAS.My.MyProject.Forms.frmProofLoading.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmProofLoading.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 204:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmProofLoadIncomplete.Show();
                            GINNTAS.My.MyProject.Forms.frmProofLoadIncomplete.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmProofLoadIncomplete.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 205:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmProofLoadingComplete.Show();
                            GINNTAS.My.MyProject.Forms.frmProofLoadingComplete.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmProofLoadingComplete.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 206:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmProofSendDataErp.Show();
                            GINNTAS.My.MyProject.Forms.frmProofSendDataErp.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmProofSendDataErp.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 207:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmProofSAPTAS.Show();
                            GINNTAS.My.MyProject.Forms.frmProofSAPTAS.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmProofSAPTAS.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 208:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmProofSumOrder.Show();
                            GINNTAS.My.MyProject.Forms.frmProofSumOrder.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmProofSumOrder.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 209:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmProofMonitorTank.Show();
                            GINNTAS.My.MyProject.Forms.frmProofMonitorTank.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmProofMonitorTank.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 210:
                        {
                            // mMenuStack.Push(pTitleName)
                            GINNTAS.My.MyProject.Forms.frmDeviceEven.Show();
                            break;
                        }
                    // Return True

                    case 301:
                        {
                            GINNTAS.My.MyProject.Forms.frmMMINetworkStatus.Close();
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMMINetworkStatus.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMMINetworkStatus.ShowDialog();
                            // frmMMINetwork.UcHeader1.MenuText = GetCurrentMenu()
                            return true;
                        }

                    case 302:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMMITank.Show();
                            GINNTAS.My.MyProject.Forms.frmMMITank.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMMITank.UcHeader1.MenuText = GetCurrentMenu();
                            // frmMMITank.WindowState = FormWindowState.Normal
                            return true;
                        }

                    case 303:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMMIOverView.Show();
                            GINNTAS.My.MyProject.Forms.frmMMIOverView.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMMIOverView.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 304:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMMIBayLoading.Show();
                            GINNTAS.My.MyProject.Forms.frmMMIBayLoading.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMMIBayLoading.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 305:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMMIPumpReceive.Show();
                            GINNTAS.My.MyProject.Forms.frmMMIPumpReceive.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMMIPumpReceive.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 306:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMMIPumpBay.Show();
                            GINNTAS.My.MyProject.Forms.frmMMIPumpBay.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMMIPumpBay.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 307:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMMIPlantLayout.Show();
                            GINNTAS.My.MyProject.Forms.frmMMIPlantLayout.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMMIPlantLayout.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 308:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMMIMonitorMeter.Show();
                            GINNTAS.My.MyProject.Forms.frmMMIMonitorMeter.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMMIMonitorMeter.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 309:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMMIProcessFlowTLB.Show();
                            GINNTAS.My.MyProject.Forms.frmMMIProcessFlowTLB.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMMIProcessFlowTLB.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 310:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMMIWeighBridge.Show();
                            GINNTAS.My.MyProject.Forms.frmMMIWeighBridge.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMMIWeighBridge.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 311:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMMIProcessSlop.Show();
                            GINNTAS.My.MyProject.Forms.frmMMIProcessSlop.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMMIProcessSlop.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 400:
                        {
                            break;
                        }
                    // mMenuStack.Push(pTitleName)
                    // frmMasterData.Show()
                    // frmMasterData.FormScreenID = pScreenID
                    // frmMasterData.lblTitleName.Text = GetCurrentMenu()
                    // Return True
                    case 401:
                        {
                            // PushForm(frmMasterData)
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            // frmMainCustomer_main.Show()
                            GINNTAS.My.MyProject.Forms.frmMainCustomer_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMainCustomer_main.UcHeader1.MenuText = GetCurrentMenu();
                            GINNTAS.My.MyProject.Forms.frmMainCustomer_main.Show();
                            return true;
                        }

                    case 402:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMainCarrier_main.Show();
                            GINNTAS.My.MyProject.Forms.frmMainCarrier_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMainCarrier_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 403:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMainTransportUnit_main.Show();
                            GINNTAS.My.MyProject.Forms.frmMainTransportUnit_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMainTransportUnit_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 404:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMainVehicle_main.Show();
                            GINNTAS.My.MyProject.Forms.frmMainVehicle_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMainVehicle_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 405:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMainDriver_main.Show();
                            GINNTAS.My.MyProject.Forms.frmMainDriver_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMainDriver_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 406:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMainCard_main.Show();
                            GINNTAS.My.MyProject.Forms.frmMainCard_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMainCard_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 407:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmMainShipTo_main.Show();
                            GINNTAS.My.MyProject.Forms.frmMainShipTo_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmMainShipTo_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 500:
                        {
                            break;
                        }
                    // mMenuStack.Push(pTitleName)
                    // frmMasterData.Show()
                    // frmMasterData.FormScreenID = pScreenID
                    // frmMasterData.lblTitleName.Text = GetCurrentMenu()
                    // Return True
                    case 501:
                        {
                            // PushForm(frmMasterData)
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmLoadDO.Show();
                            GINNTAS.My.MyProject.Forms.frmLoadDO.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmLoadDO.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 502:
                        {
                            // PushForm(frmMasterData)
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmLoadLoading.Show();
                            GINNTAS.My.MyProject.Forms.frmLoadLoading.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmLoadLoading.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 503:
                        {
                            // PushForm(frmMasterData)
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmLoadSeal.Show();
                            GINNTAS.My.MyProject.Forms.frmLoadSeal.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmLoadSeal.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 504:
                        {
                            // PushForm(frmMasterData)
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmLoadWeight.Show();
                            GINNTAS.My.MyProject.Forms.frmLoadWeight.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmLoadWeight.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 505:
                        {
                            // PushForm(frmMasterData)
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmLoadTopUp.Show();
                            GINNTAS.My.MyProject.Forms.frmLoadTopUp.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmLoadTopUp.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 506:
                        {
                            // PushForm(frmMasterData)
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmLoadCustomerQuota.Show();
                            GINNTAS.My.MyProject.Forms.frmLoadCustomerQuota.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmLoadCustomerQuota.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 600:
                        {
                            break;
                        }
                    // mMenuStack.Push(pTitleName)
                    // frmMasterData.Show()
                    // frmMasterData.FormScreenID = pScreenID
                    // frmMasterData.lblTitleName.Text = GetCurrentMenu()
                    // Return True
                    case 601:
                        {
                            // PushForm(frmMasterData)
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmUnloading_main.Show();
                            GINNTAS.My.MyProject.Forms.frmUnloading_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmUnloading_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 602:
                        {
                            // PushForm(frmMasterData)
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmUnInvTank.Show();
                            GINNTAS.My.MyProject.Forms.frmUnInvTank.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmUnInvTank.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 603:
                        {
                            // PushForm(frmMasterData)
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmUnInMeter.Show();
                            GINNTAS.My.MyProject.Forms.frmUnInMeter.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmUnInMeter.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 800:
                        {
                            break;
                        }
                    // mMenuStack.Push(pTitleName)
                    // frmMasterData.Show()
                    // frmMasterData.FormScreenID = pScreenID
                    // frmMasterData.lblTitleName.Text = GetCurrentMenu()
                    // Return True
                    case 801:
                        {
                            // PushForm(frmMasterData)
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmUtlUsers_main.Show();
                            GINNTAS.My.MyProject.Forms.frmUtlUsers_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmUtlUsers_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 802:
                        {
                            // PushForm(frmMasterData)
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmUtlSecurity.Show();
                            GINNTAS.My.MyProject.Forms.frmUtlSecurity.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmUtlSecurity.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 803:
                        {
                            // PushForm(frmMasterData)
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmUtlOverrideCR.Show();
                            GINNTAS.My.MyProject.Forms.frmUtlOverrideCR.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmUtlOverrideCR.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 804:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmUtlReportEditor.Show();
                            GINNTAS.My.MyProject.Forms.frmUtlReportEditor.FormScreenID = pScreenID;
                            // frmUtlReportEditor.lblTitleName.Text = GetCurrentMenu()
                            return true;
                        }

                    case 805:
                        {
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.FrmUtlChangPsw.Show();
                            GINNTAS.My.MyProject.Forms.FrmUtlChangPsw.FormScreenID = pScreenID;
                            return true;
                        }

                    case 806:
                        {
                            // PushForm(frmMasterData)
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmUtlWeighBridge_main.Show();
                            GINNTAS.My.MyProject.Forms.frmUtlWeighBridge_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmUtlWeighBridge_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 807:
                        {
                            // PushForm(frmMasterData)
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmUtlTasConfig_main.Show();
                            GINNTAS.My.MyProject.Forms.frmUtlTasConfig_main.FormScreenID = pScreenID;
                            GINNTAS.My.MyProject.Forms.frmUtlTasConfig_main.UcHeader1.MenuText = GetCurrentMenu();
                            return true;
                        }

                    case 808:
                        {
                            // PushForm(frmMasterData)
                            GINNTAS.mVariable.mMenuStack.Push(pTitleName);
                            GINNTAS.My.MyProject.Forms.frmUtlEndOfday.Show();
                            GINNTAS.My.MyProject.Forms.frmUtlEndOfday.FormScreenID = pScreenID;
                            // frmUtlEndOfday.lblTitleName.Text = GetCurrentMenu()
                            return true;
                        }

                    case 809:
                        {
                            // PushForm(frmMasterData)
                            // mMenuStack.Push(pTitleName)
                            // frmLoadCreateLoad.Show()
                            // frmLoadCreateLoad.FormScreenID = pScreenID
                            // frmLoadCreateLoad.UcHeader1.Text = GetCurrentMenu()
                            GINNTAS.My.MyProject.Forms.frmLoadLoading_sub.Close();
                            GINNTAS.My.MyProject.Forms.frmLoadLoading_sub.ShowDialog();
                            // frmLoadCreateLoad.FormScreenID = pScreenID
                            return true;
                        }

                    default:
                        {
                            Interaction.MsgBox("Missing Screen ID[" + pScreenID + "]", (MsgBoxStyle)((int)Constants.vbCritical + (int)Constants.vbOKOnly));
                            return false;
                        }
                }
            }
            catch (Exception ex)
            {
                GINNTAS.mVariable.mLog.WriteErrMessage(ex.Message);
                return false;
            }

            return true;
        }

        public static bool CloseForm(long pScreenID, string pTitleName)
        {
            try
            {
                switch (pScreenID)
                {
                    case 100L:
                        {
                            PopForm();
                            return true;
                        }
                    // mForm.Push(frmMain)
                    // mMenuStack.Push(pTitleName)
                    // frmMasterData.Show()
                    // frmMasterData.FormScreenID = pScreenID
                    // frmMasterData.lblTitleName.Text = GetCurrentMenu()
                    case 101L:
                        {
                            PopForm();
                            return true;
                        }

                    case 102L:
                        {
                            PopForm();
                            return true;
                        }

                    case 103L:
                        {
                            PopForm();
                            return true;
                        }

                    case 104L:
                        {
                            PopForm();
                            return true;
                        }

                    case 105L:
                        {
                            PopForm();
                            return true;
                        }

                    case 106L:
                        {
                            PopForm();
                            return true;
                        }

                    case 107L:
                        {
                            PopForm();
                            return true;
                        }

                    case 108L:
                        {
                            PopForm();
                            return true;
                        }

                    case 109L:
                        {
                            PopForm();
                            return true;
                        }

                    case 110L:
                        {
                            PopForm();
                            return true;
                        }

                    case 111L:
                        {
                            PopForm();
                            return true;
                        }

                    case 112L:
                        {
                            PopForm();
                            return true;
                        }

                    case 200L:
                        {
                            PopForm();
                            return true;
                        }

                    case 201L:
                        {
                            PopForm();
                            return true;
                        }

                    case 202L:
                        {
                            PopForm();
                            return true;
                        }

                    case 203L:
                        {
                            PopForm();
                            return true;
                        }

                    case 204L:
                        {
                            PopForm();
                            return true;
                        }

                    case 205L:
                        {
                            PopForm();
                            return true;
                        }

                    case 206L:
                        {
                            PopForm();
                            return true;
                        }

                    case 207L:
                        {
                            PopForm();
                            return true;
                        }

                    case 208L:
                        {
                            PopForm();
                            return true;
                        }

                    case 209L:
                        {
                            PopForm();
                            return true;
                        }

                    case 210L:
                        {
                            PopForm();
                            return true;
                        }

                    case 300L:
                        {
                            PopForm();
                            return true;
                        }

                    case 301L:
                        {
                            PopForm();
                            return true;
                        }

                    case 302L:
                        {
                            PopForm();
                            return true;
                        }

                    case 303L:
                        {
                            PopForm();
                            return true;
                        }

                    case 304L:
                        {
                            PopForm();
                            return true;
                        }

                    case 305L:
                        {
                            PopForm();
                            return true;
                        }

                    case 306L:
                        {
                            PopForm();
                            return true;
                        }

                    case 307L:
                        {
                            PopForm();
                            return true;
                        }

                    case 308L:
                        {
                            PopForm();
                            return true;
                        }

                    case 309L:
                        {
                            PopForm();
                            return true;
                        }

                    case 310L:
                        {
                            PopForm();
                            return true;
                        }

                    case 311L:
                        {
                            PopForm();
                            return true;
                        }

                    case 400L:
                        {
                            PopForm();
                            return true;
                        }

                    case 401L:
                        {
                            PopForm();
                            return true;
                        }

                    case 402L:
                        {
                            PopForm();
                            return true;
                        }

                    case 403L:
                        {
                            PopForm();
                            return true;
                        }

                    case 404L:
                        {
                            PopForm();
                            return true;
                        }

                    case 405L:
                        {
                            PopForm();
                            return true;
                        }

                    case 406L:
                        {
                            PopForm();
                            return true;
                        }

                    case 407L:
                        {
                            PopForm();
                            return true;
                        }

                    case 500L:
                        {
                            PopForm();
                            return true;
                        }

                    case 501L:
                        {
                            PopForm();
                            return true;
                        }

                    case 502L:
                        {
                            PopForm();
                            return true;
                        }

                    case 503L:
                        {
                            PopForm();
                            return true;
                        }

                    case 504L:
                        {
                            PopForm();
                            return true;
                        }

                    case 505L:
                        {
                            PopForm();
                            return true;
                        }

                    case 506L:
                        {
                            PopForm();
                            return true;
                        }

                    case 600L:
                        {
                            PopForm();
                            return true;
                        }

                    case 601L:
                        {
                            PopForm();
                            return true;
                        }

                    case 602L:
                        {
                            PopForm();
                            return true;
                        }

                    case 603L:
                        {
                            PopForm();
                            return true;
                        }

                    case 800L:
                        {
                            PopForm();
                            return true;
                        }

                    case 801L:
                        {
                            PopForm();
                            return true;
                        }

                    case 802L:
                        {
                            PopForm();
                            return true;
                        }

                    case 803L:
                        {
                            PopForm();
                            return true;
                        }

                    case 804L:
                        {
                            PopForm();
                            return true;
                        }

                    case 805L:
                        {
                            PopForm();
                            return true;
                        }

                    case 806L:
                        {
                            PopForm();
                            return true;
                        }

                    case 807L:
                        {
                            PopForm();
                            return true;
                        }

                    case 808L:
                        {
                            PopForm();
                            return true;
                        }

                    case 809L:
                        {
                            PopForm();
                            return true;
                        }

                    default:
                        {
                            Interaction.MsgBox("Missing Screen ID[" + pScreenID + "]", (MsgBoxStyle)((int)Constants.vbCritical + (int)Constants.vbOKOnly));
                            return false;
                        }
                }
            }
            catch (Exception ex)
            {
                GINNTAS.mVariable.mLog.WriteErrMessage(ex.Message);
                return false;
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public static void CheckFormResize(ref Form f)
        {
            // SetScreenResulotion()
            if (GINNTAS.mVariable.fSize == default(System.Windows.Size))
                return;
            if (f.WindowState == FormWindowState.Minimized)
                return;
            f.Size = new Size((int)Math.Round(GINNTAS.mVariable.fSize.Width), (int)Math.Round(GINNTAS.mVariable.fSize.Height));
            CheckFormCenterScreen(ref f);
        }

        public static void CheckFormCenterScreen(ref Form frm)
        {
            int boundWidth = Screen.PrimaryScreen.Bounds.Width;
            int boundHeight = Screen.PrimaryScreen.Bounds.Height;
            int x = boundWidth - frm.Width;
            int y = boundHeight - frm.Height;
            frm.Location = new Point((int)Math.Round(x / 2d), (int)Math.Round(y / 2d));
        }

        public static void ResizeFormControls(ref Form f)
        {
            double RW = (double)(f.Width - GINNTAS.mVariable.CW) / (double)GINNTAS.mVariable.CW; // Ratio change of width
            double RH = (double)(f.Height - GINNTAS.mVariable.CH) / (double)GINNTAS.mVariable.CH; // Ratio change of height
            foreach (Control Ctrl in f.Controls)
            {
                if (Ctrl is UserControl)
                {
                }
                else
                {
                    Ctrl.Width += (int)Math.Round(Ctrl.Width * RW);
                    Ctrl.Height += (int)Math.Round(Ctrl.Height * RH);
                    Ctrl.Left += (int)Math.Round(Ctrl.Left * RW);
                    Ctrl.Top += (int)Math.Round(Ctrl.Top * RH);
                }
            }

            GINNTAS.mVariable.CW = f.Width;
            GINNTAS.mVariable.CH = f.Height;
        }

        // Public Sub InitialFormMnuType1(ByRef f As Form, ByRef pTitleName As String)
        // f.BackgroundImageLayout = ImageLayout.Stretch
        // f.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\BG_SUB.png")
        // 'TitleName
        // InitialTitleName(f, pTitleName)
        // f.Text = My.Application.Info.ProductName
        // InitialUcMnu(f)
        // End Sub

        public static void InitialFormConfig(ref Form f, string pTitleName)
        {
            // f.BackgroundImageLayout = ImageLayout.Stretch
            // f.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\BG_SUB.png")
            // TitleName
            var allLabel = from lbl in f.Controls.OfType<Label>()
                           where lbl.Name == "lblTitleName"
                           select lbl;
            foreach (Label lbl in allLabel)
            {
                lbl.ForeColor = Color.WhiteSmoke;
                lbl.BackColor = Color.Transparent;

                // lbl.Text = GetCurrentMenu()
                // lbl.Left = f.Width - lbl.Width
                lbl.Width = (int)Math.Round(f.Width / 2d);
                lbl.Left = (int)Math.Round(f.Width / 2d);
                lbl.Top = (int)Math.Round(75 * f.Height / 1080d);
            }

            allLabel = null;
            var ucClosed_All = from ucClosed in f.Controls.OfType<UserControl>()
                               where ucClosed.Name == "UcClose1"
                               select ucClosed;
            foreach (UserControl ucClosed in ucClosed_All)
            {
                ucClosed.Left = f.Width - ucClosed.Width;
                ucClosed.Top = 0;
                ucClosed.Height = (int)Math.Round(65 * f.Height / 1080d);
                ucClosed.Width = (int)Math.Round(65 * f.Width / 1920d);
            }

            ucClosed_All = null;
            var UcMinimize_All = from UcMinimize in f.Controls.OfType<UserControl>()
                                 where UcMinimize.Name == "UcMinimize1"
                                 select UcMinimize;
            foreach (UserControl UcMinimize in UcMinimize_All)
            {
                UcMinimize.Left = f.Width - UcMinimize.Width * 2;
                UcMinimize.Top = 0;
                UcMinimize.Height = (int)Math.Round(65 * f.Height / 1080d);
                UcMinimize.Width = (int)Math.Round(65 * f.Width / 1920d);
            }

            UcMinimize_All = null;
            var ucStatus_All = from ucStatus in f.Controls.OfType<UserControl>()
                               where ucStatus.Name == "UcStatus1"
                               select ucStatus;
            foreach (UserControl ucStatus in ucStatus_All)
            {
                ucStatus.Height = 60;
                ucStatus.Dock = DockStyle.Bottom;
            }

            ucStatus_All = null;
            var Allctrl = from ctrl in f.Controls.OfType<DataGridView>()
                          where ctrl.Name == "DataGridView1"
                          select ctrl;
            foreach (DataGridView ctrl in Allctrl)
            {
                ctrl.Width = 806;
                ctrl.Height = 534;
                ctrl.Left = 33;
                ctrl.Top = 133;
                ctrl.Anchor = (AnchorStyles)Conversions.ToInteger((int)AnchorStyles.Left + (int)AnchorStyles.Right == (int)AnchorStyles.Bottom + (int)AnchorStyles.Top);
                ctrl.RowHeadersVisible = false;
                ctrl.CellBorderStyle = DataGridViewCellBorderStyle.None;
                for (int i = 0, loopTo = ctrl.ColumnCount - 1; i <= loopTo; i++)
                {
                    var col = new DataGridViewColumn();
                    col = ctrl.Columns[i];
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }

            Allctrl = null;

            // InitialSplitContainer(f)
            Graphics gr;
            Bitmap bm;
            // Dim tempBG As Bitmap

            var allSpli = f.Controls.OfType<SplitContainer>();
            foreach (SplitContainer ctrl in allSpli)
            {
                Rectangle src_rect;
                Rectangle dst_rect;
                // .Visible = False
                ctrl.SplitterDistance = 200;
                ctrl.SplitterWidth = 4;
                ctrl.Left = 0;
                ctrl.Top = 100;
                ctrl.Width = f.Width;
                // .Height = 600
                ctrl.Anchor = (AnchorStyles)((int)AnchorStyles.Bottom + (int)AnchorStyles.Left + (int)AnchorStyles.Right + (int)AnchorStyles.Top);
                ctrl.Panel2.Padding = new Padding(8);
                // tempBG = New Bitmap(f.Width, f.Height)
                // tempBG = f.BackgroundImage

                // tempBG.Save(GetCurrDirectory() & "\110.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

                bm = new Bitmap(ctrl.Width, ctrl.Height);
                gr = ctrl.CreateGraphics();
                gr = Graphics.FromImage(bm);
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                // src_rect = New Rectangle(ctrl.Left * 96 / 72, ctrl.Top * 96 / 72, ctrl.Width * 96 / 72, ctrl.Height * 96 / 72)
                // dst_rect = New Rectangle(0, 0, ctrl.Width * 96 / 72, ctrl.Height * 96 / 72)
                src_rect = new Rectangle(ConvertPixelToPoint(ctrl.Left, f.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Top, f.BackgroundImage.VerticalResolution), ConvertPixelToPoint(ctrl.Width, f.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Height, f.BackgroundImage.VerticalResolution));


                dst_rect = new Rectangle(0, 0, ConvertPixelToPoint(ctrl.Width, f.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Height, f.BackgroundImage.VerticalResolution));


                gr.DrawImage(f.BackgroundImage, dst_rect, src_rect, GraphicsUnit.Point);
                ctrl.BackgroundImage = bm;

                // bm.Save(GetCurrDirectory() & "\111.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
                // bm.Dispose()
                // gr.Dispose()
                // tempBG.Dispose()

                // Panel(1)
                // tempBG = New Bitmap(ctrl.Width, ctrl.Height)
                // tempBG = ctrl.BackgroundImage
                bm = new Bitmap(ctrl.SplitterDistance, ctrl.Height);
                gr = Graphics.FromImage(bm);
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;

                // src_rect = New Rectangle(ctrl.Left, ctrl.Top, ctrl.SplitterDistance, ctrl.Height)
                // dst_rect = New Rectangle(0, 0, ctrl.SplitterDistance, ctrl.Height)
                src_rect = new Rectangle(ConvertPixelToPoint(ctrl.Left, ctrl.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Top, ctrl.BackgroundImage.VerticalResolution), ConvertPixelToPoint(ctrl.SplitterDistance, ctrl.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Height, ctrl.BackgroundImage.VerticalResolution));


                dst_rect = new Rectangle(0, 0, ConvertPixelToPoint(ctrl.SplitterDistance, ctrl.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Height, ctrl.BackgroundImage.VerticalResolution));



                // gr.DrawImage(tempBG, dst_rect, src_rect, GraphicsUnit.Point)
                gr.DrawImage(ctrl.BackgroundImage, 0, 0, bm.Width, bm.Height);
                // bm.Save(GetCurrDirectory() & "\112.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

                ctrl.Panel1.BackgroundImage = bm;

                // bm.Dispose()
                // gr.Dispose()
                // tempBG.Dispose()
                // ctrl.Panel1.BackColor = Color.Transparent

                var allUC = from uc in ctrl.Panel1.Controls.OfType<UserControl>()
                            orderby uc.Tag
                            select uc;
                foreach (UserControl u in allUC)
                {
                    if (u.Name.ToLower().IndexOf("ucmenutxtsub") > -1) // And u.Visible = True Then
                    {
                    }
                }

                // Panel2
                // tempBG = New Bitmap(ctrl.Width, ctrl.Height)
                // tempBG = ctrl.BackgroundImage
                bm = new Bitmap(ctrl.Width - (ctrl.SplitterDistance + ctrl.SplitterWidth - ctrl.Left), ctrl.Height);
                gr = Graphics.FromImage(bm);
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage(ctrl.BackgroundImage, 0, 0, bm.Width, bm.Height);
                ctrl.Panel2.BackgroundImage = bm;
                bm = null;
                gr.Dispose();
                // gr = Nothing
                // tempBG = Nothing

                // ctrl.Panel2.BackColor = Color.Transparent

                var AllDGV = ctrl.Panel2.Controls.OfType<DataGridView>(); // Where ctrl.Name = "DataGridView1"
                foreach (DataGridView dgv in AllDGV)
                {
                    dgv.Width = 806;
                    dgv.Height = 534;
                    dgv.Left = 33;
                    dgv.Top = 133;
                    // .Anchor = AnchorStyles.Left + AnchorStyles.Right = AnchorStyles.Bottom + AnchorStyles.Top
                    dgv.Dock = DockStyle.Fill;
                    dgv.RowHeadersVisible = false;
                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    for (int i = 0, loopTo1 = dgv.ColumnCount - 1; i <= loopTo1; i++)
                    {
                        var col = new DataGridViewColumn();
                        col = dgv.Columns[i];
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }

                AllDGV = null;
                // ctrl.Visible = True
            }
        }

        public static void InitialFormDatabase(ref Form f, string pTitleName)
        {
            // f.BackgroundImageLayout = ImageLayout.Stretch
            // f.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\BG_SUB.png")
            // TitleName
            var allLabel = from lbl in f.Controls.OfType<Label>()
                           where lbl.Name == "lblTitleName"
                           select lbl;
            foreach (Label lbl in allLabel)
            {
                lbl.ForeColor = Color.WhiteSmoke;
                lbl.BackColor = Color.Transparent;

                // lbl.Text = GetCurrentMenu()
                // lbl.Left = f.Width - lbl.Width
                lbl.Width = (int)Math.Round(f.Width / 2d);
                lbl.Left = (int)Math.Round(f.Width / 2d);
                lbl.Top = (int)Math.Round(75 * f.Height / 1080d);
            }

            allLabel = null;
            var ucClosed_All = from ucClosed in f.Controls.OfType<UserControl>()
                               where ucClosed.Name == "UcClose1"
                               select ucClosed;
            foreach (UserControl ucClosed in ucClosed_All)
            {
                ucClosed.Left = f.Width - ucClosed.Width;
                ucClosed.Top = 0;
                ucClosed.Height = (int)Math.Round(65 * f.Height / 1080d);
                ucClosed.Width = (int)Math.Round(65 * f.Width / 1920d);
            }

            ucClosed_All = null;
            var UcMinimize_All = from UcMinimize in f.Controls.OfType<UserControl>()
                                 where UcMinimize.Name == "UcMinimize1"
                                 select UcMinimize;
            foreach (UserControl UcMinimize in UcMinimize_All)
            {
                UcMinimize.Left = f.Width - UcMinimize.Width * 2;
                UcMinimize.Top = 0;
                UcMinimize.Height = (int)Math.Round(65 * f.Height / 1080d);
                UcMinimize.Width = (int)Math.Round(65 * f.Width / 1920d);
            }

            UcMinimize_All = null;
            var ucStatus_All = from ucStatus in f.Controls.OfType<UserControl>()
                               where ucStatus.Name == "UcStatus1"
                               select ucStatus;
            foreach (UserControl ucStatus in ucStatus_All)
            {
                ucStatus.Height = 60;
                ucStatus.Dock = DockStyle.Bottom;
            }

            ucStatus_All = null;
            var Allctrl = from ctrl in f.Controls.OfType<DataGridView>()
                          where ctrl.Name == "DataGridView1"
                          select ctrl;
            foreach (DataGridView ctrl in Allctrl)
            {
                ctrl.Width = 806;
                ctrl.Height = 534;
                ctrl.Left = 33;
                ctrl.Top = 133;
                ctrl.Anchor = (AnchorStyles)Conversions.ToInteger((int)AnchorStyles.Left + (int)AnchorStyles.Right == (int)AnchorStyles.Bottom + (int)AnchorStyles.Top);
                ctrl.RowHeadersVisible = false;
                ctrl.CellBorderStyle = DataGridViewCellBorderStyle.None;
                for (int i = 0, loopTo = ctrl.ColumnCount - 1; i <= loopTo; i++)
                {
                    var col = new DataGridViewColumn();
                    col = ctrl.Columns[i];
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }

            Allctrl = null;

            // InitialSplitContainer(f)
            Graphics gr;
            Bitmap bm;
            var allSpli = f.Controls.OfType<SplitContainer>();
            foreach (SplitContainer ctrl in allSpli)
            {
                Rectangle src_rect;
                Rectangle dst_rect;
                // .Visible = False
                ctrl.SplitterDistance = 200;
                ctrl.SplitterWidth = 4;
                ctrl.Left = 0;
                ctrl.Top = 100;
                ctrl.Width = f.Width;
                // .Height = 600
                ctrl.Anchor = (AnchorStyles)((int)AnchorStyles.Bottom + (int)AnchorStyles.Left + (int)AnchorStyles.Right + (int)AnchorStyles.Top);
                ctrl.Panel2.Padding = new Padding(8);

                // tempBG.Save(GetCurrDirectory() & "\110.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

                bm = new Bitmap(ctrl.Width, ctrl.Height);
                gr = ctrl.CreateGraphics();
                gr = Graphics.FromImage(bm);
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                // src_rect = New Rectangle(ctrl.Left * 96 / 72, ctrl.Top * 96 / 72, ctrl.Width * 96 / 72, ctrl.Height * 96 / 72)
                // dst_rect = New Rectangle(0, 0, ctrl.Width * 96 / 72, ctrl.Height * 96 / 72)
                src_rect = new Rectangle(ConvertPixelToPoint(ctrl.Left, f.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Top, f.BackgroundImage.VerticalResolution), ConvertPixelToPoint(ctrl.Width, f.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Height, f.BackgroundImage.VerticalResolution));


                dst_rect = new Rectangle(0, 0, ConvertPixelToPoint(ctrl.Width, f.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Height, f.BackgroundImage.VerticalResolution));


                gr.DrawImage(f.BackgroundImage, dst_rect, src_rect, GraphicsUnit.Point);
                ctrl.BackgroundImage = bm;

                // bm.Save(GetCurrDirectory() & "\111.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
                // bm.Dispose()
                // gr.Dispose()
                // tempBG.Dispose()

                // Panel(1)
                bm = new Bitmap(ctrl.SplitterDistance, ctrl.Height);
                gr = Graphics.FromImage(bm);
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;

                // src_rect = New Rectangle(ctrl.Left, ctrl.Top, ctrl.SplitterDistance, ctrl.Height)
                // dst_rect = New Rectangle(0, 0, ctrl.SplitterDistance, ctrl.Height)
                src_rect = new Rectangle(ConvertPixelToPoint(ctrl.Left, ctrl.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Top, ctrl.BackgroundImage.VerticalResolution), ConvertPixelToPoint(ctrl.SplitterDistance, ctrl.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Height, ctrl.BackgroundImage.VerticalResolution));


                dst_rect = new Rectangle(0, 0, ConvertPixelToPoint(ctrl.SplitterDistance, ctrl.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Height, ctrl.BackgroundImage.VerticalResolution));



                // gr.DrawImage(tempBG, dst_rect, src_rect, GraphicsUnit.Point)
                gr.DrawImage(ctrl.BackgroundImage, 0, 0, bm.Width, bm.Height);
                // bm.Save(GetCurrDirectory() & "\112.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

                ctrl.Panel1.BackgroundImage = bm;

                // bm.Dispose()
                // gr.Dispose()
                // tempBG.Dispose()
                // ctrl.Panel1.BackColor = Color.Transparent

                var allUC = from uc in ctrl.Panel1.Controls.OfType<UserControl>()
                            orderby uc.Tag
                            select uc;
                foreach (UserControl u in allUC)
                {
                    if (u.Name.ToLower().IndexOf("ucmenutxtsub") > -1) // And u.Visible = True Then
                    {
                    }
                }

                // Panel2
                bm = new Bitmap(ctrl.Width - (ctrl.SplitterDistance + ctrl.SplitterWidth - ctrl.Left), ctrl.Height);
                gr = Graphics.FromImage(bm);
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage(ctrl.BackgroundImage, 0, 0, bm.Width, bm.Height);
                ctrl.Panel2.BackgroundImage = bm;
                bm = null;
                gr.Dispose();
                // ctrl.Panel2.BackColor = Color.Transparent

                var AllDGV = ctrl.Panel2.Controls.OfType<DataGridView>(); // Where ctrl.Name = "DataGridView1"
                foreach (DataGridView dgv in AllDGV)
                {
                    dgv.Width = 806;
                    dgv.Height = 534;
                    dgv.Left = 33;
                    dgv.Top = 133;
                    // .Anchor = AnchorStyles.Left + AnchorStyles.Right = AnchorStyles.Bottom + AnchorStyles.Top
                    dgv.Dock = DockStyle.Fill;
                    dgv.RowHeadersVisible = false;
                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    for (int i = 0, loopTo1 = dgv.ColumnCount - 1; i <= loopTo1; i++)
                    {
                        var col = new DataGridViewColumn();
                        col = dgv.Columns[i];
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }

                AllDGV = null;
                // ctrl.Visible = True
            }
        }

        public static void InitialFormUtility(ref Form f, string pTitleName)
        {
            // f.BackgroundImageLayout = ImageLayout.Stretch
            // f.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\BG_SUB.png")
            // TitleName
            var allLabel = from lbl in f.Controls.OfType<Label>()
                           where lbl.Name == "lblTitleName"
                           select lbl;
            foreach (Label lbl in allLabel)
            {
                lbl.ForeColor = Color.WhiteSmoke;
                lbl.BackColor = Color.Transparent;

                // lbl.Text = GetCurrentMenu()
                // lbl.Left = f.Width - lbl.Width
                lbl.Width = (int)Math.Round(f.Width / 2d);
                lbl.Left = (int)Math.Round(f.Width / 2d);
                lbl.Top = (int)Math.Round(75 * f.Height / 1080d);
            }

            allLabel = null;
            var ucClosed_All = from ucClosed in f.Controls.OfType<UserControl>()
                               where ucClosed.Name == "UcClose1"
                               select ucClosed;
            foreach (UserControl ucClosed in ucClosed_All)
            {
                ucClosed.Left = f.Width - ucClosed.Width;
                ucClosed.Top = 0;
                ucClosed.Height = (int)Math.Round(65 * f.Height / 1080d);
                ucClosed.Width = (int)Math.Round(65 * f.Width / 1920d);
            }

            ucClosed_All = null;
            var UcMinimize_All = from UcMinimize in f.Controls.OfType<UserControl>()
                                 where UcMinimize.Name == "UcMinimize1"
                                 select UcMinimize;
            foreach (UserControl UcMinimize in UcMinimize_All)
            {
                UcMinimize.Left = f.Width - UcMinimize.Width * 2;
                UcMinimize.Top = 0;
                UcMinimize.Height = (int)Math.Round(65 * f.Height / 1080d);
                UcMinimize.Width = (int)Math.Round(65 * f.Width / 1920d);
            }

            UcMinimize_All = null;
            var ucStatus_All = from ucStatus in f.Controls.OfType<UserControl>()
                               where ucStatus.Name == "UcStatus1"
                               select ucStatus;
            foreach (UserControl ucStatus in ucStatus_All)
            {
                ucStatus.Height = 60;
                ucStatus.Dock = DockStyle.Bottom;
            }

            ucStatus_All = null;
            var Allctrl = from ctrl in f.Controls.OfType<DataGridView>()
                          where ctrl.Name == "DataGridView1"
                          select ctrl;
            foreach (DataGridView ctrl in Allctrl)
            {
                ctrl.Width = 806;
                ctrl.Height = 534;
                ctrl.Left = 33;
                ctrl.Top = 133;
                ctrl.Anchor = (AnchorStyles)Conversions.ToInteger((int)AnchorStyles.Left + (int)AnchorStyles.Right == (int)AnchorStyles.Bottom + (int)AnchorStyles.Top);
                ctrl.RowHeadersVisible = false;
                ctrl.CellBorderStyle = DataGridViewCellBorderStyle.None;
                for (int i = 0, loopTo = ctrl.ColumnCount - 1; i <= loopTo; i++)
                {
                    var col = new DataGridViewColumn();
                    col = ctrl.Columns[i];
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }

            Allctrl = null;

            // InitialSplitContainer(f)
            Graphics gr;
            Bitmap bm;
            // Dim tempBG As Bitmap

            var allSpli = f.Controls.OfType<SplitContainer>();
            foreach (SplitContainer ctrl in allSpli)
            {
                Rectangle src_rect;
                Rectangle dst_rect;
                // .Visible = False
                ctrl.SplitterDistance = 220;
                ctrl.SplitterWidth = 4;
                ctrl.Left = 0;
                ctrl.Top = 100;
                ctrl.Width = f.Width;
                // .Height = 600
                ctrl.Anchor = (AnchorStyles)((int)AnchorStyles.Bottom + (int)AnchorStyles.Left + (int)AnchorStyles.Right + (int)AnchorStyles.Top);
                ctrl.Panel2.Padding = new Padding(8);
                // tempBG = New Bitmap(f.Width, f.Height)
                // tempBG = f.BackgroundImage

                // tempBG.Save(GetCurrDirectory() & "\110.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

                bm = new Bitmap(ctrl.Width, ctrl.Height);
                gr = ctrl.CreateGraphics();
                gr = Graphics.FromImage(bm);
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                // src_rect = New Rectangle(ctrl.Left * 96 / 72, ctrl.Top * 96 / 72, ctrl.Width * 96 / 72, ctrl.Height * 96 / 72)
                // dst_rect = New Rectangle(0, 0, ctrl.Width * 96 / 72, ctrl.Height * 96 / 72)
                src_rect = new Rectangle(ConvertPixelToPoint(ctrl.Left, f.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Top, f.BackgroundImage.VerticalResolution), ConvertPixelToPoint(ctrl.Width, f.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Height, f.BackgroundImage.VerticalResolution));


                dst_rect = new Rectangle(0, 0, ConvertPixelToPoint(ctrl.Width, f.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Height, f.BackgroundImage.VerticalResolution));


                gr.DrawImage(f.BackgroundImage, dst_rect, src_rect, GraphicsUnit.Point);
                ctrl.BackgroundImage = bm;

                // bm.Save(GetCurrDirectory() & "\111.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
                // bm.Dispose()
                // gr.Dispose()
                // tempBG.Dispose()

                // Panel(1)
                bm = new Bitmap(ctrl.SplitterDistance, ctrl.Height);
                gr = Graphics.FromImage(bm);
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;

                // src_rect = New Rectangle(ctrl.Left, ctrl.Top, ctrl.SplitterDistance, ctrl.Height)
                // dst_rect = New Rectangle(0, 0, ctrl.SplitterDistance, ctrl.Height)
                src_rect = new Rectangle(ConvertPixelToPoint(ctrl.Left, ctrl.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Top, ctrl.BackgroundImage.VerticalResolution), ConvertPixelToPoint(ctrl.SplitterDistance, ctrl.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Height, ctrl.BackgroundImage.VerticalResolution));


                dst_rect = new Rectangle(0, 0, ConvertPixelToPoint(ctrl.SplitterDistance, ctrl.BackgroundImage.HorizontalResolution), ConvertPixelToPoint(ctrl.Height, ctrl.BackgroundImage.VerticalResolution));



                // gr.DrawImage(tempBG, dst_rect, src_rect, GraphicsUnit.Point)
                gr.DrawImage(ctrl.BackgroundImage, 0, 0, bm.Width, bm.Height);
                // bm.Save(GetCurrDirectory() & "\112.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

                ctrl.Panel1.BackgroundImage = bm;

                // bm.Dispose()
                // gr.Dispose()
                // tempBG.Dispose()
                // ctrl.Panel1.BackColor = Color.Transparent

                var allUC = from uc in ctrl.Panel1.Controls.OfType<UserControl>()
                            orderby uc.Tag
                            select uc;
                foreach (UserControl u in allUC)
                {
                    if (u.Name.ToLower().IndexOf("ucmenutxtsub") > -1) // And u.Visible = True Then
                    {
                    }
                }

                // Panel2

                bm = new Bitmap(ctrl.Width - (ctrl.SplitterDistance + ctrl.SplitterWidth - ctrl.Left), ctrl.Height);
                gr = Graphics.FromImage(bm);
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage(ctrl.BackgroundImage, 0, 0, bm.Width, bm.Height);
                ctrl.Panel2.BackgroundImage = bm;
                bm = null;
                gr.Dispose();
                // ctrl.Panel2.BackColor = Color.Transparent

                var AllDGV = ctrl.Panel2.Controls.OfType<DataGridView>(); // Where ctrl.Name = "DataGridView1"
                foreach (DataGridView dgv in AllDGV)
                {
                    dgv.Width = 806;
                    dgv.Height = 534;
                    dgv.Left = 33;
                    dgv.Top = 133;
                    // .Anchor = AnchorStyles.Left + AnchorStyles.Right = AnchorStyles.Bottom + AnchorStyles.Top
                    dgv.Dock = DockStyle.Fill;
                    dgv.RowHeadersVisible = false;
                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    for (int i = 0, loopTo1 = dgv.ColumnCount - 1; i <= loopTo1; i++)
                    {
                        var col = new DataGridViewColumn();
                        col = dgv.Columns[i];
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }

                AllDGV = null;
                // ctrl.Visible = True
            }
        }

        public static void InitialFormType1(ref Form f, string pTitleName)
        {
            // f.BackgroundImageLayout = ImageLayout.Stretch
            // f.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\BG_SUB.png")
            // TitleName
            var allLabel = from lbl in f.Controls.OfType<Label>()
                           where lbl.Name == "lblTitleName"
                           select lbl;
            foreach (Label lbl in allLabel)
            {
                lbl.ForeColor = Color.WhiteSmoke;
                lbl.BackColor = Color.Transparent;

                // lbl.Text = GetCurrentMenu()
                // lbl.Left = f.Width - lbl.Width
                lbl.Width = (int)Math.Round(f.Width / 2d);
                lbl.Left = (int)Math.Round(f.Width / 2d);
                lbl.Top = (int)Math.Round(75 * f.Height / 1080d);
            }

            allLabel = null;
            var ucClosed_All = from ucClosed in f.Controls.OfType<UserControl>()
                               where ucClosed.Name == "UcClose1"
                               select ucClosed;
            foreach (UserControl ucClosed in ucClosed_All)
            {
                ucClosed.Left = f.Width - ucClosed.Width;
                ucClosed.Top = 0;
                ucClosed.Height = (int)Math.Round(65 * f.Height / 1080d);
                ucClosed.Width = (int)Math.Round(65 * f.Width / 1920d);
            }

            ucClosed_All = null;
            var UcMinimize_All = from UcMinimize in f.Controls.OfType<UserControl>()
                                 where UcMinimize.Name == "UcMinimize1"
                                 select UcMinimize;
            foreach (UserControl UcMinimize in UcMinimize_All)
            {
                UcMinimize.Left = f.Width - UcMinimize.Width * 2;
                UcMinimize.Top = 0;
                UcMinimize.Height = (int)Math.Round(65 * f.Height / 1080d);
                UcMinimize.Width = (int)Math.Round(65 * f.Width / 1920d);
            }

            UcMinimize_All = null;
            var ucStatus_All = from ucStatus in f.Controls.OfType<UserControl>()
                               where ucStatus.Name == "UcStatus1"
                               select ucStatus;
            foreach (UserControl ucStatus in ucStatus_All)
            {
                ucStatus.Height = 60;
                ucStatus.Dock = DockStyle.Bottom;
            }

            ucStatus_All = null;
            var Allctrl = f.Controls.OfType<DataGridView>(); // Where ctrl.Name = "DataGridView1"
            foreach (DataGridView ctrl in Allctrl)
            {
                ctrl.Width = 806;
                ctrl.Height = 534;
                ctrl.Left = 33;
                ctrl.Top = 133;
                ctrl.Anchor = (AnchorStyles)Conversions.ToInteger((int)AnchorStyles.Left + (int)AnchorStyles.Right == (int)AnchorStyles.Bottom + (int)AnchorStyles.Top);
                ctrl.RowHeadersVisible = false;
                ctrl.CellBorderStyle = DataGridViewCellBorderStyle.None;
                for (int i = 0, loopTo = ctrl.ColumnCount - 1; i <= loopTo; i++)
                {
                    var col = new DataGridViewColumn();
                    col = ctrl.Columns[i];
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }

            Allctrl = null;
            UserControl[] objUC;
            int vIndex = 0;
            var AllUC = from uc in f.Controls.OfType<UserControl>()
                        where uc.Name == "UcReflesh1" | uc.Name == "UcInsert1" | uc.Name == "UcDelete1" | uc.Name == "UcSearch1" | uc.Name == "UcEdit1"
                        select uc;
            objUC = new UserControl[(AllUC.Count())];
            foreach (UserControl uc in AllUC)
            {
                objUC[vIndex] = uc;
                objUC[vIndex].Width = 91;
                objUC[vIndex].Height = 99;
                objUC[vIndex].Anchor = (AnchorStyles)((int)AnchorStyles.Left + (int)AnchorStyles.Top);
                vIndex += 1;
            }

            vIndex = 0;
            objUC = null;

            // InitialSplitContainer(f)
        }

        public static void InitialFormType2(ref Form f, string pTitleName)
        {
            // f.BackgroundImageLayout = ImageLayout.Stretch
            // f.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\BG_SUB.png")
            // TitleName
            InitialTitleName(ref f, pTitleName);
            f.Text = GINNTAS.My.MyProject.Application.Info.ProductName;
            // InitialSplitContainer(f)
            InitialUcMnu(ref f);
            f.UseWaitCursor = false;
        }

        private static void InitialSplitContainer(ref Form f)
        {
            Graphics gr;
            Bitmap bm;
            Bitmap tempBG;
            var allSpli = f.Controls.OfType<SplitContainer>();
            foreach (SplitContainer ctrl in allSpli)
            {
                Rectangle src_rect;
                Rectangle dst_rect;
                // .Visible = False
                ctrl.SplitterDistance = 244;
                ctrl.SplitterWidth = 4;
                ctrl.Left = 0;
                ctrl.Top = 100;
                ctrl.Width = f.Width;
                ctrl.Height = 600;
                ctrl.Anchor = (AnchorStyles)((int)AnchorStyles.Bottom + (int)AnchorStyles.Left + (int)AnchorStyles.Right + (int)AnchorStyles.Top);
                ctrl.Panel2.Padding = new Padding(8);
                tempBG = new Bitmap(f.Width, f.Height);
                tempBG = (Bitmap)f.BackgroundImage;

                // tempBG.Save(GetCurrDirectory() & "\110.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

                bm = new Bitmap(ctrl.Width, ctrl.Height);
                gr = ctrl.CreateGraphics();
                gr = Graphics.FromImage(bm);
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                // src_rect = New Rectangle(ctrl.Left * 96 / 72, ctrl.Top * 96 / 72, ctrl.Width * 96 / 72, ctrl.Height * 96 / 72)
                // dst_rect = New Rectangle(0, 0, ctrl.Width * 96 / 72, ctrl.Height * 96 / 72)
                src_rect = new Rectangle(ConvertPixelToPoint(ctrl.Left, tempBG.HorizontalResolution), ConvertPixelToPoint(ctrl.Top, tempBG.VerticalResolution), ConvertPixelToPoint(ctrl.Width, tempBG.HorizontalResolution), ConvertPixelToPoint(ctrl.Height, tempBG.VerticalResolution));


                dst_rect = new Rectangle(0, 0, ConvertPixelToPoint(ctrl.Width, tempBG.HorizontalResolution), ConvertPixelToPoint(ctrl.Height, tempBG.VerticalResolution));


                gr.DrawImage(tempBG, dst_rect, src_rect, GraphicsUnit.Point);
                ctrl.BackgroundImage = bm;

                // bm.Save(GetCurrDirectory() & "\111.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
                // bm.Dispose()
                // gr.Dispose()
                // tempBG.Dispose()

                // Panel(1)
                tempBG = new Bitmap(ctrl.Width, ctrl.Height);
                tempBG = (Bitmap)ctrl.BackgroundImage;
                bm = new Bitmap(ctrl.SplitterDistance, ctrl.Height);
                gr = Graphics.FromImage(bm);
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;

                // src_rect = New Rectangle(ctrl.Left, ctrl.Top, ctrl.SplitterDistance, ctrl.Height)
                // dst_rect = New Rectangle(0, 0, ctrl.SplitterDistance, ctrl.Height)
                src_rect = new Rectangle(ConvertPixelToPoint(ctrl.Left, bm.HorizontalResolution), ConvertPixelToPoint(ctrl.Top, bm.VerticalResolution), ConvertPixelToPoint(ctrl.SplitterDistance, bm.HorizontalResolution), ConvertPixelToPoint(ctrl.Height, bm.VerticalResolution));


                dst_rect = new Rectangle(0, 0, ConvertPixelToPoint(ctrl.SplitterDistance, bm.HorizontalResolution), ConvertPixelToPoint(ctrl.Height, bm.VerticalResolution));



                // gr.DrawImage(tempBG, dst_rect, src_rect, GraphicsUnit.Point)
                gr.DrawImage(tempBG, 0, 0, bm.Width, bm.Height);
                // bm.Save(GetCurrDirectory() & "\112.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

                ctrl.Panel1.BackgroundImage = bm;

                // bm.Dispose()
                // gr.Dispose()
                // tempBG.Dispose()
                // ctrl.Panel1.BackColor = Color.Transparent

                var allUC = ctrl.Panel1.Controls.OfType<UserControl>();
                foreach (UserControl u in allUC)
                {
                    if (u.Name.IndexOf("UcMnu") > -1) // And u.Visible = True Then
                    {
                        bm = new Bitmap(u.Width, u.Height);

                        // Associate a Graphics object with the Bitmap
                        gr = Graphics.FromImage(bm);
                        // Define source and destination rectangles.
                        src_rect = new Rectangle(u.Left, u.Top, u.Width, u.Height);
                        dst_rect = new Rectangle(0, 0, u.Width, u.Height);

                        // Copy that part of the image.
                        gr.DrawImage(ctrl.Panel1.BackgroundImage, dst_rect, src_rect, GraphicsUnit.Pixel);
                        // Display the result.
                        u.BackgroundImage = bm;
                        bm.Dispose();
                        gr.Dispose();
                    }
                }

                // Panel2
                tempBG = new Bitmap(ctrl.Width, ctrl.Height);
                tempBG = (Bitmap)ctrl.BackgroundImage;
                bm = new Bitmap(ctrl.Width - (ctrl.SplitterDistance + ctrl.SplitterWidth - ctrl.Left), ctrl.Height);
                gr = Graphics.FromImage(bm);
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage(tempBG, 0, 0, bm.Width, bm.Height);
                ctrl.Panel2.BackgroundImage = bm;
                bm = null;
                gr = null;
                tempBG = null;
                // ctrl.Panel2.BackColor = Color.Transparent

                var AllDGV = ctrl.Panel2.Controls.OfType<DataGridView>(); // Where ctrl.Name = "DataGridView1"
                foreach (DataGridView dgv in AllDGV)
                {
                    dgv.Width = 806;
                    dgv.Height = 534;
                    dgv.Left = 33;
                    dgv.Top = 133;
                    // .Anchor = AnchorStyles.Left + AnchorStyles.Right = AnchorStyles.Bottom + AnchorStyles.Top
                    dgv.Dock = DockStyle.Fill;
                    dgv.RowHeadersVisible = false;
                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    for (int i = 0, loopTo = dgv.ColumnCount - 1; i <= loopTo; i++)
                    {
                        var col = new DataGridViewColumn();
                        col = dgv.Columns[i];
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }

                AllDGV = null;
                // ctrl.Visible = True
            }
        }

        private static void InitialTitleName(ref Form f, string pTitleName)
        {
            // TitleName
            var allLabel = from lbl in f.Controls.OfType<Label>()
                           where lbl.Name == "lblTitleName"
                           select lbl;
            foreach (Label lbl in allLabel)
            {
                lbl.ForeColor = Color.WhiteSmoke;
                lbl.BackColor = Color.Transparent;

                // lbl.Text = GetCurrentMenu()
                // lbl.Left = 67
                // lbl.Top = 80
            }
        }

        public static void InitialFormMain(ref Form f, string pTitleName)
        {

            // f.BackgroundImageLayout = ImageLayout.Stretch
            // f.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\BG_MAIN.png")

            // TitleName
            var allLabel = from lbl in f.Controls.OfType<Label>()
                           where lbl.Name == "lblTitleName"
                           select lbl;
            foreach (Label lbl in allLabel)
            {
                lbl.ForeColor = Color.WhiteSmoke;
                lbl.BackColor = Color.Transparent;
                lbl.TextAlign = ContentAlignment.MiddleRight;
                lbl.AutoSize = true;
                lbl.Anchor = (AnchorStyles)((int)AnchorStyles.Right + (int)AnchorStyles.Top);

                // lbl.Text = GetCurrentMenu()
                // lbl.Left = f.Width - lbl.Width
                // lbl.Width = f.Width / 2
                lbl.Left = (int)Math.Round(f.Width / 2d);
                lbl.Top = (int)Math.Round(75 * f.Height / 1080d);
            }

            f.Text = GINNTAS.My.MyProject.Application.Info.ProductName;
            var ucStatus_All = from ucStatus in f.Controls.OfType<UserControl>()
                               where ucStatus.Name == "UcStatus1"
                               select ucStatus;
            foreach (UserControl ucStatus in ucStatus_All)
            {
                ucStatus.Height = 60;
                ucStatus.Dock = DockStyle.Bottom;
                // ucStatus.Left = 0
                // ucStatus.Width = f.Width
                // ucStatus.Height = (70 * f.Height) / 1080
                // ucStatus.Top = f.Height - ucStatus.Height
            }

            var ucClosed_All = from ucClosed in f.Controls.OfType<UserControl>()
                               where ucClosed.Name == "UcClose1"
                               select ucClosed;
            foreach (UserControl ucClosed in ucClosed_All)
            {
                ucClosed.Left = f.Width - ucClosed.Width;
                ucClosed.Top = 0;
                ucClosed.Height = (int)Math.Round(65 * f.Height / 1080d);
                ucClosed.Width = (int)Math.Round(65 * f.Width / 1920d);
            }

            var UcMinimize_All = from UcMinimize in f.Controls.OfType<UserControl>()
                                 where UcMinimize.Name == "UcMinimize1"
                                 select UcMinimize;
            foreach (UserControl UcMinimize in UcMinimize_All)
            {
                UcMinimize.Left = f.Width - UcMinimize.Width * 2;
                UcMinimize.Top = 0;
                UcMinimize.Height = (int)Math.Round(65 * f.Height / 1080d);
                UcMinimize.Width = (int)Math.Round(65 * f.Width / 1920d);
            }

            InitialUcMnu(ref f);
            // InitialSplitContainer(f)
        }

        public static void InitialForm(ref Form f, string pTitleName)
        {
            // f.BackgroundImageLayout = ImageLayout.Stretch
            // f.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\BG_SUB.png")

            // TitleName
            var allLabel = from lbl in f.Controls.OfType<Label>()
                           where lbl.Name == "lblTitleName"
                           select lbl;
            foreach (Label lbl in allLabel)
            {
                lbl.ForeColor = Color.WhiteSmoke;
                lbl.BackColor = Color.Transparent;
                lbl.TextAlign = ContentAlignment.MiddleRight;
                lbl.AutoSize = false;
                lbl.Width = (int)Math.Round(f.Width / 2d);
                lbl.Left = f.Width - lbl.Width - 14;
                lbl.Top = (int)Math.Round(75 * f.Height / 1080d);
            }

            allLabel = null;
            f.Text = GINNTAS.My.MyProject.Application.Info.ProductName;
            var ucStatus_All = from ucStatus in f.Controls.OfType<UserControl>()
                               where ucStatus.Name == "UcStatus1"
                               select ucStatus;
            foreach (UserControl ucStatus in ucStatus_All)
            {
                ucStatus.Height = 60;
                ucStatus.Dock = DockStyle.Bottom;
            }

            ucStatus_All = null;
            var ucClosed_All = from ucClosed in f.Controls.OfType<UserControl>()
                               where ucClosed.Name == "UcClose1"
                               select ucClosed;
            foreach (UserControl ucClosed in ucClosed_All)
            {
                ucClosed.Left = f.Width - ucClosed.Width;
                ucClosed.Top = 0;
                ucClosed.Height = (int)Math.Round(65 * f.Height / 1080d);
                ucClosed.Width = (int)Math.Round(65 * f.Width / 1920d);
            }

            ucClosed_All = null;
            var UcMinimize_All = from UcMinimize in f.Controls.OfType<UserControl>()
                                 where UcMinimize.Name == "UcMinimize1"
                                 select UcMinimize;
            foreach (UserControl UcMinimize in UcMinimize_All)
            {
                UcMinimize.Left = f.Width - UcMinimize.Width * 2;
                UcMinimize.Top = 0;
                UcMinimize.Height = (int)Math.Round(65 * f.Height / 1080d);
                UcMinimize.Width = (int)Math.Round(65 * f.Width / 1920d);
            }

            UcMinimize_All = null;
            var ctrlDGV = f.Controls.OfType<DataGridView>(); // Where ctrl.Name = "DataGridView1"
            foreach (DataGridView ctrl in ctrlDGV)
            {
                // .Width = 806
                // .Height = 534
                // .Left = 33
                // .Top = 133
                ctrl.Anchor = (AnchorStyles)Conversions.ToInteger((int)AnchorStyles.Left + (int)AnchorStyles.Right == (int)AnchorStyles.Bottom + (int)AnchorStyles.Top);
                ctrl.RowHeadersVisible = true;
                ctrl.CellBorderStyle = DataGridViewCellBorderStyle.None;
                ctrl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ctrl.DefaultCellStyle.ForeColor = Color.Black;
                for (int i = 0, loopTo = ctrl.ColumnCount - 1; i <= loopTo; i++)
                {
                    var col = new DataGridViewColumn();
                    col = ctrl.Columns[i];
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }

            ctrlDGV = null;
            object allCtrl;
            allCtrl = f.Controls.OfType<DataGridView>();
            allCtrl = null;

            // Initial ucMnu
            allCtrl = null;
            InitialUcMnu(ref f);
            // InitialSplitContainer(f)
        }

        private static void InitialUcMnu(ref Form f)
        {
            var allUc = f.Controls.OfType<UserControl>();

            // Draw Image background
            foreach (UserControl u in allUc)
            {
                if (u.Name.IndexOf("UcMnu") > -1 | u.Name.IndexOf("ucMenutxt") > -1)
                {
                    var bm = new Bitmap(u.Width, u.Height);

                    // Associate a Graphics object with the Bitmap
                    using (var gr = Graphics.FromImage(bm))
                    {
                        // Define source and destination rectangles.
                        var src_rect = new Rectangle(u.Left, u.Top, u.Width, u.Height);
                        var dst_rect = new Rectangle(0, 0, u.Width, u.Height);

                        // Copy that part of the image.
                        gr.DrawImage(f.BackgroundImage, dst_rect, src_rect, GraphicsUnit.Pixel);
                    }

                    // Display the result.
                    u.BackgroundImage = bm;
                    bm = null;
                    bm.Dispose();
                }
            }
        }

        private static void DrawString(ref Form f)
        {
            var formGraphics = f.CreateGraphics();
            string drawString = "Sample Text";
            var drawFont = new Font("Arial", 16f);
            // Dim drawFont As New System.Drawing.Font
            var drawBrush = new SolidBrush(Color.WhiteSmoke);
            float x = 360.0f;
            float y = 80.0f;
            var drawFormat = new StringFormat();
            formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();
        }

        private static Bitmap ResizeBitmap(ref Bitmap pBitmap, int pWidth, string pHeight)
        {
            // make a blank bitmap the correct size  
            int vWidth, vHeight;
            vWidth = pWidth;
            vHeight = Conversions.ToInteger(pHeight);
            var NewBitmap = new Bitmap(vWidth, vHeight);

            // make an instance of graphics that will draw on "NewBitmap"  

            var BitmpGraphics = Graphics.FromImage(NewBitmap);

            // work out the scale factor  

            int scaleFactorX = (int)Math.Round(pBitmap.Width / (double)pWidth);
            int scaleFactorY = (int)Math.Round(pBitmap.Height / Conversions.ToDouble(pHeight));

            // resize the graphics  

            BitmpGraphics.ScaleTransform(scaleFactorX, scaleFactorY);

            // draw the bitmap to NewBitmap  
            BitmpGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            BitmpGraphics.DrawImage(pBitmap, 0, 0);
            return NewBitmap;
        }

        public static int ConvertPixelToPoint(float pPixel, float pDPI)
        {
            // •There are 72 points in an inch (that is what a point is, 1/72 of an inch)
            // •on a system set for 150dpi, there are 150 pixels per inch.
            // •1 in = 72pt = 150px (for 150dpi setting)

            // points = (pixels / 96) * 72 on a standard XP/Vista/7 machine (factory defaults)
            // points = (pixels / 72) * 72 on a standard Mac running OSX (Factory defaults)
            // Windows runs as default at 96dpi (display) Macs run as default at 72 dpi (display)
            // Ex: 14 horizontal points = (14 * DpiX) / 72 pixels
            return (int)Math.Round(pPixel * pDPI / 72f);
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        // Public Sub ExitProgram()
        // 'UcStatus1.StopThread()
        // Oradb.Dispose()

        // mMenuStack.Clear()
        // mForm.Clear()
        // 'Me.Close()
        // mLog = Nothing
        // End
        // End Sub

        public static void OpenPictureDriver(ref string pSource)
        {
            var openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pSource = openFileDialog1.FileName.ToString();
            }
        }

        public static bool CopyPictureDriver(string pSorce, string pNewFileName)
        {
            try
            {
                string vDest = GINNTAS.mDatabase.GetPathPictureDriver();
                string vFileExtention = Path.GetExtension(pSorce);
                string vFileName = Path.GetFileName(pSorce);
                if (!Directory.Exists(vDest))
                {
                    Directory.CreateDirectory(vDest);
                }

                File.Copy(pSorce, vDest + pNewFileName + vFileExtention, true);
                DeletePictureDriver(vDest + pNewFileName + vFileExtention);
                return true;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
                GINNTAS.mVariable.mLog.WriteErrMessage(ex.Message);
                return false;
            }
        }

        public static object DeletePictureDriver(string pSorce)
        {
            try
            {
                GINNTAS.My.MyProject.Computer.FileSystem.DeleteFile(pSorce, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                return true;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
                GINNTAS.mVariable.mLog.WriteErrMessage(ex.Message);
                return false;
            }
        }

        public static string chk_null_txt(object db)
        {
            if (Information.IsDBNull(db))
            {
                return "";
            }
            else
            {
                return Conversions.ToString(db);
            }
        }

        public static string txt_num(string str) // text box number only
        {
            if (!string.IsNullOrEmpty(Strings.Trim(str)))
            {
                try
                {
                    long tmp = Conversions.ToLong(Strings.Trim(str));
                    return Strings.Trim(str);
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("สามารถใส่ได้เฉพาะตัวเลขเท่านั้น");
                    return "";
                }
            }

            return Strings.Trim(str);
        }

        public static object FDateTime(object vDate)
        {
            object FDateTimeRet = default;
            if (Information.IsDBNull(vDate))
            {
                FDateTimeRet = "";
            }
            else
            {
                FDateTimeRet = Strings.Format(vDate, "dd/MM/yyyy HH:mm:ss");
            }

            return FDateTimeRet;
        }

        public static object FDate(object vDate)
        {
            object FDateRet = default;
            if (Information.IsDBNull(vDate))
            {
                FDateRet = "";
            }
            else
            {
                FDateRet = Strings.Format(vDate, "dd/MM/yyyy");
            }

            return FDateRet;
        }

        public static object Datenn(object Datein)
        {
            object DatennRet = default;
            if (Information.IsDBNull(Datein))
            {
                DatennRet = "Null";
            }
            else
            {
                DatennRet = Operators.ConcatenateObject(Operators.ConcatenateObject("to_date('", Datein), "','dd/mm/yyyy')");
            }

            return DatennRet;
        }

        public static bool CurrencyOnly(TextBox TargetTextBox, char CurrentChar)
        {
            if (Information.IsNumeric(CurrentChar) == true)
            {
                return false;
            }

            if (Convert.ToString(CurrentChar) == "." && Conversions.ToBoolean(Strings.InStr(TargetTextBox.Text, ".")))
            {
                return true;
            }

            if (Convert.ToString(CurrentChar) == "." || Conversions.ToString(CurrentChar) == Constants.vbBack)
            {
                return false;
            }

            return true;
        }

        public static void resolution(ref Form f, ref double zoom)
        {
            return;
            var listLable = new Collection();
            var listObj = new Collection();
            // ------ Match Label and obj ---------------
            object lbl;
            object betweenX;
            object betweenY;
            // For Each box In f.Controls.OfType(Of GroupBox)()
            foreach (var currentLbl in f.Controls.OfType<Label>())
            {
                lbl = currentLbl;
                foreach (var obj in f.Controls)
                {
                    betweenX = Operators.SubtractObject(obj.location.x, Operators.AddObject(lbl.location.x, lbl.Size.Width));
                    betweenY = Operators.SubtractObject(lbl.location.y, obj.location.y);
                    if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.ConditionalCompareObjectLess(betweenX, 17, false), Operators.ConditionalCompareObjectGreater(betweenX, 0, false)), Operators.AndObject(Operators.ConditionalCompareObjectLess(betweenY, 5, false), Operators.ConditionalCompareObjectGreater(betweenY, -5, false)))))
                    {
                        listLable.Add(lbl);
                        listObj.Add(obj);
                    }
                }
            }
            // Next

            foreach (var box in f.Controls.OfType<GroupBox>())
            {
                foreach (var currentLbl1 in box.Controls.OfType<Label>())
                {
                    lbl = currentLbl1;
                    foreach (var obj in box.Controls)
                    {
                        betweenX = Operators.SubtractObject(obj.location.x, Operators.AddObject(lbl.location.x, lbl.Size.Width));
                        betweenY = Operators.SubtractObject(lbl.location.y, obj.location.y);
                        if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.ConditionalCompareObjectLess(betweenX, 17, false), Operators.ConditionalCompareObjectGreater(betweenX, 0, false)), Operators.AndObject(Operators.ConditionalCompareObjectLess(betweenY, 5, false), Operators.ConditionalCompareObjectGreater(betweenY, -5, false)))))
                        {
                            listLable.Add(lbl);
                            listObj.Add(obj);
                        }
                    }
                }
            }
            // -------- end Match Label and obj --------

            int defaultWidhtScreen = 1024;
            int defaultHeightScreen = 768;
            double percentW = 0d;
            double percentH = 0d;
            percentW = f.Size.Width / (double)defaultWidhtScreen * zoom;
            percentH = f.Size.Height / (double)defaultHeightScreen * zoom;
            foreach (var ctrl in f.Controls.OfType<GroupBox>())
            {
                ctrl.Size = new Size((int)Math.Round(ctrl.Size.Width * percentW), (int)Math.Round(ctrl.Size.Height * percentH));
                ctrl.Location = new Point((int)Math.Round(ctrl.Location.X * percentW), (int)Math.Round(ctrl.Location.Y * percentH));
                foreach (object xObject in ctrl.Controls)
                {
                    xObject.Size = new Size(Conversions.ToInteger(Operators.MultiplyObject(xObject.Size.Width, percentW)), Conversions.ToInteger(Operators.MultiplyObject(xObject.Size.Height, percentH)));
                    xObject.Location = new Point(Conversions.ToInteger(Operators.MultiplyObject(xObject.Location.X, percentW)), Conversions.ToInteger(Operators.MultiplyObject(xObject.Location.Y, percentH)));
                }
            }

            bool b;
            foreach (var ctrl1 in f.Controls)
            {
                b = true;
                foreach (var ctrl2 in f.Controls.OfType<GroupBox>())
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ctrl1.name, ctrl2.Name, false)))
                    {
                        b = false;
                    }

                    foreach (object xObject in ctrl2.Controls)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ctrl1.name, ctrl2.Name, false)))
                        {
                            b = false;
                        }
                    }
                }

                if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.ConditionalCompareObjectEqual(ctrl1.name, "UcClose1", false), Operators.ConditionalCompareObjectEqual(ctrl1.name, "UcMinimize1", false)), Operators.ConditionalCompareObjectEqual(ctrl1.name, "UcStatus1", false)), Operators.ConditionalCompareObjectEqual(ctrl1.name, "lblTitleName", false))))
                {
                    b = false;
                }

                if (b)
                {
                    ctrl1.Size = new Size(Conversions.ToInteger(Operators.MultiplyObject(ctrl1.Size.Width, percentW)), Conversions.ToInteger(Operators.MultiplyObject(ctrl1.Size.Height, percentH)));
                    ctrl1.Location = new Point(Conversions.ToInteger(Operators.MultiplyObject(ctrl1.Location.X, percentW)), Conversions.ToInteger(Operators.MultiplyObject(ctrl1.Location.Y, percentH)));
                }
            }


            // -----------  cal position label and obj --------------
            int n = 1;
            foreach (var lable in listLable)
            {
                lable.Location = new Point(Conversions.ToInteger(Operators.SubtractObject(listObj[n].Location.X, lable.size.Width)), Conversions.ToInteger(lable.Location.Y));
                n += 1;
            }
            // ----------- End cal position Label and obj ------------ 

            foreach (var ctrl in f.Controls.OfType<ucProgressOverView>())
            {
                // ctrl.updateProgress()
            }
        }

        private static void CHECK_AUTHORIZE_SCREEN(string mUserName, long mScreenID, int p3)
        {
            throw new NotImplementedException();
        }

        public static string GetVersion()
        {
            return "Version " + GINNTAS.My.MyProject.Application.Info.Version.ToString();
        }

        public static string GetAppPath()
        {
            return new FileInfo(Application.ExecutablePath).DirectoryName;
        }

        public static string GetPrinterName(string Report_ID)
        {
            string GetPrinterNameRet = default;
            string sql_str;
            var mDataSet = new DataSet();
            DataTable dt;
            GetPrinterNameRet = "";
            sql_str = @" SELECT T.PRINTER_NAME FROM  TAS.PRINTER_TAS T
                    INNER JOIN TAS.REPORT_SETTING R
                    ON R.PRINTER_ID = T.PRINTER_ID 
                    AND R.REPORT_ID= " + Report_ID;
            string argSQL_Execution_Error = "";
            if (GINNTAS.mVariable.Oradb.OpenDys(sql_str, "tbName", ref mDataSet, SQL_Execution_Error: ref argSQL_Execution_Error))
            {
                dt = mDataSet.Tables["tbName"];
                if (dt.Rows.Count > 0)
                {
                    GetPrinterNameRet = dt.Rows[0]["PRINTER_NAME"].ToString();
                }
            }

            return GetPrinterNameRet;
        }

        public static bool DirectPrinter(string iReport_ID, string iSQL = "", string iParam1 = "", string iParam2 = "", string iParam3 = "")
        {
            string path = GetAppPath();
            string PrinterName;
            string rptFileName;
            DataTable dt;
            try
            {
                PrinterName = GetPrinterName(iReport_ID);
                rptFileName = path + @"\Report Files\" + GetReportFileName(Conversions.ToDouble(iReport_ID));
                switch (iReport_ID ?? "")
                {
                    // การจ่ายกับกรมทางหลวงเรียงตามบริษัทประจำวัน
                    case var @case when @case == "52010049":
                        {
                            using (var rpt = new ReportDocument())
                            {
                                var printerSettings = new PrinterSettings();
                                printerSettings.PrinterName = PrinterName;
                                dt = GINNTAS.mVariable.CRService.Query_TBL(iSQL);
                                rpt.Load(rptFileName);
                                rpt.SetDataSource(dt);
                                rpt.SetParameterValue(0, iParam1);
                                if (printerSettings.IsValid)
                                {
                                    rpt.PrintOptions.PrinterName = PrinterName;
                                    rpt.PrintToPrinter(1, false, 0, 0);
                                }
                            }

                            break;
                        }
                    // การจ่ายกับกรมทางหลวงทั้งหมดประจำวัน
                    case var case1 when case1 == "52010059":
                        {
                            using (var rpt = new ReportDocument())
                            {
                                var printerSettings = new PrinterSettings();
                                printerSettings.PrinterName = PrinterName;
                                dt = GINNTAS.mVariable.CRService.Query_TBL(iSQL);
                                rpt.Load(rptFileName);
                                rpt.SetDataSource(dt);
                                rpt.SetParameterValue(0, iParam1);
                                if (printerSettings.IsValid)
                                {
                                    rpt.PrintOptions.PrinterName = PrinterName;
                                    rpt.PrintToPrinter(1, false, 0, 0);
                                }
                            }

                            break;
                        }

                    // รายงานการจ่ายทางรถบรรทุก
                    case var case2 when case2 == "52010007":
                        {
                            using (var rpt = new ReportDocument())
                            {
                                var printerSettings = new PrinterSettings();
                                printerSettings.PrinterName = PrinterName;
                                dt = GINNTAS.mVariable.CRService.DAILY_LOADING_DETAIL(iParam1);
                                rpt.Load(rptFileName);
                                rpt.SetDataSource(dt);
                                rpt.SetParameterValue(0, Conversions.ToInteger(iParam1));
                                if (printerSettings.IsValid)
                                {
                                    rpt.PrintOptions.PrinterName = PrinterName;
                                    rpt.PrintToPrinter(1, false, 0, 0);
                                }
                            }

                            break;
                        }

                    // รายงานใบกำกับสินค้า-Delivery Receive(Manual)
                    case var case3 when case3 == "52010040":
                        {
                            using (var rpt = new ReportDocument())
                            {
                                var printerSettings = new PrinterSettings();
                                printerSettings.PrinterName = PrinterName;
                                dt = GINNTAS.mVariable.CRService.VIEW_DELIV_HEADER(iParam1);
                                var dtLine = GINNTAS.mVariable.CRService.VIEW_DELIV_LINE(iParam1);
                                var dtSumLine = GINNTAS.mVariable.CRService.VIEW_DELIV_SUM_LINE(iParam1);
                                rpt.Load(rptFileName);
                                rpt.SetDataSource(dt);
                                rpt.Subreports[0].SetDataSource(dtLine);
                                rpt.Subreports[1].SetDataSource(dtSumLine);
                                rpt.SetParameterValue(0, Conversions.ToInteger(iParam1));
                                if (printerSettings.IsValid)
                                {
                                    rpt.PrintOptions.PrinterName = PrinterName;
                                    rpt.PrintToPrinter(1, false, 0, 0);
                                }

                                dtLine = null;
                                dtSumLine = null;
                            }

                            break;
                        }

                    // รายงานแนบกรมทางหลวง
                    case var case4 when case4 == "52010057":
                        {
                            using (var rpt = new ReportDocument())
                            {
                                var printerSettings = new PrinterSettings();
                                printerSettings.PrinterName = PrinterName;
                                dt = GINNTAS.mVariable.CRService.VIEW_GOV_PROJECT_ATTACHAS(iParam1);
                                rpt.Load(rptFileName);
                                rpt.SetDataSource(dt);
                                rpt.SetParameterValue(0, Conversions.ToInteger(iParam1));
                                if (printerSettings.IsValid)
                                {
                                    rpt.PrintOptions.PrinterName = PrinterName;
                                    rpt.PrintToPrinter(1, false, 0, 0);
                                }
                            }

                            break;
                        }

                    // รายงาน ใบชั่งน้ำหนัก
                    case var case5 when case5 == "52010031":
                        {
                            using (var rpt = new ReportDocument())
                            {
                                var printerSettings = new PrinterSettings();
                                printerSettings.PrinterName = PrinterName;
                                dt = GINNTAS.mVariable.CRService.VIEW_DATA_WEIGHT(iParam1);
                                rpt.Load(rptFileName);
                                rpt.SetDataSource(dt);
                                rpt.SetParameterValue(0, Conversions.ToInteger(iParam1));
                                if (printerSettings.IsValid)
                                {
                                    rpt.PrintOptions.PrinterName = PrinterName;
                                    rpt.PrintToPrinter(1, false, 0, 0);
                                }
                            }

                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด " + ex.Message);
                return false;
            }
            finally
            {
                dt = null;
            }

            return true;
        }
    }
}