#region Using directives
using System;
using UAManagedCore;
using FTOptix.NetLogic;
using Store = FTOptix.Store;
#endregion

public class RuntimeNetLogic9 : BaseNetLogic
{
    
    private PeriodicTask periodicTask;
    private IUAVariable productioncountVariable;
    public IUAVariable ButtonVariable;
    public override void Start()
    {

        var owner = (ProductionCount1)LogicObject.Owner;

        productioncountVariable = owner.ProductionCountVariable;
    }
    ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////
    public override void Stop()
    {    
    }
    [ExportMethod]
    public void IncrementDecrementTask()
    {
        int production = productioncountVariable.Value;
        var project = FTOptix.HMIProject.Project.Current;
        var myStore = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        DateTime currentTime = DateTime.Now;
        DateTime endTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0).AddDays(-1);
        string new321 = endTime.ToString("yyyy-MM-dd");
        myStore.Query(" UPDATE HomePage SET Production = '" + production + "' WHERE LocalTimestamp BETWEEN '" + new321 + " 0:00:00' AND '" + new321 + " 23:59:59'", out _, out _);
      
    }
}
