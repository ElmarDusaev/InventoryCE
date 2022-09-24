using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace InventoryCE.Models
{
    public class Project
    {
        public int idkey { get; set; }
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public ProjectResult[] results { get; set; }
    }

    public class ProjectResult
    {
        public int idkey { get; set; }
        public int project_idkey { get; set; }
        public string id { get; set; }
        public string created_at { get; set; }
        public string title { get; set; }
        public string address { get; set; }
    }
}
