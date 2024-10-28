using Banking.Models;
using Banking.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Banking.Controllers
{
    internal class CustomerController : IController
    {
        private readonly DatabaseHelper _databaseHelper;
        private readonly AccountController _accountController;

        public CustomerController()
        {
            _databaseHelper = new DatabaseHelper();
            _accountController = new AccountController();
            Items = new List<IModel>();
        }

        public List<IModel> Items { get; private set; }

        public bool Create(IModel model)
        {
            if (model is not Customer customer) return false;

            try
            {
                using var connection = _databaseHelper.GetConnection();
                connection.Open();

                // Thêm khách hàng vào cơ sở dữ liệu
                using (var command = new SqlCommand(@"
                INSERT INTO Customer (Name, Phone, Email, Address, City, Pin) 
                VALUES (@Name, @Phone, @Email, @Address, @City, @Pin); 
                SELECT SCOPE_IDENTITY();", connection))
                {
                    command.CommandTimeout = 60; // tăng thời gian chờ nếu cần
                    command.Parameters.AddWithValue("@Name", customer.Name);
                    command.Parameters.AddWithValue("@Phone", customer.Phone);
                    command.Parameters.AddWithValue("@Email", customer.Email);
                    command.Parameters.AddWithValue("@Address", customer.Address);
                    command.Parameters.AddWithValue("@City", customer.City);
                    command.Parameters.AddWithValue("@Pin", customer.Pin);

                    customer.Id = Convert.ToInt32(command.ExecuteScalar());
                }

                // Thêm tài khoản sau khi thêm khách hàng thành công
                var account = new Account
                {
                    AccountNumber = new Random().Next(100000, 999999).ToString(),
                    Balance = 50,
                    CreatedAt = DateTime.Now,
                    CustomerId = customer.Id
                };

                return _accountController.Create(account);
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(object id)
        {
            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    DELETE FROM Customer 
                    WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", (int)id);
            return command.ExecuteNonQuery() > 0;
        }

        public bool IsExist(object id)
        {
            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    SELECT COUNT(1) 
                    FROM Customer 
                    WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", (int)id);
            return (int)command.ExecuteScalar() > 0;
        }

        public bool IsExist(IModel model)
        {
            if (model is not Customer customer) return false;

            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    SELECT COUNT(1) 
                    FROM Customer 
                    WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", customer.Id);
            return (int)command.ExecuteScalar() > 0;
        }

        public bool Load()
        {
            Items.Clear();
            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    SELECT Id, Name, Phone, Email, Address, City, Pin 
                    FROM Customer", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(new Customer
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Phone = reader.GetString(2),
                    Email = reader.GetString(3),
                    Address = reader.GetString(4),
                    City = reader.GetString(5),
                    Pin = reader.GetString(6)
                });
            }
            return Items.Count > 0;
        }

        public bool Load(object id)
        {
            var customer = Read(id);
            if (customer != null)
            {
                Items.Clear();
                Items.Add(customer);
                return true;
            }
            return false;
        }

        public IModel Read(object id)
        {
            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    SELECT Id, Name, Phone, Email, Address, City, Pin 
                    FROM Customer 
                    WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", (int)id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Customer
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Phone = reader.GetString(2),
                    Email = reader.GetString(3),
                    Address = reader.GetString(4),
                    City = reader.GetString(5),
                    Pin = reader.GetString(6)
                };
            }
            return null;
        }

        public bool Update(IModel model)
        {
            if (model is not Customer customer) return false;

            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    UPDATE Customer 
                    SET Name = @Name, Phone = @Phone, Email = @Email, Address = @Address, City = @City, Pin = @Pin 
                    WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", customer.Id);
            command.Parameters.AddWithValue("@Name", customer.Name);
            command.Parameters.AddWithValue("@Phone", customer.Phone);
            command.Parameters.AddWithValue("@Email", customer.Email);
            command.Parameters.AddWithValue("@Address", customer.Address);
            command.Parameters.AddWithValue("@City", customer.City);
            command.Parameters.AddWithValue("@Pin", customer.Pin);

            return command.ExecuteNonQuery() > 0;
        }

        public bool Upsert(IModel model)
        {
            if (model is not Customer customer) return false;
            return IsExist(customer) ? Update(customer) : Create(customer);
        }
    }
}