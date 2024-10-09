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

public class RuntimeNetLogic6 : BaseNetLogic
{
   // private IUAVariable nameVariable;
    private IUAVariable counterVariable;
    private IUAVariable dateVariable;

   
    private IUAVariable buttonVariable;
  //  private IUAVariable gbuttonVariable;
    private PeriodicTask periodicTask;

    public override void Start()

    {



        var owner = (Object)LogicObject.Owner;
       // nameVariable = owner.NameVariable;
        counterVariable = owner.CounterVariable;
        dateVariable = owner.DateVariable;
        buttonVariable = owner.ButtonVariable;
        periodicTask = new PeriodicTask(IncrementDecrementTask,1000, LogicObject);
        periodicTask.Start();

        // Insert code to be executed when the user-defined logic is started
    }




    public override void Stop()
    {
        periodicTask.Dispose();
        periodicTask = null;
        // Insert code to be executed when the user-defined logic is stopped
    }

    public void IncrementDecrementTask()
    {
        int counter = counterVariable.Value;
        string date = dateVariable.Value;
        bool button = buttonVariable.Value;
        var project = FTOptix.HMIProject.Project.Current;



        if (button == true)
        {


            RemoteVariableSynchronizer remotevariablesych = new RemoteVariableSynchronizer();
            IUANode varfolder = Project.Current.Get("Model/Datalogtag");
           // var var1 = Project.Current.GetVariable("Model/Folder1/Variable1");
          //  var var2 = Project.Current.GetVariable("Model/Folder1/Variable2");
           // var1.Value = 40;
           // var2.Value = 50;
            foreach (IUAVariable var in varfolder.Children)
            {
                remotevariablesych.Add(var);
            }

          //  var var3 = Project.Current.GetVariable("Model/Folder1/Variable1");
           // var var4 = Project.Current.GetVariable("Model/Folder1/Variable2");

            if (counter <= 210)

            {
                
                DateTime currentTime = DateTime.Now;
                string currentDate = currentTime.ToString("yyyy-MM-dd");
                int currentHour = currentTime.Hour;

                // Calculate start and end times for the current day9
                DateTime startTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0);
              
                var date1 = startTime.ToString("dd-MM-yyyy");
                // Adjust the start time if the current hour is before 8 AM
              

                date = date1;
                counter = counter + 1;


            }

            else 
            {
               
                counter = 0;

            }


        }
        dateVariable.Value = date;
        counterVariable.Value = counter;


    }
}
