using CashierApp.DTO;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp.DataAccessor
{
    internal class DatabaseAccessor : IDatabaseAccessor
    {

        private SqlConnectionStringBuilder _sqlBuilder;
        public DatabaseAccessor()
        {
            _sqlBuilder = new SqlConnectionStringBuilder();
        }

        public List<ItemsResult> Read()
        {
            var result = new List<ItemsResult>();
            var sql = "SELECT Id, Name, Price FROM Items";
            try
            {
                _sqlBuilder.DataSource = "(LocalDB)\\MSSQLLocalDB";
                _sqlBuilder.InitialCatalog = "CashierAppDB";

                using (SqlConnection connection = new SqlConnection(_sqlBuilder.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Add(new ItemsResult(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2)));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error executing sql {sql}.", ex);
            }

            return result;
        }
    }
}
