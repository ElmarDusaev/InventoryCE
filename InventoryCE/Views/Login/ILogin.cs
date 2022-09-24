using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using InventoryCE.Models;

namespace InventoryCE.Views.Login
{
    public interface ILogin
    {
        string ServiceIp { get;set;}
        string ProjectId { get; }
        string ProjectName { get; }
        ProjectResult[] ProjectDataSource { get; set; }
        string AppVersion { set; }
        event EventHandler<EventArgs> OnButtonLoadClick;
        event EventHandler<EventArgs> OnNextClick;
        string LoadProducts { set; }
        bool ActivateButtons { set; }
        int Progress { set; }
        int MaxProgress { set; }
    }
}
