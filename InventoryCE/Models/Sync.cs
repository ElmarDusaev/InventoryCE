using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace InventoryCE.Models
{

    public class Sync
    {
        public string id { get; set; }
        public DateTime created_at { get; set; }
        public string title { get; set; }
        public string address { get; set; }
        public Manager manager { get; set; }
        public Rmm_Settings rmm_settings { get; set; }
        public Terminal_Settings terminal_settings { get; set; }
        public Employee[] employees { get; set; }
    }

    public class Manager
    {
        public string id { get; set; }
        public string phone { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
    }

    public class Rmm_Settings
    {
        public string id { get; set; }
        public int auto_zones_amount { get; set; }
        public bool password { get; set; }
        public int norm { get; set; }
        public bool extended_tasks { get; set; }
    }

    public class Terminal_Settings
    {
        public string id { get; set; }
        public Issuing_Task issuing_task { get; set; }
        public int length_barcode_pallets { get; set; }
        public bool error_correction { get; set; }
        public string compliance_codes { get; set; }
        public Product_Name product_name { get; set; }
        public Unknown_Barcode unknown_barcode { get; set; }
        public int trimming_barcode { get; set; }
        public Recalculation_Discrepancy recalculation_discrepancy { get; set; }
        public int suspicious_barcodes_amount { get; set; }
        public Check_Dm check_dm { get; set; }
        public Check_Am check_am { get; set; }
    }

    public class Issuing_Task
    {
        public string value { get; set; }
        public string name { get; set; }
    }

    public class Product_Name
    {
        public string value { get; set; }
        public string name { get; set; }
    }

    public class Unknown_Barcode
    {
        public string value { get; set; }
        public string name { get; set; }
    }

    public class Recalculation_Discrepancy
    {
        public string value { get; set; }
        public string name { get; set; }
    }

    public class Check_Dm
    {
        public string value { get; set; }
        public string name { get; set; }
    }

    public class Check_Am
    {
        public string value { get; set; }
        public string name { get; set; }
    }

    public class Employee
    {
        public string id { get; set; }
        public int serial_number { get; set; }
        public string username { get; set; }
        public Role[] roles { get; set; }
        public string terminal { get; set; }
        public Task[] tasks { get; set; }
    }

    public class Role
    {
        public string value { get; set; }
        public string name { get; set; }
    }

    public class Task
    {
        public string id { get; set; }
        public Zone zone { get; set; }
        public Type type { get; set; }
        public Status1 status { get; set; }
        public int result { get; set; }
    }

    public class Zone
    {
        public string id { get; set; }
        public int serial_number { get; set; }
        public string title { get; set; }
        public string storage_name { get; set; }
        public object code { get; set; }
        public Status status { get; set; }
    }

    public class Status
    {
        public string value { get; set; }
        public string name { get; set; }
    }

    public class Type
    {
        public string value { get; set; }
        public string name { get; set; }
    }

    public class Status1
    {
        public string value { get; set; }
        public string name { get; set; }
    }

}
