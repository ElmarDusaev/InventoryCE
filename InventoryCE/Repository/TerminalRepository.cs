using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using InventoryCE.Models;
using System.Data.SQLite;

namespace InventoryCE.Repository
{
    public class TerminalRepository
    {
        const string INSERT_TERMINAL = @"INSERT INTO terminal(project_id, count, next, previous) VALUES(@project_id, @count, @next, @previous);";
        const string INSERT_TERMINAL_DETAIL = @"INSERT INTO terminal_details(terminal_idkey, id, number, ip_address, db_loading, last_connect) VALUES(@terminal_idkey, @id, @number, @ip_address, @db_loading, @last_connect);";
        const string INSERT_TERMINAL_EMPLOYEE = @"INSERT INTO terminal_employee(terminal_idkey, id, serial_number, username, roles) VALUES(@terminal_idkey, @id, @serial_number, @username, @roles);";


        public int SaveTerminal(Terminal terminal, int projectId)
        {
            using (SQLiteConnection connection = AppSQLConnection.GetSqlConnection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(INSERT_TERMINAL, connection))
                {
                    command.Parameters.AddWithValue("@project_id", projectId);
                    command.Parameters.AddWithValue("@count", terminal.count);
                    command.Parameters.AddWithValue("@next", terminal.next);
                    command.Parameters.AddWithValue("@previous", terminal.previous);
                    command.Parameters.AddWithValue("@created_at", DateTime.Now);
                    command.ExecuteNonQuery();
                    command.CommandText = "SELECT last_insert_rowid()";
                    var result = Convert.ToInt32(command.ExecuteScalar());
                    return result;
                }
            }
        }

        public void SaveTerminalDetails(int terminalId, IEnumerable<TerminalDetail> terminals)
        {
            using (SQLiteConnection connection = AppSQLConnection.GetSqlConnection())
            {
                connection.Open();
                using (SQLiteTransaction tran = connection.BeginTransaction())
                {
                    using (SQLiteCommand command = new SQLiteCommand(INSERT_TERMINAL_DETAIL, connection, tran))
                    {
                        foreach (var item in terminals)
                        {
                            command.Parameters.AddWithValue("@terminal_idkey", terminalId);
                            command.Parameters.AddWithValue("@id", item.id);
                            command.Parameters.AddWithValue("@number", item.number);
                            command.Parameters.AddWithValue("@ip_address", item.ip_address);
                            command.Parameters.AddWithValue("@db_loading", item.db_loading);
                            command.Parameters.AddWithValue("@last_connect", item.last_connect);
                            command.ExecuteNonQuery();
                            command.Parameters.Clear();
                        }
                    }
                    tran.Commit();
                }
            }
        }

        public void SaveTerminalEmployee(int terminalId, TerminalEmployee employee)
        {
            using (SQLiteConnection connection = AppSQLConnection.GetSqlConnection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(INSERT_TERMINAL_EMPLOYEE, connection))
                {
                    command.Parameters.AddWithValue("@terminal_idkey", terminalId);
                    command.Parameters.AddWithValue("@id", employee.id);
                    command.Parameters.AddWithValue("@serial_number", employee.serial_number);
                    command.Parameters.AddWithValue("@username", employee.username);
                    command.Parameters.AddWithValue("@roles", string.Join(",", employee.roles));
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
