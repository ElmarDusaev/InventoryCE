using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using InventoryCE.Models;
using InventoryCE.Common;
using System.Data.SQLite;

namespace InventoryCE.Repository
{
    public class ProductRepository
    {
        const string INSERT_PRODUCTS_HEADER = "INSERT INTO products(project_id, project_name, count, next, created_at) VALUES(@project_id, @project_name, @count, @next, @created_at)";
        const string INSERT_PRODUCTS_DETAILS = "INSERT INTO products_details (products_idkey, id, vendor_code, barcode, title, remainder, price, am, dm) VALUES (@ProductHeaderId, @ProductId, @vendor_code, @barcode, @title, @remainder, @price, @am, @dm)";
        
        public int SaveHeader(Product product, string projectId, string projectName)
        {
            using (SQLiteConnection connection = AppSQLConnection.GetSqlConnection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(INSERT_PRODUCTS_HEADER, connection))
                {
                    command.Parameters.AddWithValue("@project_id", projectId);
                    command.Parameters.AddWithValue("@project_name", projectName);
                    command.Parameters.AddWithValue("@count", product.count);
                    command.Parameters.AddWithValue("@next", string.Empty);
                    command.Parameters.AddWithValue("@created_at", DateTime.Now);
                    command.ExecuteNonQuery();
                    command.CommandText = "SELECT last_insert_rowid()";
                    var result = Convert.ToInt32(command.ExecuteScalar());
                    return result;
                }
            }
        }

        public void SaveDetails(int productHeaderId, IEnumerable<ProductResult> productResult)
        {
            using (SQLiteConnection connection = AppSQLConnection.GetSqlConnection())
            {
                connection.Open();
                using (SQLiteTransaction tran = connection.BeginTransaction())
                {
                    using (SQLiteCommand command = new SQLiteCommand(INSERT_PRODUCTS_DETAILS, connection, tran))
                    {
                        foreach (var item in productResult)
                        {
                            command.Parameters.AddWithValue("@ProductHeaderId", productHeaderId);
                            command.Parameters.AddWithValue("@ProductId", item.id);
                            command.Parameters.AddWithValue("@vendor_code", item.vendor_code);
                            command.Parameters.AddWithValue("@barcode", item.barcode);
                            command.Parameters.AddWithValue("@title", item.title);
                            command.Parameters.AddWithValue("@remainder", item.remainder);
                            command.Parameters.AddWithValue("@price", item.price);
                            command.Parameters.AddWithValue("@am", item.am ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@dm", item.dm ?? (object)DBNull.Value);
                            command.ExecuteNonQuery();
                            command.Parameters.Clear();
                        }
                    }
                    tran.Commit();
                }
            }
        }

    }
}
