using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using InventoryCE.Properties;
using InventoryCE.Models;

namespace InventoryCE.Services
{
    public class ProjecService
    {
        AppRest _project;

        public ProjecService(string apiDomain)
        {
            _project = new AppRest(apiDomain);
        }

        public Project Get()
        {
            return _project.Client.Get<Project>(Resources.APIProject, string.Empty);
        }
    }
}
