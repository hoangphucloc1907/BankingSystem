using Banking.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Controllers
{
    internal class EmployeeController
    {
        private readonly string connectionString;

        public EmployeeController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable LoadEmployeeData()
        {
            string query = "SELECT id, name, role FROM Employee";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }

        public bool Create(Employee employee)
        {
            string query = "INSERT INTO Employee (name, password, role) VALUES (@name, @password, @role)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", employee.Name);
                    command.Parameters.AddWithValue("@password", employee.Password);
                    command.Parameters.AddWithValue("@role", employee.Role);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    }
}
