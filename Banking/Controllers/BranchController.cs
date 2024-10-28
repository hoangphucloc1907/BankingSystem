using Banking.Models;
using Banking.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Controllers
{
    internal class BranchController : IController
    {
        private readonly DatabaseHelper _databaseHelper;

        public BranchController()
        {
            _databaseHelper = new DatabaseHelper();
            Items = new List<IModel>();
        }

        public List<IModel> Items { get; private set; }

        public bool Create(IModel model)
        {
            if (model is not Branch branch) return false;

            using var connection = _databaseHelper.GetConnection();
            using var command = new SqlCommand("INSERT INTO Branch (Name, Address, City) VALUES (@Name, @Address, @City)", connection);
            command.Parameters.AddWithValue("@Name", branch.Name);
            command.Parameters.AddWithValue("@Address", branch.Address);
            command.Parameters.AddWithValue("@City", branch.City);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public bool Delete(object id)
        {
            using var connection = _databaseHelper.GetConnection();
            using var command = new SqlCommand("DELETE FROM Branch WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", (int)id);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public bool IsExist(object id)
        {
            using var connection = _databaseHelper.GetConnection();
            using var command = new SqlCommand("SELECT COUNT(*) FROM Branch WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", (int)id);
            connection.Open();
            return (int)command.ExecuteScalar() > 0;
        }

        public bool IsExist(IModel model)
        {
            if (model is not Branch branch) return false;

            using var connection = _databaseHelper.GetConnection();
            using var command = new SqlCommand("SELECT COUNT(*) FROM Branch WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", branch.Id);
            connection.Open();
            return (int)command.ExecuteScalar() > 0;
        }

        public bool Load()
        {
            Items.Clear();
            using var connection = _databaseHelper.GetConnection();
            using var command = new SqlCommand("SELECT * FROM Branch", connection);
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(new Branch
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Address = reader.GetString(2),
                    City = reader.GetString(3)
                });
            }
            return Items.Count > 0;
        }

        public bool Load(object id)
        {
            var branch = Read(id);
            if (branch != null)
            {
                Items.Clear();
                Items.Add(branch);
                return true;
            }
            return false;
        }

        public IModel Read(object id)
        {
            using var connection = _databaseHelper.GetConnection();
            using var command = new SqlCommand("SELECT * FROM Branch WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", (int)id);
            connection.Open();
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Branch
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Address = reader.GetString(2),
                    City = reader.GetString(3)
                };
            }
            return null;
        }

        public bool Update(IModel model)
        {
            if (model is not Branch branch) return false;

            using var connection = _databaseHelper.GetConnection();
            using var command = new SqlCommand("UPDATE Branch SET Name = @Name, Address = @Address, City = @City WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", branch.Id);
            command.Parameters.AddWithValue("@Name", branch.Name);
            command.Parameters.AddWithValue("@Address", branch.Address);
            command.Parameters.AddWithValue("@City", branch.City);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public bool Upsert(IModel model)
        {
            if (model is not Branch branch) return false;

            return IsExist(branch.Id) ? Update(branch) : Create(branch);
        }
    }
}
