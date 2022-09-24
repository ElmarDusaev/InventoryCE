using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace InventoryCE.Models
{
    public class Terminal
    {
        public int idkey { get; set; }
        public int project_id { get; set; }
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public TerminalDetail[] results { get; set; }
    }

    public class TerminalDetail
    {
        public int idkey { get; set; }
        public int terminal_idkey { get; set; }
        public string id { get; set; }
        public int number { get; set; }
        public string ip_address { get; set; }
        public bool db_loading { get; set; }
        public string last_connect { get; set; }
        public TerminalEmployee employee { get; set; }
    }

    public class TerminalEmployee
    {
        public int idkey { get; set; }
        public int terminal_idkey { get; set; }
        public string id { get; set; }
        public int serial_number { get; set; }
        public string username { get; set; }
        public string[] roles { get; set; }
    }

}
