using Banking.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Utils;

namespace Banking.Controllers
{
    internal class AccountController : IController
    {
        private readonly DatabaseHelper _databaseHelper;

        public AccountController()
        {
            _databaseHelper = new DatabaseHelper();
            Items = new List<IModel>();
        }

        public List<IModel> Items { get; private set; }

        public bool Create(IModel model)
        {
            if (model is not Account account) return false;

            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    INSERT INTO Account (AccountNumber, Balance, CreatedAt, CustomerId)
                    VALUES (@AccountNumber, @Balance, @CreatedAt, @CustomerId)", connection);
            command.Parameters.AddWithValue("@AccountNumber", account.AccountNumber);
            command.Parameters.AddWithValue("@Balance", account.Balance);
            command.Parameters.AddWithValue("@CreatedAt", account.CreatedAt);
            command.Parameters.AddWithValue("@CustomerId", account.CustomerId);

            return command.ExecuteNonQuery() > 0;
        }

        public bool Delete(object id)
        {
            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    DELETE FROM Account
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
                    FROM Account
                    WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", (int)id);
            return (int)command.ExecuteScalar() > 0;
        }

        public bool IsExist(IModel model)
        {
            if (model is not Account account) return false;

            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    SELECT COUNT(1)
                    FROM Account
                    WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", account.Id);
            return (int)command.ExecuteScalar() > 0;
        }

        public bool Load()
        {
            Items.Clear();
            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    SELECT Id, AccountNumber, Balance, CreatedAt, CustomerId
                    FROM Account", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(new Account
                {
                    Id = reader.GetInt32(0),
                    AccountNumber = reader.GetString(1),
                    Balance = reader.GetDecimal(2),
                    CreatedAt = reader.GetDateTime(3),
                    CustomerId = reader.GetInt32(4)
                });
            }
            return Items.Count > 0;
        }

        public bool Load(object id)
        {
            var account = Read(id);
            if (account != null)
            {
                Items.Clear();
                Items.Add(account);
                return true;
            }
            return false;
        }

        public IModel Read(object id)
        {
            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    SELECT Id, AccountNumber, Balance, CreatedAt, CustomerId
                    FROM Account
                    WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", (int)id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Account
                {
                    Id = reader.GetInt32(0),
                    AccountNumber = reader.GetString(1),
                    Balance = reader.GetDecimal(2),
                    CreatedAt = reader.GetDateTime(3),
                    CustomerId = reader.GetInt32(4)
                };
            }
            return null;
        }

        public bool Update(IModel model)
        {
            if (model is not Account account) return false;

            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    UPDATE Account
                    SET AccountNumber = @AccountNumber, Balance = @Balance, CreatedAt = @CreatedAt, CustomerId = @CustomerId
                    WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", account.Id);
            command.Parameters.AddWithValue("@AccountNumber", account.AccountNumber);
            command.Parameters.AddWithValue("@Balance", account.Balance);
            command.Parameters.AddWithValue("@CreatedAt", account.CreatedAt);
            command.Parameters.AddWithValue("@CustomerId", account.CustomerId);

            return command.ExecuteNonQuery() > 0;
        }

        public List<Account> GetAccountInfo()
        {
            var accounts = new List<Account>();
            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                SELECT Account.AccountNumber, Account.Balance, Customer.Name AS CustomerName
                FROM Account
                JOIN Customer ON Account.CustomerId = Customer.Id", connection);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                accounts.Add(new Account
                {
                    AccountNumber = reader.GetString(0),
                    Balance = reader.GetDecimal(1),
                    Customer = new Customer 
                    {
                        Name = reader.GetString(2)
                    }
                });
            }
            return accounts;
        }
    }
}
