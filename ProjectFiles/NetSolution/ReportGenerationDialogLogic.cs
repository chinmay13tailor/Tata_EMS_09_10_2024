#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.CoreBase;
using FTOptix.NativeUI;
using FTOptix.WebUI;
using FTOptix.UI;
using FTOptix.EventLogger;
using FTOptix.DataLogger;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.ODBCStore;
using FTOptix.Report;
using FTOptix.MicroController;
using FTOptix.Retentivity;
using FTOptix.Alarm;
using FTOptix.CommunicationDriver;
using FTOptix.AuditSigning;
using FTOptix.Core;
using System.Threading;

#endregion

public class ReportGenerationDialogLogic : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }

    [ExportMethod]

   public void Dialog()
    {


 
 //       int Count = 0;
        for (int i = 0; i <= 20; i++)
        {
            if (i > 1 && i < 15)
            {
                Project.Current.GetVariable("Model/Generatepara").Value = "Generating....";

            }

            if (i > 15 && i < 18)
            {
                
                Project.Current.GetVariable("Model/Generatepara").Value = "Generated!!!";

            }

            if ( i == 20)
            {
                
                Project.Current.GetVariable("Model/Generatepara").Value = "";
            }
            Thread.Sleep(500);

        }
       // Thread.Sleep(500);

    }
}
