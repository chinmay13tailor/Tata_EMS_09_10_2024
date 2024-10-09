#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.DataLogger;
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.NativeUI;
using FTOptix.UI;
using FTOptix.CoreBase;
using FTOptix.Store;
using FTOptix.ODBCStore;
using FTOptix.Report;
using FTOptix.RAEtherNetIP;
using FTOptix.Retentivity;
using FTOptix.CommunicationDriver;
using FTOptix.Core;
using Store = FTOptix.Store;
using System.Text.RegularExpressions;
using FTOptix.SQLiteStore;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Reflection.Emit;
using FTOptix.MicroController;
using System.Threading;
using FTOptix.AuditSigning;
using FTOptix.Alarm;
#endregion

public class LogicForResetProductionAndTarget : BaseNetLogic
{
    private Timer timer;

    public override void Start()
    {
        SchedulePeriodicCheck();
    }

    public override void Stop()
    {
        timer?.Dispose();
        timer = null;
    }

    private void SchedulePeriodicCheck()
    {
        // Check every minute
        TimeSpan interval = TimeSpan.FromMinutes(1);
        timer = new Timer(CheckAndRunTask, null, TimeSpan.Zero, interval);
    }

    private void CheckAndRunTask(object state)
    {
        DateTime currentTime = DateTime.Now;
        if (currentTime.Hour == 0 && currentTime.Minute == 02)
        {
            IncrementDecrementTask();
        }
    }

    private void IncrementDecrementTask()
    {
        var production = Project.Current.GetVariable("Model/Datalogtag/ProductionCount");
        var T33KV = Project.Current.GetVariable("Model/HomePageHistogram/HomePage2/Target33KV");
        var TUtility = Project.Current.GetVariable("Model/HomePageHistogram/HomePage2/TargetUtility");
        var TPump = Project.Current.GetVariable("Model/HomePageHistogram/HomePage2/TargetPumpRoom");
        var TPaint = Project.Current.GetVariable("Model/HomePageHistogram/HomePage2/TargetPaintShop");
        var TBody = Project.Current.GetVariable("Model/HomePageHistogram/HomePage2/TargetBodyshop");
        var TTcf = Project.Current.GetVariable("Model/HomePageHistogram/HomePage2/TargetTCF");
        var TStamping = Project.Current.GetVariable("Model/HomePageHistogram/HomePage2/TargetStamping");
        var TAdmin = Project.Current.GetVariable("Model/HomePageHistogram/HomePage2/TargetAdmin");
        var TSpp = Project.Current.GetVariable("Model/HomePageHistogram/HomePage2/TargetSPP");

        if (production!= null)
        {
            var value = production.RemoteRead();
            Log.Info(value.ToString());
            production.RemoteWrite(0);
        }

        if (T33KV != null)
        {
            var value = T33KV.RemoteRead();
            Log.Info(value.ToString());
            T33KV.RemoteWrite(0);
        }

        if (TUtility != null)
        {
            var value = TUtility.RemoteRead();
            Log.Info(value.ToString());
            TUtility.RemoteWrite(0);
        }

        if (TPump != null)
        {
            var value = TPump.RemoteRead();
            Log.Info(value.ToString());
            TPump.RemoteWrite(0);
        }

        if (TPaint != null)
        {
            var value = TPaint.RemoteRead();
            Log.Info(value.ToString());
            TPaint.RemoteWrite(0);
        }

        if (TBody != null)
        {
            var value = TBody.RemoteRead();
            Log.Info(value.ToString());
            TBody.RemoteWrite(0);
        }

        if (TTcf != null)
        {
            var value = TTcf.RemoteRead();
            Log.Info(value.ToString());
            TTcf.RemoteWrite(0);
        }

        if (TStamping != null)
        {
            var value = TStamping.RemoteRead();
            Log.Info(value.ToString());
            TStamping.RemoteWrite(0);
        }

        if (TAdmin != null)
        {
            var value = TAdmin.RemoteRead();
            Log.Info(value.ToString());
            TAdmin.RemoteWrite(0);
        }

        if (TSpp != null)
        {
            var value = TSpp.RemoteRead();
            Log.Info(value.ToString());
            TSpp.RemoteWrite(0);
        }





    }
}
