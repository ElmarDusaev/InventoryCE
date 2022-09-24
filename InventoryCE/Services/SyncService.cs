using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using InventoryCE.Models;
using InventoryCE.Properties;


namespace InventoryCE.Services
{
    public class SyncService
    {
        AppRest _rest = new AppRest();

        public Sync Get(string project)
        {
            return _rest.Client.Get<Sync>(string.Concat(Resources.APISync, "/?project=", project));
        }
    }
}
