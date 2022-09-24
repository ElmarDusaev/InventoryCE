using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SimpleRestClientCF20;
using InventoryCE.Properties;

namespace InventoryCE.Services
{
    public class AppRest
    {
        public RestClient Client { get; set; }
        public static string APIDomain { get; set; }

        public AppRest()
        {
            if (string.IsNullOrEmpty(APIDomain)) APIDomain = Resources.APIDomain;
            Client = new RestClient(APIDomain, string.Empty);
        }

        public AppRest(string apiDomain)
        {
            if (string.IsNullOrEmpty(APIDomain)) APIDomain = Resources.APIDomain; 
            else APIDomain = apiDomain;
            
            Client = new RestClient(APIDomain, string.Empty);
        }

    }
}
