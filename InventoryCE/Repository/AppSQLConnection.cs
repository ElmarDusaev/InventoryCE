using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace InventoryCE.Repository
{
    public static class AppSQLConnection
    {
        public static SQLiteConnection GetSqlConnection()
        {
            SQLiteConnection connecntion = new SQLiteConnection();
            connecntion.ConnectionString = string.Concat("Data Source=", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase), @"\InventoryDB.db");
            //connecntion.ConnectionString = @"Data Source=C:\Documents and Settings\Elmar\My Documents\Visual Studio 2008\Projects\InventoryCE\InventoryCE\bin\Debug\InventoryDB.db";
            return connecntion;
        }
    }
}
