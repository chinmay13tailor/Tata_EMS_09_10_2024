#region Using directives
using System;
using UAManagedCore;
using FTOptix.NetLogic;
using Store = FTOptix.Store;
#endregion

public class HomePageComparisionLogic : BaseNetLogic
{
    private IUAVariable dateVariable;
    private IUAVariable date1Variable;
    private IUAVariable utilitypowerVariable;
    private IUAVariable jacestampingVariable;
    // private IUAVariable targetstampingVariable;
    // private IUAVariable yearloweststampingVariable;
    private IUAVariable monthloweststampingVariable;
    private IUAVariable averagestampingVariable;
    private IUAVariable consumptionstampingVariable;
    private IUAVariable jacetcfVariable;
    // private IUAVariable targettcfVariable;
    // private IUAVariable yearlowesttcfVariable;
    private IUAVariable monthlowesttcfVariable;
    private IUAVariable averagetcfVariable;
    private IUAVariable consumptiontcfVariable;
    private IUAVariable tcfpowerVariable;
    private IUAVariable jacebodyshopVariable;
    // private IUAVariable targetbodyshopVariable;
    // private IUAVariable yearlowestbodyshopVariable;
    private IUAVariable monthlowestbodyshopVariable;
    private IUAVariable averagebodyshopVariable;
    private IUAVariable consumptionbodyshopVariable;
    private IUAVariable consumptionpaintshopVariable;
    private IUAVariable paintshoppowerVariable;
    private IUAVariable jacesppVariable;
    // private IUAVariable targetsppVariable;
    // private IUAVariable yearlowestsppVariable;
    private IUAVariable monthlowestsppVariable;
    private IUAVariable averagesppVariable;
    private IUAVariable consumptionsppVariable;
    private IUAVariable spppowerVariable;
    private IUAVariable jacespareVariable;
    private IUAVariable targetspareVariable;
    private IUAVariable yearlowestspareVariable;
    private IUAVariable monthlowestspareVariable;
    private IUAVariable averagespareVariable;
    private IUAVariable consumptionspareVariable;
    private IUAVariable jace33kvVariable;
    // private IUAVariable target33kvVariable;
    //  private IUAVariable yearlowest33kvVariable;
    private IUAVariable monthlowest33kvVariable;
    private IUAVariable average33kvVariable;
    private IUAVariable consumption33kvVariable;
    private IUAVariable kv33powerVariable;
    private IUAVariable bodyshoppercentageVariable;
    private IUAVariable engineshoppercentageVariable;
    private IUAVariable paintshoppercentageVariable;
    private IUAVariable sparepercentageVariable;
    private IUAVariable spppercentageVariable;
    private IUAVariable utilitypercentageVariable;
    private IUAVariable stampingpercentageVariable;
    private IUAVariable tcfpercentageVariable;
    private IUAVariable jaceengineshopVariable;
    //  private IUAVariable targetengineshopVariable;
    // private IUAVariable yearlowestengineshopVariable;
    private IUAVariable monthlowestengineshopVariable;
    private IUAVariable averageengineshopVariable;
    private IUAVariable consumptionengineshopVariable;
    private IUAVariable jacepaintshopVariable;
    // private IUAVariable targetpaintshopVariable;
    // private IUAVariable yearlowestpaintshopVariable;
    private IUAVariable monthlowestpaintshopVariable;
    private IUAVariable averagepaintshopVariable;
    private IUAVariable jaceVariable;
    private IUAVariable meterVariable;
    // private IUAVariable targetVariable;
    // private IUAVariable yearlowestVariable;
    private IUAVariable monthlowestVariable;
    private IUAVariable averageVariable;
    private IUAVariable consumptionVariable;
    private IUAVariable gbuttonVariable;
    private PeriodicTask periodicTask;
    private IUAVariable monthyearVariable;
    private IUAVariable productioncountVariable;
    private IUAVariable yearVariable;
    private IUAVariable monthconsumptionVariable;
    private IUAVariable bodyshoppowerVariable;
    private IUAVariable adminpowerVariable;
    private IUAVariable stampingpowerVariable;






    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        var owner = (HomePageComparisionPanel)LogicObject.Owner;
        productioncountVariable = owner.ProductionCountVariable;
        monthyearVariable = owner.MonthyearVariable;
        yearVariable = owner.YearVariable;
        monthconsumptionVariable = owner.MonthConsumptionVariable;
        //Utility
        jaceVariable = owner.JaceVariable;
        meterVariable = owner.MeterVariable;
        // targetVariable = owner.TargetVariable;
        //  yearlowestVariable = owner.YearlowestVariable;
        monthlowestVariable = owner.MonthlowestVariable;
        averageVariable = owner.AverageVariable;
        consumptionVariable = owner.ConsumptionVariable;
        gbuttonVariable = owner.GBUTTONVariable;
        dateVariable = owner.DateVariable;
        date1Variable = owner.Date1Variable;
        utilitypowerVariable = owner.UtilityPowerVariable;

        // Stamping
        jacestampingVariable = owner.JaceStampingVariable;
        // targetstampingVariable = owner.TargetStampingVariable;
        // yearloweststampingVariable = owner.YearlowestStampingVariable;
        monthloweststampingVariable = owner.MonthlowestStampingVariable;
        averagestampingVariable = owner.AverageStampingVariable;
        consumptionstampingVariable = owner.ConsumptionStampingVariable;
        stampingpowerVariable = owner.StampingPowerVariable;
        // TCF
        jacetcfVariable = owner.JaceTcfVariable;
        //  targettcfVariable = owner.TargetTcfVariable;
        // yearlowesttcfVariable = owner.YearlowestTcfVariable;
        monthlowesttcfVariable = owner.MonthlowestTcfVariable;
        averagetcfVariable = owner.AverageTcfVariable;
        consumptiontcfVariable = owner.ConsumptionTcfVariable;
        tcfpowerVariable = owner.TcfPowerVariable;

        // Bodyshop
        jacebodyshopVariable = owner.JaceBodyshopVariable;
        // targetbodyshopVariable = owner.TargetBodyshopVariable;
        // yearlowestbodyshopVariable = owner.YearlowestBodyshopVariable;
        monthlowestbodyshopVariable = owner.MonthlowestBodyshopVariable;
        averagebodyshopVariable = owner.AverageBodyshopVariable;
        consumptionbodyshopVariable = owner.ConsumptionBodyshopVariable;
        bodyshoppowerVariable = owner.BodyshopPowerVariable;

        // Engineshop
        jaceengineshopVariable = owner.JaceEngineshopVariable;
        //  targetengineshopVariable = owner.TargetEngineshopVariable;
        // yearlowestengineshopVariable = owner.YearlowestEngineshopVariable;
        monthlowestengineshopVariable = owner.MonthlowestEngineshopVariable;
        averageengineshopVariable = owner.AverageEngineshopVariable;
        consumptionengineshopVariable = owner.ConsumptionEngineshopVariable;
        adminpowerVariable = owner.AdminPowerVariable;

        // Paintshop
        jacepaintshopVariable = owner.JacePaintshopVariable;
        // targetpaintshopVariable = owner.TargetPaintshopVariable;
        // yearlowestpaintshopVariable = owner.YearlowestPaintshopVariable;
        monthlowestpaintshopVariable = owner.MonthlowestPaintshopVariable;
        averagepaintshopVariable = owner.AveragePaintshopVariable;
        consumptionpaintshopVariable = owner.ConsumptionPaintshopVariable;
        paintshoppowerVariable = owner.PaintshopPowerVariable;

        // Spp
        jacesppVariable = owner.JaceSppVariable;
        // targetsppVariable = owner.TargetSppVariable;
        //  yearlowestsppVariable = owner.YearlowestSppVariable;
        monthlowestsppVariable = owner.MonthlowestSppVariable;
        averagesppVariable = owner.AverageSppVariable;
        consumptionsppVariable = owner.ConsumptionSppVariable;
        spppowerVariable = owner.SppPowerVariable;

        // Spare
        jacespareVariable = owner.JaceSpareVariable;
        // targetspareVariable = owner.TargetSpareVariable;
        // yearlowestspareVariable = owner.YearlowestSpareVariable;
        monthlowestspareVariable = owner.MonthlowestSpareVariable;
        averagespareVariable = owner.AverageSpareVariable;
        consumptionspareVariable = owner.ConsumptionSpareVariable;


        // 33KV
        jace33kvVariable = owner.Jace33KVVariable;
        // target33kvVariable = owner.Target33KVVariable;
        // yearlowest33kvVariable = owner.Yearlowest33KVVariable;
        monthlowest33kvVariable = owner.Monthlowest33KVVariable;
        average33kvVariable = owner.Average33KVVariable;
        consumption33kvVariable = owner.Consumption33KVVariable;
        kv33powerVariable = owner.KV33PowerVariable;

        ////Calculation Related/////////
        utilitypercentageVariable = owner.UtilitypercentageVariable;
        stampingpercentageVariable = owner.StampingpercentageVariable;
        tcfpercentageVariable = owner.TcfpercentageVariable;
        bodyshoppercentageVariable = owner.BodyshoppercentageVariable;
        engineshoppercentageVariable = owner.EngineshoppercentageVariable;
        paintshoppercentageVariable = owner.PaintshoppercentageVariable;
        sparepercentageVariable = owner.SparepercentageVariable;
        spppercentageVariable = owner.SpppercentageVariable;


        periodicTask = new PeriodicTask(IncrementDecrementTask, 60000, LogicObject);
        periodicTask.Start();


    }
    ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////
    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
        periodicTask.Dispose();
        periodicTask = null;
    }

    public void IncrementDecrementTask()
    {
        DateTime date = dateVariable.Value;
        String date1 = date1Variable.Value;
        String monthyear = monthyearVariable.Value;
        String year = yearVariable.Value;

        //For Utility
        int jace = jaceVariable.Value;
        int meter = meterVariable.Value;
        //int target = targetVariable.Value;
        //  int yearlowest = yearlowestVariable.Value;
        int monthlowest = monthlowestVariable.Value;
        int average = averageVariable.Value;
        int consumption = consumptionVariable.Value;
        bool gbutton = gbuttonVariable.Value;
        float utilitypower = utilitypowerVariable.Value;

        //For Stamping
        int jacestamping = jacestampingVariable.Value;
        // int targetstamping = targetstampingVariable.Value;
        //  int yearloweststamping = yearloweststampingVariable.Value;
        int monthloweststamping = monthloweststampingVariable.Value;
        int averagestamping = averagestampingVariable.Value;
        float consumptionstamping = consumptionstampingVariable.Value;
        float stampingpower = stampingpowerVariable.Value;

        // For TCF
        int jacetcf = jacetcfVariable.Value;
        // int targettcf = targettcfVariable.Value;
        //  int yearlowesttcf = yearlowesttcfVariable.Value;
        int monthlowesttcf = monthlowesttcfVariable.Value;
        int averagetcf = averagetcfVariable.Value;
        float consumptiontcf = consumptiontcfVariable.Value;
        float tcfpower = tcfpowerVariable.Value;

        // For BodyShop
        int jacebodyshop = jacebodyshopVariable.Value;
        // int targetbodyshop = targetbodyshopVariable.Value;
        // int yearlowestbodyshop = yearlowestbodyshopVariable.Value;
        int monthlowestbodyshop = monthlowestbodyshopVariable.Value;
        int averagebodyshop = averagebodyshopVariable.Value;
        float consumptionbodyshop = consumptionbodyshopVariable.Value;
        float bodyshoppower = bodyshoppowerVariable.Value;

        // For EngineShop
        int jaceengineshop = jaceengineshopVariable.Value;
        // int targetengineshop = targetengineshopVariable.Value;
        //  int yearlowestengineshop = yearlowestengineshopVariable.Value;
        int monthlowestengineshop = monthlowestengineshopVariable.Value;
        int averageengineshop = averageengineshopVariable.Value;
        float consumptionengineshop = consumptionengineshopVariable.Value;
        float adminpower = adminpowerVariable.Value;

        // For Paintshop
        int jacepaintshop = jacepaintshopVariable.Value;
        // int targetpaintshop = targetpaintshopVariable.Value;
        //  int yearlowestpaintshop = monthlowestpaintshopVariable.Value;
        int monthlowestpaintshop = monthlowestpaintshopVariable.Value;
        int averagepaintshop = averagepaintshopVariable.Value;
        float consumptionpaintshop = consumptionpaintshopVariable.Value;
        float paintshoppower = paintshoppowerVariable.Value;


        // For Spp
        int jacespp = jacesppVariable.Value;
        // int targetspp = targetsppVariable.Value;
        //  int yearlowestspp = yearlowestsppVariable.Value;
        int monthlowestspp = monthlowestsppVariable.Value;
        int averagespp = averagesppVariable.Value;
        float consumptionspp = consumptionsppVariable.Value;
        float spppower = spppowerVariable.Value;


        // For Spare
        int jacespare = jacespareVariable.Value;
        // int targetspare = targetspareVariable.Value;
        // int yearlowestspare = yearlowestspareVariable.Value;
        int monthlowestspare = monthlowestspareVariable.Value;
        int averagespare = averagespareVariable.Value;
        float consumptionspare = consumptionspareVariable.Value;

        // For 33Kv
        int jace33kv = jace33kvVariable.Value;
        //int target33kv = target33kvVariable.Value;
        //int yearlowest33kv = yearlowest33kvVariable.Value;
        int monthlowest33kv = monthlowest33kvVariable.Value;
        int average33kv = average33kvVariable.Value;
        float consumption33kv = consumption33kvVariable.Value;
        float monthconsumption = monthconsumptionVariable.Value;
        float kv33power = kv33powerVariable.Value;

        //////////////Production Count/////////////////
        int productioncount = productioncountVariable.Value;

        // For Calculation
        float utilitypercentage = utilitypercentageVariable.Value;
        float stampingpercentage = stampingpercentageVariable.Value;
        float tcfpercentage = tcfpercentageVariable.Value;
        float bodyshoppercentage = bodyshoppercentageVariable.Value;
        float engineshoppercentage = engineshoppercentageVariable.Value;
        float paintshoppercentage = paintshoppercentageVariable.Value;
        float sparepercentage = sparepercentageVariable.Value;
        float spppercentage = spppercentageVariable.Value;

        ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////

        var project = FTOptix.HMIProject.Project.Current;
        // For Utility
        var myStore = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");//Target


        ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////
        // if (gbutton == true)
        // {

        DateTime currentTime = DateTime.Now;
        string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

        // Calculate start and end times for the current day
        DateTime startTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0);
        DateTime endTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0).AddDays(-1);
        //  string new321 = endTime.ToString("yyyy-MM-dd");

        string new123 = startTime.ToString("yyyy-MM-dd");
        string month123 = startTime.ToString("yyyy-MM");
        string year123 = startTime.ToString("yyyy");
        // int target33KV = target33kvVariable.Value;
        //  float targetstamping1 = targetstampingVariable.Value;
        //  float targettcf1 = targettcfVariable.Value;
        //  float targetbodyshop1 = targetbodyshopVariable.Value;
        //  float targetengineshop1 = targetengineshopVariable.Value;
        //  float targetpaintshop1 = targetpaintshopVariable.Value;
        //  float targetspp1 = targetsppVariable.Value;
        //  float targetutility1 = targetVariable.Value;
        //  float productioncount1 = productioncountVariable.Value;

       // string old123 = endTime.ToString("yyyy-MM-dd");

        //throw new Exception(query46);

        ////////////////////////////////*********************************************/////////////////////////////////////////////////////////////////////////// 
        // For Utility
        // myStore.Query(" UPDATE HomePage SET Target = '" + targetutility1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'UTILITY' ", out _, out _);
        // myStore1.Query(query1, out string[] header1, out object[,] resultSet1);
        myStore.Query("SELECT Active_Power_Total FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'UTILITY' ", out string[] header2, out object[,] resultSet2);
        myStore.Query("SELECT MIN(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = 'UTILITY' ", out string[] header3, out object[,] resultSet3);
        myStore.Query("SELECT AVG(Consumption) FROM DailyJaceDataLogger WHERE MonthYear  = '" + month123 + "' AND Jace = 'UTILITY' ", out string[] header4, out object[,] resultSet4);
        myStore.Query("SELECT Consumption FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'UTILITY' ", out string[] header5, out object[,] resultSet5);
        // For Stamping
        // myStore.Query(" UPDATE HomePage SET Target = '" + targetstamping1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'STAMPING' ", out _, out _);
        myStore.Query("SELECT Active_Power_Total FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'STAMPING' ", out string[] header7, out object[,] resultSet7);
        myStore.Query("SELECT MIN(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = 'STAMPING' ", out string[] header8, out object[,] resultSet8);
        myStore.Query("SELECT AVG(Consumption) FROM DailyJaceDataLogger WHERE MonthYear  = '" + month123 + "' AND Jace = 'STAMPING' ", out string[] header9, out object[,] resultSet9);
        myStore.Query("SELECT Consumption FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'STAMPING' ", out string[] header10, out object[,] resultSet10);

        // For Tcf
        // myStore.Query(" UPDATE HomePage SET Target = '" + targettcf1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'TCF' ", out _, out _);
        myStore.Query("SELECT Active_Power_Total FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'TCF' ", out string[] header12, out object[,] resultSet12);
        myStore.Query("SELECT MIN(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = 'TCF' ", out string[] header13, out object[,] resultSet13);
        myStore.Query("SELECT AVG(Consumption) FROM DailyJaceDataLogger WHERE MonthYear  = '" + month123 + "' AND Jace = 'TCF' ", out string[] header14, out object[,] resultSet14);
        myStore.Query("SELECT Consumption FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'TCF' ", out string[] header15, out object[,] resultSet15);


        // For Bodyshop
        //  myStore.Query(" UPDATE HomePage SET Target = '" + targetbodyshop1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'BODYSHOP' ", out _, out _);
        myStore.Query("SELECT Active_Power_Total FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'BODYSHOP' ", out string[] header17, out object[,] resultSet17);
        myStore.Query("SELECT MIN(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = 'BODYSHOP' ", out string[] header18, out object[,] resultSet18);
        myStore.Query("SELECT AVG(Consumption) FROM DailyJaceDataLogger WHERE MonthYear  = '" + month123 + "' AND Jace = 'BODYSHOP' ", out string[] header19, out object[,] resultSet19);
        myStore.Query("SELECT Consumption FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'BODYSHOP' ", out string[] header20, out object[,] resultSet20);



        // For Admin Shop
        // myStore.Query(" UPDATE HomePage SET Target = '" + targetengineshop1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'ADMIN' ", out _, out _);
        myStore.Query("SELECT Active_Power_Total FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'ADMIN' ", out string[] header22, out object[,] resultSet22);
        myStore.Query("SELECT MIN(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = 'ADMIN' ", out string[] header23, out object[,] resultSet23);
        myStore.Query("SELECT AVG(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = 'ADMIN' ", out string[] header24, out object[,] resultSet24);
        myStore.Query("SELECT Consumption FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'ADMIN' ", out string[] header25, out object[,] resultSet25);

        // For Paintshop
        //  myStore.Query(" UPDATE HomePage SET Target = '" + targetpaintshop1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'PAINTSHOP' ", out _, out _);
        myStore.Query("SELECT Active_Power_Total FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'PAINTSHOP' ", out string[] header27, out object[,] resultSet27);
        myStore.Query("SELECT MIN(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = 'PAINTSHOP' ", out string[] header28, out object[,] resultSet28);
        myStore.Query("SELECT AVG(Consumption) FROM DailyJaceDataLogger WHERE MonthYear  = '" + month123 + "' AND Jace = 'PAINTSHOP' ", out string[] header29, out object[,] resultSet29);
        myStore.Query("SELECT Consumption FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'PAINTSHOP' ", out string[] header30, out object[,] resultSet30);


        // For Spp
        //   myStore.Query(" UPDATE HomePage SET Target = '" + targetspp1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'SPP' ", out _, out _);
        myStore.Query("SELECT Active_Power_Total FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'SPP' ", out string[] header32, out object[,] resultSet32);
        myStore.Query("SELECT MIN(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = 'SPP' ", out string[] header33, out object[,] resultSet33);
        myStore.Query("SELECT AVG(Consumption) FROM DailyJaceDataLogger WHERE MonthYear  = '" + month123 + "' AND Jace = 'SPP' ", out string[] header34, out object[,] resultSet34);
        myStore.Query("SELECT Consumption FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'SPP' ", out string[] header35, out object[,] resultSet35);
        // For 33KV
        //  myStore.Query(" UPDATE HomePage SET Target = '" + target33KV + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = '33KV' ", out _, out _);
        myStore.Query("SELECT Active_Power_Total FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = '33KV' ", out string[] header42, out object[,] resultSet42);
        myStore.Query("SELECT MIN(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = '33KV' ", out string[] header43, out object[,] resultSet43);
        myStore.Query("SELECT AVG(Consumption) FROM DailyJaceDataLogger WHERE MonthYear  = '" + month123 + "' AND Jace = '33KV' ", out string[] header44, out object[,] resultSet44);
        myStore.Query("SELECT Consumption FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = '33KV' ", out string[] header45, out object[,] resultSet45);

        //  myStore.Query(" UPDATE HomePage SET Production = '" + productioncount1 + "' WHERE LocalTimestamp BETWEEN '" + old123 + " 0:00:00' AND '" + old123 + " 23:59:59' ", out _, out _);
        myStore.Query("SELECT SUM(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = '33KV' ", out string[] header47, out object[,] resultSet47);/////////////////For Production Count/////////////////////

        ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////

        //For Utility
        /*
        var rowCount1 = resultSet1 != null ? resultSet1.GetLength(0) : 0;
        var columnCount1 = header1 != null ? header1.Length : 0;
        if (rowCount1 > 0 && columnCount1 > 0)
        {
            var column1 = Convert.ToInt32(resultSet1[0, 0]);
            var Target = column1;
            target = Target;
        }
        */



        // For resultSet2
        if (resultSet2?.GetLength(0) > 0 && header2?.Length > 0)
        {
            utilitypower = Convert.ToInt32(resultSet2[0, 0]);
        }

        // For resultSet3
        if (resultSet3?.GetLength(0) > 0 && header3?.Length > 0)
        {
            monthlowest = Convert.ToInt32(resultSet3[0, 0]);
        }

        // For resultSet4
        if (resultSet4?.GetLength(0) > 0 && header4?.Length > 0)
        {
            average = Convert.ToInt32(resultSet4[0, 0]);
        }

        // For resultSet5
        if (resultSet5?.GetLength(0) > 0 && header5?.Length > 0)
        {
            consumption = Convert.ToInt32(resultSet5[0, 0]);
        }

        // For resultSet6 (commented out as per your note)
        // if (resultSet6?.GetLength(0) > 0 && header6?.Length > 0)
        // {
        //     targetstamping = Convert.ToInt32(resultSet6[0, 0]);
        // }

        // For resultSet7
        if (resultSet7?.GetLength(0) > 0 && header7?.Length > 0)
        {
            stampingpower = Convert.ToInt32(resultSet7[0, 0]);
        }

        // For resultSet8
        if (resultSet8?.GetLength(0) > 0 && header8?.Length > 0)
        {
            monthloweststamping = Convert.ToInt32(resultSet8[0, 0]);
        }

        // For resultSet9
        if (resultSet9?.GetLength(0) > 0 && header9?.Length > 0)
        {
            averagestamping = Convert.ToInt32(resultSet9[0, 0]);
        }

        // For resultSet10
        if (resultSet10?.GetLength(0) > 0 && header10?.Length > 0)
        {
            consumptionstamping = Convert.ToInt32(resultSet10[0, 0]);
        }

        // For resultSet11 (commented out as per your note)
        // if (resultSet11?.GetLength(0) > 0 && header11?.Length > 0)
        // {
        //     targetstamping = Convert.ToInt32(resultSet11[0, 0]);
        // }

        // For resultSet12
        if (resultSet12?.GetLength(0) > 0 && header12?.Length > 0)
        {
            tcfpower = Convert.ToInt32(resultSet12[0, 0]);
        }

        // For resultSet13
        if (resultSet13?.GetLength(0) > 0 && header13?.Length > 0)
        {
            monthlowesttcf = Convert.ToInt32(resultSet13[0, 0]);
        }

        // For resultSet14
        if (resultSet14?.GetLength(0) > 0 && header14?.Length > 0)
        {
            averagetcf = Convert.ToInt32(resultSet14[0, 0]);
        }

        // For resultSet15
        if (resultSet15?.GetLength(0) > 0 && header15?.Length > 0)
        {
            consumptiontcf = Convert.ToInt32(resultSet15[0, 0]);
        }

        // For resultSet16 (commented out as per your note)
        // if (resultSet16?.GetLength(0) > 0 && header16?.Length > 0)
        // {
        //     targetbodyshop = Convert.ToInt32(resultSet16[0, 0]);
        // }

        // For resultSet17
        if (resultSet17?.GetLength(0) > 0 && header17?.Length > 0)
        {
            bodyshoppower = Convert.ToInt32(resultSet17[0, 0]);
        }

        // For resultSet18
        if (resultSet18?.GetLength(0) > 0 && header18?.Length > 0)
        {
            monthlowestbodyshop = Convert.ToInt32(resultSet18[0, 0]);
        }

        // For resultSet19
        if (resultSet19?.GetLength(0) > 0 && header19?.Length > 0)
        {
            averagebodyshop = Convert.ToInt32(resultSet19[0, 0]);
        }

        // For resultSet20
        if (resultSet20?.GetLength(0) > 0 && header20?.Length > 0)
        {
            consumptionbodyshop = Convert.ToInt32(resultSet20[0, 0]);
        }

        // For resultSet21 (commented out as per your note)
        // if (resultSet21?.GetLength(0) > 0 && header21?.Length > 0)
        // {
        //     targetengineshop = Convert.ToInt32(resultSet21[0, 0]);
        // }

        // For resultSet22
        if (resultSet22?.GetLength(0) > 0 && header22?.Length > 0)
        {
            adminpower = Convert.ToInt32(resultSet22[0, 0]);
        }

        // For resultSet23
        if (resultSet23?.GetLength(0) > 0 && header23?.Length > 0)
        {
            monthlowestengineshop = Convert.ToInt32(resultSet23[0, 0]);
        }

        // For resultSet24
        if (resultSet24?.GetLength(0) > 0 && header24?.Length > 0)
        {
            averageengineshop = Convert.ToInt32(resultSet24[0, 0]);
        }

        // For resultSet25
        if (resultSet25?.GetLength(0) > 0 && header25?.Length > 0)
        {
            consumptionengineshop = Convert.ToInt32(resultSet25[0, 0]);
        }

        // For resultSet26 (commented out as per your note)
        // if (resultSet26?.GetLength(0) > 0 && header26?.Length > 0)
        // {
        //     targetpaintshop = Convert.ToInt32(resultSet26[0, 0]);
        // }

        // For resultSet27
        if (resultSet27?.GetLength(0) > 0 && header27?.Length > 0)
        {
            paintshoppower = Convert.ToInt32(resultSet27[0, 0]);
        }

        // For resultSet28
        if (resultSet28?.GetLength(0) > 0 && header28?.Length > 0)
        {
            monthlowestpaintshop = Convert.ToInt32(resultSet28[0, 0]);
        }

        // For resultSet29
        if (resultSet29?.GetLength(0) > 0 && header29?.Length > 0)
        {
            averagepaintshop = Convert.ToInt32(resultSet29[0, 0]);
        }

        // For resultSet30
        if (resultSet30?.GetLength(0) > 0 && header30?.Length > 0)
        {
            consumptionpaintshop = Convert.ToInt32(resultSet30[0, 0]);
        }

        // For resultSet31 (commented out as per your note)
        // if (resultSet31?.GetLength(0) > 0 && header31?.Length > 0)
        // {
        //     targetspp = Convert.ToInt32(resultSet31[0, 0]);
        // }

        // For resultSet32
        if (resultSet32?.GetLength(0) > 0 && header32?.Length > 0)
        {
            spppower = Convert.ToInt32(resultSet32[0, 0]);
        }

        // For resultSet33
        if (resultSet33?.GetLength(0) > 0 && header33?.Length > 0)
        {
            monthlowestspp = Convert.ToInt32(resultSet33[0, 0]);
        }

        // For resultSet34
        if (resultSet34?.GetLength(0) > 0 && header34?.Length > 0)
        {
            averagespp = Convert.ToInt32(resultSet34[0, 0]);
        }

        // For resultSet35
        if (resultSet35?.GetLength(0) > 0 && header35?.Length > 0)
        {
            consumptionspp = Convert.ToInt32(resultSet35[0, 0]);
        }

        // For resultSet36 (commented out as per your note)
        // if (resultSet36?.GetLength(0) > 0 && header36?.Length > 0)
        // {
        //     targetspare = Convert.ToInt32(resultSet36[0, 0]);
        // }

        // For resultSet41 (commented out as per your note)
        // if (resultSet41?.GetLength(0) > 0 && header41?.Length > 0)
        // {
        //     target33kv = Convert.ToInt32(resultSet41[0, 0]);
        // }

        // For resultSet42
        if (resultSet42?.GetLength(0) > 0 && header42?.Length > 0)
        {
            kv33power = Convert.ToInt32(resultSet42[0, 0]);
        }

        // For resultSet43
        if (resultSet43?.GetLength(0) > 0 && header43?.Length > 0)
        {
            monthlowest33kv = Convert.ToInt32(resultSet43[0, 0]);
        }

        // For resultSet44
        if (resultSet44?.GetLength(0) > 0 && header44?.Length > 0)
        {
            average33kv = Convert.ToInt32(resultSet44[0, 0]);
        }

        // For resultSet45
        if (resultSet45?.GetLength(0) > 0 && header45?.Length > 0)
        {
            consumption33kv = Convert.ToInt32(resultSet45[0, 0]);
        }

        // For resultSet47
        if (resultSet47?.GetLength(0) > 0 && header47?.Length > 0)
        {
            monthconsumption = Convert.ToInt32(resultSet47[0, 0]);
        }



        ////////////////Calculation for Percentage/////////////////////////////
        float utilityP = (consumption * 100) / consumption33kv;
        float stampingP = (consumptionstamping * 100) / consumption33kv;
        float bodyshopP = (consumptionbodyshop * 100) / consumption33kv;
        float paintshopP = (consumptionpaintshop * 100) / consumption33kv;
        float sppP = (consumptionspp * 100) / consumption33kv;
        float spareP = (consumptionspare * 100) / consumption33kv;
        float tcfP = (consumptiontcf * 100) / consumption33kv;
        float engineP = (consumptionengineshop * 100) / consumption33kv;


        utilitypercentage = utilityP;
        stampingpercentage = stampingP;
        tcfpercentage = tcfP;
        bodyshoppercentage = bodyshopP;
        engineshoppercentage = engineP;
        paintshoppercentage = paintshopP;
        sparepercentage = spareP;
        spppercentage = sppP;

        // }

        /////////////////////////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////
        monthyearVariable.Value = monthyear;
        yearVariable.Value = year;
        date1Variable.Value = date1;
        // For Utility
        //targetVariable.Value = target;
        utilitypowerVariable.Value = utilitypower;
        monthlowestVariable.Value = monthlowest;
        averageVariable.Value = average;
        consumptionVariable.Value = consumption;

        // For Stamping
        //targetstampingVariable.Value = targetstamping;
        stampingpowerVariable.Value = stampingpower;
        monthloweststampingVariable.Value = monthloweststamping;
        averagestampingVariable.Value = averagestamping;
        consumptionstampingVariable.Value = consumptionstamping;

        // For TCF
        //targettcfVariable.Value = targettcf;
        tcfpowerVariable.Value = tcfpower;
        monthlowesttcfVariable.Value = monthlowesttcf;
        averagetcfVariable.Value = averagetcf;
        consumptiontcfVariable.Value = consumptiontcf;

        // For Bodyshop
        //targetbodyshopVariable.Value = targetbodyshop;
        bodyshoppowerVariable.Value = bodyshoppower;
        monthlowestbodyshopVariable.Value = monthlowestbodyshop;
        averagebodyshopVariable.Value = averagebodyshop;
        consumptionbodyshopVariable.Value = consumptionbodyshop;


        // For Engineshop
        //targetengineshopVariable.Value = targetengineshop;
        adminpowerVariable.Value = adminpower;
        monthlowestengineshopVariable.Value = monthlowestengineshop;
        averageengineshopVariable.Value = averageengineshop;
        consumptionengineshopVariable.Value = consumptionengineshop;


        // For Paintshop
        //targetpaintshopVariable.Value = targetpaintshop;
        paintshoppowerVariable.Value = paintshoppower;
        monthlowestpaintshopVariable.Value = monthlowestpaintshop;
        averagepaintshopVariable.Value = averagepaintshop;
        consumptionpaintshopVariable.Value = consumptionpaintshop;

        // For Spp
        //targetsppVariable.Value = targetspp;
        spppowerVariable.Value = spppower;
        monthlowestsppVariable.Value = monthlowestspp;
        averagesppVariable.Value = averagespp;
        consumptionsppVariable.Value = consumptionspp;

        // For Spare
        //targetspareVariable.Value = targetspare;
        // yearlowestspareVariable.Value = yearlowestspare;
        monthlowestspareVariable.Value = monthlowestspare;
        averagespareVariable.Value = averagespare;
        consumptionspareVariable.Value = consumptionspare;


        // For 33KV
        //
        //target33kvVariable.Value = target33kv;
        kv33powerVariable.Value = kv33power;
        monthlowest33kvVariable.Value = monthlowest33kv;
        average33kvVariable.Value = average33kv;
        consumption33kvVariable.Value = consumption33kv;


        // For Calculation
        utilitypercentageVariable.Value = utilitypercentage;
        stampingpercentageVariable.Value = stampingpercentage;
        tcfpercentageVariable.Value = tcfpercentage;
        bodyshoppercentageVariable.Value = bodyshoppercentage;
        engineshoppercentageVariable.Value = engineshoppercentage;
        paintshoppercentageVariable.Value = paintshoppercentage;
        sparepercentageVariable.Value = sparepercentage;
        spppercentageVariable.Value = spppercentage;

        monthconsumptionVariable.Value = monthconsumption;



    }


}
