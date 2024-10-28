using Banking.Models;
using Banking.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Banking.Controllers
{
    internal class TransactionController : IController
    {
        private readonly DatabaseHelper _databaseHelper;

        public TransactionController()
        {
            _databaseHelper = new DatabaseHelper();
            Items = new List<IModel>();
        }

        public List<IModel> Items { get; private set; }

        public bool Create(IModel model)
        {
            if (model is not Transaction transaction) return false;

            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    INSERT INTO Transaction (FromAccountId, ToAccountId, BranchId, EmployeeId, TransactionType, Description, Amount, DateOfTrans)
                    VALUES (@FromAccountId, @ToAccountId, @BranchId, @EmployeeId, @TransactionType, @Description, @Amount, @DateOfTrans)", connection);
            command.Parameters.AddWithValue("@FromAccountId", transaction.FromAccountId);
            command.Parameters.AddWithValue("@ToAccountId", transaction.ToAccountId);
            command.Parameters.AddWithValue("@BranchId", transaction.BranchId);
            command.Parameters.AddWithValue("@EmployeeId", transaction.EmployeeId);
            command.Parameters.AddWithValue("@TransactionType", transaction.TransactionType.ToString());
            command.Parameters.AddWithValue("@Description", transaction.Description);
            command.Parameters.AddWithValue("@Amount", transaction.Amount);
            command.Parameters.AddWithValue("@DateOfTrans", transaction.DateOfTrans);

            return command.ExecuteNonQuery() > 0;
        }

        public bool Delete(object id)
        {
            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    DELETE FROM Transaction
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
                    FROM Transaction
                    WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", (int)id);
            return (int)command.ExecuteScalar() > 0;
        }

        public bool IsExist(IModel model)
        {
            if (model is not Transaction transaction) return false;

            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    SELECT COUNT(1)
                    FROM Transaction
                    WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", transaction.Id);
            return (int)command.ExecuteScalar() > 0;
        }

        public bool Load()
        {
            Items.Clear();
            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    SELECT Id, FromAccountId, ToAccountId, BranchId, EmployeeId, TransactionType, Description, Amount, DateOfTrans
                    FROM Transaction", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(new Transaction
                {
                    Id = reader.GetInt32(0),
                    FromAccountId = reader.GetInt32(1),
                    ToAccountId = reader.GetInt32(2),
                    BranchId = reader.GetInt32(3),
                    EmployeeId = reader.GetInt32(4),
                    TransactionType = Enum.Parse<TransactionType>(reader.GetString(5)),
                    Description = reader.GetString(6),
                    Amount = reader.GetDecimal(7),
                    DateOfTrans = reader.GetDateTime(8)
                });
            }
            return Items.Count > 0;
        }

        public bool Load(object id)
        {
            var transaction = Read(id);
            if (transaction != null)
            {
                Items.Clear();
                Items.Add(transaction);
                return true;
            }
            return false;
        }

        public IModel Read(object id)
        {
            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    SELECT Id, FromAccountId, ToAccountId, BranchId, EmployeeId, TransactionType, Description, Amount, DateOfTrans
                    FROM Transaction
                    WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", (int)id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Transaction
                {
                    Id = reader.GetInt32(0),
                    FromAccountId = reader.GetInt32(1),
                    ToAccountId = reader.GetInt32(2),
                    BranchId = reader.GetInt32(3),
                    EmployeeId = reader.GetInt32(4),
                    TransactionType = Enum.Parse<TransactionType>(reader.GetString(5)),
                    Description = reader.GetString(6),
                    Amount = reader.GetDecimal(7),
                    DateOfTrans = reader.GetDateTime(8)
                };
            }
            return null;
        }

        public bool Update(IModel model)
        {
            if (model is not Transaction transaction) return false;

            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    UPDATE Transaction
                    SET FromAccountId = @FromAccountId, ToAccountId = @ToAccountId, BranchId = @BranchId, EmployeeId = @EmployeeId, TransactionType = @TransactionType, Description = @Description, Amount = @Amount, DateOfTrans = @DateOfTrans
                    WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", transaction.Id);
            command.Parameters.AddWithValue("@FromAccountId", transaction.FromAccountId);
            command.Parameters.AddWithValue("@ToAccountId", transaction.ToAccountId);
            command.Parameters.AddWithValue("@BranchId", transaction.BranchId);
            command.Parameters.AddWithValue("@EmployeeId", transaction.EmployeeId);
            command.Parameters.AddWithValue("@TransactionType", transaction.TransactionType.ToString());
            command.Parameters.AddWithValue("@Description", transaction.Description);
            command.Parameters.AddWithValue("@Amount", transaction.Amount);
            command.Parameters.AddWithValue("@DateOfTrans", transaction.DateOfTrans);

            return command.ExecuteNonQuery() > 0;
        }
        
        public bool Withdraw(Transaction transaction)
        {
            if (transaction.Amount <= 0) return false;

            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    INSERT INTO Transaction (FromAccountId, BranchId, EmployeeId, TransactionType, Description, Amount, DateOfTrans)
                    VALUES (@FromAccountId, @BranchId, @EmployeeId, @TransactionType, @Description, @Amount, @DateOfTrans)", connection);
            command.Parameters.AddWithValue("@FromAccountId", transaction.FromAccountId);
            command.Parameters.AddWithValue("@BranchId", transaction.BranchId);
            command.Parameters.AddWithValue("@EmployeeId", transaction.EmployeeId);
            command.Parameters.AddWithValue("@TransactionType", transaction.TransactionType == TransactionType.Withdraw);
            command.Parameters.AddWithValue("@Description", transaction.Description);
            command.Parameters.AddWithValue("@Amount", transaction.Amount);
            command.Parameters.AddWithValue("@DateOfTrans", transaction.DateOfTrans);

            return command.ExecuteNonQuery() > 0;
        }
        
        public bool Deposit(Transaction transaction)
        {
            if (transaction.Amount <= 0) return false;

            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    INSERT INTO Transaction (FromAccountId, BranchId, EmployeeId, TransactionType, Description, Amount, DateOfTrans)
                    VALUES (@FromAccountId, @BranchId, @EmployeeId, @TransactionType, @Description, @Amount, @DateOfTrans)", connection);
            command.Parameters.AddWithValue("@FromAccountId", transaction.FromAccountId);
            command.Parameters.AddWithValue("@BranchId", transaction.BranchId);
            command.Parameters.AddWithValue("@EmployeeId", transaction.EmployeeId);
            command.Parameters.AddWithValue("@TransactionType", transaction.TransactionType == TransactionType.Deposit);
            command.Parameters.AddWithValue("@Description", transaction.Description);
            command.Parameters.AddWithValue("@Amount", transaction.Amount);
            command.Parameters.AddWithValue("@DateOfTrans", transaction.DateOfTrans);

            return command.ExecuteNonQuery() > 0;
        }
        
        public bool Transfer(Transaction transaction)
        {
            if (transaction.Amount <= 0) return false;

            using var connection = _databaseHelper.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"
                    INSERT INTO Transaction (FromAccountId, ToAccountId, BranchId, EmployeeId, TransactionType, Description, Amount, DateOfTrans)
                    VALUES (@FromAccountId, @ToAccountId, @BranchId, @EmployeeId, @TransactionType, @Description, @Amount, @DateOfTrans)", connection);
            command.Parameters.AddWithValue("@FromAccountId", transaction.FromAccountId);
            command.Parameters.AddWithValue("@ToAccountId", transaction.ToAccountId);
            command.Parameters.AddWithValue("@BranchId", transaction.BranchId);
            command.Parameters.AddWithValue("@EmployeeId", transaction.EmployeeId);
            command.Parameters.AddWithValue("@TransactionType", transaction.TransactionType = TransactionType.Transfer);
            command.Parameters.AddWithValue("@Description", transaction.Description);
            command.Parameters.AddWithValue("@Amount", transaction.Amount);
            command.Parameters.AddWithValue("@DateOfTrans", transaction.DateOfTrans);

            return command.ExecuteNonQuery() > 0;
        }

        
    }
}