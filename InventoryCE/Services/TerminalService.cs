using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using InventoryCE.Models;
using InventoryCE.Properties;

namespace InventoryCE.Services
{
    public class TerminalService
    {

        AppRest _terminal = new AppRest();

        public Terminal Get(string projectId)
        {
            return _terminal.Client.Get<Terminal>(string.Concat(Resources.APITerminal, "/?project=", projectId));
        }

    }
}
