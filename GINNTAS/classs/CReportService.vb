Public Class CReportService
    Public Function VIEW_LOADING_INTRODUCTION_TM(LOAD_HEADER_NO As String) As DataTable
        Dim Sql As String = "SELECT LOAD_HEADER_NO, SHIPMENT_NO, CARRIER_ID, CARRIER_NAME, DRIVER_NAME, TU_ID, TU_ID1, CANCEL_STATUS, LOAD_STATUS, CREATION_DATE, UPDATE_DATE, SEAL_NUMBER, SEAL_USE, DO_NO, COMPARTMENT_NO, ISLAND_NO, ISLAND_NAME, SALE_PRODUCT_ID, SALE_PRODUCT_NAME, SALE_PRODUCT_CODE, PRODUCT, IS_WEIGHT_PROCESS, STATUS_WEIGHT, IS_WEIGHT, NO_WEIGHT, PRESET, ADVICE, UNIT, PRODUCT_UNIT, CUSTOMER_CODE, CUSTOMER_NAME, SHIP_TO_CODE, SHIPTO, SHIPTO_ADDRESS, PLAN_DATE, SPECIAL_TEXT1, SPECIAL_TEXT2, SPECIAL_TEXT3, SPECIAL_TEXT4 FROM RPT.VIEW_LOADING_INTRODUCTION_TM WHERE LOAD_HEADER_NO=" & LOAD_HEADER_NO
        Dim dt As DataTable = Oradb.Query_TBL(Sql)
        Return dt
    End Function
    Public Function DAILY_LOADING_DETAIL(LOAD_HEADER_NO As String) As DataTable
        Dim Sql As String = "SELECT LOAD_HEADER_NO, SHIPMENT_NO, SEAL_USE, SEAL_NUMBER, SHIPMENT_REF, TU_CARD_NO, TU_NUMBER, TU_NUMBER1, TU_ID, TU_ID1, VEHICLE_NUMBER, VEHICLE_ID, VEHICLE_MAP_TYPE, DRIVER_NAME, CARRIER_NAME, T_ENTRY, T_BILLING, T_REGISTOR, T_REGISTOR2, T_WEIGHTIN, T_BAY, T_TOPCHECK, T_WEIGHTOUT, T_EXIT, T_QUEUE, T_SHIPMENT, T_SEAL, EOD_DATE, BAYSTART, BAYSTOP, CANCEL_STATUS, LOAD_STATUS, WEIGHT_IN, WEIGHT_OUT, BATCH_NO, DO_NO, COMPARTMENT_NO, ISLAND_NO, ISLAND_NAME, BAY_NO, BAY_NAME, SALE_PRODUCT_ID, SALE_PRODUCT_NAME, SALE_PRODUCT_CODE, BASE_PRODUCT_ID, BASE_PRODUCT_NAME, COMPAMENT_CAPACITY, ADVICE, PRESET, TANK_NAME, METER_NO, TEMP, API60F, DESITY15C, FLOWRATE_AVG, PRESSURE, LOADED_GROSS, LOADED_NET, LOADED_VOLOBS, LOADED_VOL15C, LOADED_VOL30C, LOADED_NET_CAL, TOT_GROSS_START, TOT_GROSS_STOP, TOT_NET_START, TOT_NET_STOP, TOT_VOL30C_START, TOT_VOL30C_STOP, UNIT, VCF15C, VCF30C, LOADED_MASS, T_START, T_STOP, SHIP_TO_CODE, SHIPTO_NAME, CUSTOMER_CODE, CUSTOMER_NAME, GOV_PROJECT, GOV_IS_PRINT, GOV_PRINT_NO FROM RPT.DAILY_LOADING_DETAIL WHERE LOAD_HEADER_NO=" & LOAD_HEADER_NO
        Dim dt As DataTable = Oradb.Query_TBL(Sql)
        Return dt
    End Function
    Public Function VIEW_DELIV_HEADER(LOAD_HEADER_NO As String) As DataTable
        Dim Sql As String = "SELECT LOAD_HEADER_NO, SHIPMENT_NO, CREATION_DATE, T_BEGIN, T_END, T_BILLING, T_ENTRY, T_REGISTOR, TU_NUMBER, TU_ID, TU_NUMBER1, TU_ID1, VEHICLE_NUMBER, CARRIER_NAME, DRIVER_NAME, UNIT, VOLUME_MEASURE, WEIGHT_MEASURE, VOLUME_CALCURATE, WEIGHT_CALCURATE, SEAL_USE, SEAL_NUMBER, WEIGHT_IN, WEIGHT_OUT, WEIGHT_NET, EOD_DATE, DO_NO, PLAN_DATE, CUSTOMER_CODE, CUSTOMER_NAME, CUSTOMER_ADDRESS, SHIPTO_NAME, SHIPTO_PONO, SHIPTO_CONTRACT, SHIPTO_INDDEP, SHIPTO_TOPROJECT, LOADED_VOLOBS_500N, LOADED_VOLOBS_150N, LOADED_VOLOBS_150BS, COQ_DATE, GOV_COQ_NO, GOV_COQ_DATE
                             FROM RPT.VIEW_DELIV_HEADER WHERE LOAD_HEADER_NO=" & LOAD_HEADER_NO
        Dim dt As DataTable = Oradb.Query_TBL(Sql)
        Return dt
    End Function

    Public Function VIEW_DELIV_LINE(LOAD_HEADER_NO As String) As DataTable
        Dim Sql As String = "SELECT LOAD_HEADER_NO, DO_NO, COMPARTMENT_NO, SALE_PRODUCT_ID, SALE_PRODUCT_NAME, BASE_PRODUCT_ID, BASE_PRODUCT_NAME, LOADED_VOLOBS, LOADED_VOL15C, LOADED_VOL30C, LOADED_MASS, TEMP, DESITY15C, DESITY30C, VCF15C, VCF30C, TANK_ID, TANK_NAME, COQ_NO, METER_NO, METER_NAME
                             FROM RPT.VIEW_DELIV_LINE WHERE LOAD_HEADER_NO=" & LOAD_HEADER_NO
        Dim dt As DataTable = Oradb.Query_TBL(Sql)
        Return dt
    End Function

    Public Function VIEW_DELIV_SUM_LINE(LOAD_HEADER_NO As String) As DataTable
        Dim Sql As String = "SELECT RECORD_NO,
                                   LOAD_HEADER_NO,
                                   DO_NO,
                                   BASE_PRODUCT_ID,
                                   ROUND(LOADED_VOLOBS,2) AS LOADED_VOLOBS,
                                   ROUND(LOADED_VOL15C,2) AS LOADED_VOL15C,
                                   ROUND(LOADED_VOL30C,2) AS LOADED_VOL30C,
                                   ROUND(LOADED_MASS,2) AS LOADED_MASS,
                                   LOADED_VOLOBS_500N,
                                   LOADED_VOLOBS_150N,
                                   LOADED_VOLOBS_150BS,
                                   TEMP,
                                   DESITY15C,
                                   DESITY30C,
                                   VCF15C,
                                   VCF30C,
                                   COQ_NO,
                                   METER_NO,
                                   TANK_ID,
                                   TANK_NAME
                            FROM RPT.VIEW_DELIV_SUM_LINE
                            WHERE LOAD_HEADER_NO =" & LOAD_HEADER_NO
        Dim dt As DataTable = Oradb.Query_TBL(Sql)
        Return dt
    End Function

    Friend Function VIEW_LOAD_VOLUME_REPORT_DAILY(iDate As String) As DataTable
        Dim sql As String = "SELECT EOD_DATE, SALE_PRODUCT_ID, SALE_PRODUCT_NAME, COMPARTMENT_NO, METER_NO, DESITY15C, BASE_PRODUCT_ID, BASE_PRODUCT_NAME, SALE_PRODUCT_CODE, LOAD_HEADER_NO, CUSTOMER_CODE, DO_NO, CUSTOMER_NAME, DRIVER_ID, DRIVER_NAME, VEHICLE, T_BAY, T_COMPLETE, T_START, T_STOP, T_WEIGHTIN, T_WEIGHTOUT, WEIGHT_OUT, WEIGHT_IN, WEIGHT_NET, ADVICE, LOADED_GROSS, LOADED_NET, LOADED_VOLOBS, LOADED_VOL30C, LOADED_MASS, TEMP, SHIPTO_NAME
                             FROM RPT.VIEW_LOAD_VOLUME_REPORT_DAILY
                             WHERE TO_CHAR(EOD_DATE,'DD/MM/YYYY') =  '{0}' "
        sql = String.Format(sql, iDate)
        Dim dt As DataTable = Oradb.Query_TBL(sql)
        Return dt
    End Function

    Friend Function Query_TBL(iSQL As String) As DataTable
        Dim dt As DataTable = Oradb.Query_TBL(iSQL)
        Return dt
    End Function

    Friend Function VIEW_DATA_METER(iDate As String) As DataTable
        Dim sql As String = "SELECT EOD_DATE, METER_NO, METER, PULSE_INPUT, BASE_PRODUCT_ID, OPEN_GROSS_TOT, CLOSE_GROSS_TOT, OPEN_GST_TOT, CLOSE_GST_TOT, OPEN_MASS_TOT, CLOSE_MASS_TOT, ADVICE, PRESET, LOADED_GROSS, LOADED_OBS, LOADED_VOL15C, LOADED_VOL30C, LOADED_MASS, WEIGHT_MASS, LOADED_NET_CAL, UNIT
                             FROM RPT.VIEW_DATA_METER
                             WHERE TO_CHAR(EOD_DATE,'DD/MM/YYYY') =  '{0}' "
        sql = String.Format(sql, iDate)
        Dim dt As DataTable = Oradb.Query_TBL(sql)
        Return dt
    End Function

    Friend Function VIEW_DATA_LOADING_MONTHLY(iDate As String, iBASE_PRODUCT_ID As String) As DataTable
        Dim vDate As String = Date.ParseExact(iDate, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo).ToString("MM/yyyy")
        Dim sql As String = "SELECT EOD_DATE,
                                   BASE_PRODUCT_ID,
                                   METER_NO,
                                   SHIPMENT_NO,
                                   ROUND(TEMP,2)  AS TEMP,
                                   API60F,
                                   ROUND(DESITY15C,2) AS DESITY15C,
                                   LOADED_VOLOBS,
                                   LOADED_VOL15C,
                                   LOADED_VOL30C,
                                   LOADED_MASS,
                                   ADVICE,
                                   LOADED_GROSS,
                                   LOADED_NET,
                                   ROUND(LOADED_NET_CAL,2) AS LOADED_NET_CAL,
                                   START_TOT,
                                   STOP_TOT,
                                   WEIGHT_NET
                            FROM RPT.VIEW_DATA_LOADING_MONTHLY
                            WHERE TO_CHAR(EOD_DATE, 'MM/YYYY') = '{0}'
                            AND BASE_PRODUCT_ID='{1}' "
        sql = String.Format(sql, vDate, iBASE_PRODUCT_ID)
        Dim dt As DataTable = Oradb.Query_TBL(sql)
        Return dt
    End Function

    Friend Function VIEW_LOAD_REPORT_TANK_METER(iDate As String) As DataTable
        Dim sql As String = "SELECT EOD_DATE, SALE_PRODUCT_ID, SALE_PRODUCT_NAME, COMPARTMENT_NO, METER_NO, DESITY15C, BASE_PRODUCT_ID, BASE_PRODUCT_NAME, SALE_PRODUCT_CODE, SALE_DESCRIPTION, LOAD_HEADER_NO, CUSTOMER_CODE, DO_NO, CUSTOMER_NAME, SHIPTO_NAME, SHIPTO_CONTRACT, SHIPTO_TOPROJECT, GOV_PROJECT, DRIVER_ID, DRIVER_NAME, VEHICLE, SEAL_NUMBER, T_BAY, T_COMPLETE, T_WEIGHTIN, T_WEIGHTOUT, WEIGHT_OUT, WEIGHT_IN, WEIGHT_NET, TANK_ID, TANK_NAME, ADVICE, LOADED_GROSS, LOADED_NET, LOADED_VOLOBS, LOADED_VOL15C, LOADED_VOL30C, LOADED_MASS, TEMP, VCF30C, T_START, T_STOP, UNIT
                             FROM RPT.VIEW_LOAD_REPORT_TANK_METER
                             WHERE TO_CHAR(EOD_DATE,'DD/MM/YYYY') =  '{0}' "
        sql = String.Format(sql, iDate)
        Dim dt As DataTable = Oradb.Query_TBL(sql)
        Return dt
    End Function

    Friend Function VIEW_LOAD_VOLUME_REPORT_DAILY_YEARLY(iDate As String) As DataTable
        Dim sql As String = "SELECT EOD_DATE, SALE_PRODUCT_ID, SALE_PRODUCT_NAME, COMPARTMENT_NO, METER_NO, DESITY15C, BASE_PRODUCT_ID, BASE_PRODUCT_NAME, SALE_PRODUCT_CODE, LOAD_HEADER_NO, CUSTOMER_CODE, DO_NO, CUSTOMER_NAME, DRIVER_ID, DRIVER_NAME, VEHICLE, T_BAY, T_COMPLETE, T_START, T_STOP, T_WEIGHTIN, T_WEIGHTOUT, WEIGHT_OUT, WEIGHT_IN, WEIGHT_NET, ADVICE, LOADED_GROSS, LOADED_NET, LOADED_VOLOBS, LOADED_VOL30C, LOADED_MASS, TEMP, SHIPTO_NAME
                             FROM RPT.VIEW_LOAD_VOLUME_REPORT_DAILY
                             WHERE TO_CHAR(EOD_DATE,'YYYY') =  '{0}' "
        sql = String.Format(sql, iDate)
        Dim dt As DataTable = Oradb.Query_TBL(sql)
        Return dt
    End Function

    Friend Function VIEW_USER_SECURITY_PERMISSION(pGroup As String) As DataTable
        Dim sql As String = "SELECT SCREEN_ID, SUB_ID, SUB_MENU, MAIN_MENU, PERMISSION, CONFIRM_PASSWORD, DESCRIPTION, STATUS_NUMBER
                             FROM TAS.VIEW_USER_SECURITY_PERMISSION
                             WHERE STATUS_NUMBER =  '{0}' "
        sql = String.Format(sql, pGroup)
        Dim dt As DataTable = Oradb.Query_TBL(sql)
        Return dt
    End Function

    Friend Function VIEW_MONITOR_METER(param1 As String) As DataTable
        Dim dt As DataTable = Oradb.Query_TBL(param1)
        Return dt
    End Function

    Friend Function VIEW_DATA_TANK(iDate As String) As DataTable
        Dim sql As String = "SELECT TANK_ID, TANK_NAME, BASE_PRODUCT_ID, EOD_DATE, OPEN_DATE, O_TANK_TYPE, O_IS_ENABLED, O_TEMP, O_API60F, O_LEVELS, O_GROSS, O_NET, O_AVARIABLE, O_ROOM, O_DENSITY, CLOSE_DATE, C_TANK_TYPE, C_IS_ENABLED, C_TEMP, C_API60F, C_LEVELS, C_GROSS, C_NET, C_AVARIABLE, C_ROOM, C_DENSITY
                              FROM RPT.VIEW_DATA_TANK
                             WHERE TO_CHAR(EOD_DATE,'DD/MM/YYYY') =  '{0}' "
        sql = String.Format(sql, iDate)
        Dim dt As DataTable = Oradb.Query_TBL(sql)
        Return dt
    End Function

    Friend Function VIEW_LOAD_MASS_REPORT_DAILY_YEARLY(iDate As String) As DataTable
        Dim sql As String = "SELECT EOD_DATE, SALE_PRODUCT_ID, SALE_PRODUCT_NAME, COMPARTMENT_NO, METER_NO, DESITY15C, BASE_PRODUCT_ID, BASE_PRODUCT_NAME, SALE_PRODUCT_CODE, SALE_DESCRIPTION, LOAD_HEADER_NO, CUSTOMER_CODE, DO_NO, CUSTOMER_NAME, SHIPTO_NAME, SHIPTO_CONTRACT, SHIPTO_TOPROJECT, GOV_PROJECT, DRIVER_ID, DRIVER_NAME, VEHICLE, SEAL_NUMBER, T_BAY, T_COMPLETE, T_WEIGHTIN, T_WEIGHTOUT, WEIGHT_OUT, WEIGHT_IN, WEIGHT_NET, WEIGHT_NET_TON, TANK_ID, TANK_NAME, ADVICE, LOADED_GROSS, LOADED_NET, LOADED_VOLOBS, LOADED_VOL30C, LOADED_MASS, TEMP
                             FROM RPT.VIEW_LOAD_MASS_REPORT_DAILY
                             WHERE TO_CHAR(EOD_DATE,'YYYY') =  '{0}' "
        sql = String.Format(sql, iDate)
        Dim dt As DataTable = Oradb.Query_TBL(sql)
        Return dt
    End Function

    Friend Function VIEW_LOAD_VOLUME_REPORT_DAILY_MONTHLY(iDate As String) As DataTable
        Dim sql As String = "SELECT EOD_DATE, SALE_PRODUCT_ID, SALE_PRODUCT_NAME, COMPARTMENT_NO, METER_NO, DESITY15C, BASE_PRODUCT_ID, BASE_PRODUCT_NAME, SALE_PRODUCT_CODE, LOAD_HEADER_NO, CUSTOMER_CODE, DO_NO, CUSTOMER_NAME, DRIVER_ID, DRIVER_NAME, VEHICLE, T_BAY, T_COMPLETE, T_START, T_STOP, T_WEIGHTIN, T_WEIGHTOUT, WEIGHT_OUT, WEIGHT_IN, WEIGHT_NET, ADVICE, LOADED_GROSS, LOADED_NET, LOADED_VOLOBS, LOADED_VOL30C, LOADED_MASS, TEMP, SHIPTO_NAME
                             FROM RPT.VIEW_LOAD_VOLUME_REPORT_DAILY
                             WHERE TO_CHAR(EOD_DATE,'MM/YYYY') =  '{0}' "
        sql = String.Format(sql, iDate)
        Dim dt As DataTable = Oradb.Query_TBL(sql)
        Return dt
    End Function

    Friend Function VIEW_DATA_LOADING_YEARLY(iDate As String, iBASE_PRODUCT_ID As String) As DataTable
        Dim sql As String = "SELECT EOD_DATE,
                                   BASE_PRODUCT_ID,
                                   METER_NO,
                                   ROUND(TEMP,2)  AS TEMP,
                                   API60F,
                                   ROUND(DESITY15C,2) AS DESITY15C,
                                   LOADED_VOLOBS,
                                   LOADED_VOL15C,
                                   LOADED_VOL30C,
                                   LOADED_MASS,
                                   ADVICE,
                                   LOADED_GROSS,
                                   LOADED_NET,
                                   ROUND(LOADED_NET_CAL,2) AS LOADED_NET_CAL,
                                   START_TOT,
                                   STOP_TOT,
                                   WEIGHT_NET
                            FROM RPT.VIEW_DATA_LOADING_YEARLY
                            WHERE TO_CHAR(EOD_DATE, 'YYYY') = '{0}'
                            AND BASE_PRODUCT_ID='{1}' "
        sql = String.Format(sql, iDate, iBASE_PRODUCT_ID)
        Dim dt As DataTable = Oradb.Query_TBL(sql)
        Return dt
    End Function

    Friend Function VIEW_DATA_WEIGHT(load_no As String) As DataTable
        Dim Sql As String = "SELECT LOAD_HEADER_NO, DO_NO, TU_ID, TU_ID1, CARNUMBER, SHIPMENT_NO, T_WEIGHTIN, T_WEIGHTOUT, WEIGHT_IN, WEIGHT_OUT, WB_PRINT_COUNT, WB_PRINT, WB_DAILY_SEQ, WB_SEQ_ID, SALE_PRODUCT_NAME, DRIVER_NAME, ADVICE, PRESET, UNIT, CUSTOMER_CODE, CUSTOMER_NAME, SHOW_UNIT
                             FROM RPT.VIEW_DATA_WEIGHT
                             WHERE LOAD_HEADER_NO =" & load_no
        Dim dt As DataTable = Oradb.Query_TBL(Sql)
        Return dt
    End Function

    Friend Function VIEW_GOV_PROJECT_ATTACHAS(load_no As String) As DataTable
        Dim Sql As String = "SELECT LOAD_HEADER_NO, CREATION_DATE, GOV_PROJECT, GOV_IS_PRINT, GOV_PRINT_NO, sysdate, EOD_DATE
                             FROM RPT.VIEW_GOV_PROJECT_ATTACHAS
                             WHERE LOAD_HEADER_NO =" & load_no
        Dim dt As DataTable = Oradb.Query_TBL(Sql)
        Return dt
    End Function


    Friend Function VIEW_LOAD_MASS_REPORT_DAILY_MONTHLY(ByVal iDate As String) As DataTable
        Dim sql As String = "SELECT EOD_DATE, SALE_PRODUCT_ID, SALE_PRODUCT_NAME, COMPARTMENT_NO, METER_NO, DESITY15C, BASE_PRODUCT_ID, BASE_PRODUCT_NAME, SALE_PRODUCT_CODE, SALE_DESCRIPTION, LOAD_HEADER_NO, CUSTOMER_CODE, DO_NO, CUSTOMER_NAME, SHIPTO_NAME, SHIPTO_CONTRACT, SHIPTO_TOPROJECT, GOV_PROJECT, DRIVER_ID, DRIVER_NAME, VEHICLE, SEAL_NUMBER, T_BAY, T_COMPLETE, T_WEIGHTIN, T_WEIGHTOUT, WEIGHT_OUT, WEIGHT_IN, WEIGHT_NET, WEIGHT_NET_TON, TANK_ID, TANK_NAME, ADVICE, LOADED_GROSS, LOADED_NET, LOADED_VOLOBS, LOADED_VOL30C, LOADED_MASS, TEMP
                             FROM RPT.VIEW_LOAD_MASS_REPORT_DAILY
                             WHERE TO_CHAR(EOD_DATE,'MM/YYYY') =  '{0}' "
        sql = String.Format(sql, iDate)
        Dim dt As DataTable = Oradb.Query_TBL(sql)
        Return dt
    End Function
    Friend Function VIEW_LOAD_MASS_REPORT_DAILY_END_OFF_DAY(ByVal iDate As String) As DataTable
        Dim sql As String = "SELECT EOD_DATE, SALE_PRODUCT_ID, SALE_PRODUCT_NAME, COMPARTMENT_NO, METER_NO, DESITY15C, BASE_PRODUCT_ID, BASE_PRODUCT_NAME, SALE_PRODUCT_CODE, SALE_DESCRIPTION, LOAD_HEADER_NO, CUSTOMER_CODE, DO_NO, CUSTOMER_NAME, SHIPTO_NAME, SHIPTO_CONTRACT, SHIPTO_TOPROJECT, GOV_PROJECT, DRIVER_ID, DRIVER_NAME, VEHICLE, SEAL_NUMBER, T_BAY, T_COMPLETE, T_WEIGHTIN, T_WEIGHTOUT, WEIGHT_OUT, WEIGHT_IN, WEIGHT_NET, WEIGHT_NET_TON, TANK_ID, TANK_NAME, ADVICE, LOADED_GROSS, LOADED_NET, LOADED_VOLOBS, LOADED_VOL30C, LOADED_MASS, TEMP
                             FROM RPT.VIEW_LOAD_MASS_REPORT_DAILY
                             WHERE TO_CHAR(EOD_DATE,'DD/MM/YYYY') =  '{0}' "
        sql = String.Format(sql, iDate)
        Dim dt As DataTable = Oradb.Query_TBL(sql)
        Return dt
    End Function
End Class
