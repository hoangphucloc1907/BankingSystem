using Banking.Models;
using Banking.Utils;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using System.Data.SqlClient;


namespace Banking.Controllers
{
    internal class EmployeeController : IController
    {
        private readonly DatabaseHelper _databaseHelper;

        public List<IModel> Items { get; private set; }

        public EmployeeController()
        {
            _databaseHelper = new DatabaseHelper();
            Items = new List<IModel>();
        }

        public bool Create(IModel model)
        {
            if (model is not Employee employee) return false;

            // Hash the password
            var passwordHash = HashPassword(employee.Password);

            using var connection = _databaseHelper.GetConnection();
            using var command = new SqlCommand("INSERT INTO Employee (FullName, Username, Password, Role, IsDeleted) VALUES (@FullName, @Username, @Password, @Role, @IsDeleted)", connection);
            command.Parameters.AddWithValue("@FullName", employee.FullName);
            command.Parameters.AddWithValue("@Username", employee.Username);
            command.Parameters.AddWithValue("@Password", passwordHash);
            command.Parameters.AddWithValue("@Role", employee.Role);
            command.Parameters.AddWithValue("@IsDeleted", employee.IsDeleted);

            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        private string HashPassword(string password)
        {
            var generator = new Pkcs5S2ParametersGenerator();
            generator.Init(PbeParametersGenerator.Pkcs5PasswordToBytes(password.ToCharArray()), new byte[16], 1000);
            var key = (KeyParameter)generator.GenerateDerivedMacParameters(256);
            return Convert.ToBase64String(key.GetKey());
        }

        public bool Update(IModel model)
        {
            if (model is not Employee employee) return false;

            using var connection = _databaseHelper.GetConnection();
            using var command = new SqlCommand("UPDATE Employee SET FullName = @FullName, Username = @Username, Password = @Password, Role = @Role, IsDeleted = @IsDeleted WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", employee.Id);
            command.Parameters.AddWithValue("@FullName", employee.FullName);
            command.Parameters.AddWithValue("@Username", employee.Username);
            command.Parameters.AddWithValue("@Password", employee.Password);
            command.Parameters.AddWithValue("@Role", employee.Role);
            command.Parameters.AddWithValue("@IsDeleted", employee.IsDeleted);

            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public bool Delete(object id)
        {
            using var connection = _databaseHelper.GetConnection();
            using var command = new SqlCommand("DELETE FROM Employee WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);

            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public IModel? Read(object id)
        {
            using var connection = _databaseHelper.GetConnection();
            using var command = new SqlCommand("SELECT * FROM Employee WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);

            connection.Open();
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Employee
                {
                    Id = (int)reader["Id"],
                    FullName = (string)reader["FullName"],
                    Username = (string)reader["Username"],
                    Password = (string)reader["Password"],
                    Role = (string)reader["Role"],
                    IsDeleted = (bool)reader["IsDeleted"]
                };
            }
            return null;
        }

        public bool Load()
        {
            Items.Clear();
            using var connection = _databaseHelper.GetConnection();
            using var command = new SqlCommand("SELECT * FROM Employee", connection);

            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(new Employee
                {
                    Id = (int)reader["Id"],
                    FullName = (string)reader["FullName"],
                    Username = (string)reader["Username"],
                    Password = (string)reader["Password"],
                    Role = (string)reader["Role"],
                    IsDeleted = (bool)reader["IsDeleted"]
                });
            }
            return Items.Count > 0;
        }

        public bool Load(object id)
        {
            var employee = Read(id);
            if (employee != null)
            {
                Items.Clear();
                Items.Add(employee);
                return true;
            }
            return false;
        }

        public bool IsExist(object id)
        {
            using var connection = _databaseHelper.GetConnection();
            using var command = new SqlCommand("SELECT COUNT(*) FROM Employee WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);

            connection.Open();
            return (int)command.ExecuteScalar() > 0;
        }

        public bool IsExist(IModel model)
        {
            if (model is not Employee employee) return false;

            using var connection = _databaseHelper.GetConnection();
            using var command = new SqlCommand("SELECT COUNT(*) FROM Employee WHERE Username = @Username", connection);
            command.Parameters.AddWithValue("@Username", employee.Username);

            connection.Open();
            return (int)command.ExecuteScalar() > 0;
        }

        public int? Login(Employee employee)
        {
            using var connection = _databaseHelper.GetConnection();
            using var command = new SqlCommand("SELECT Id, Password FROM Employee WHERE Username = @Username", connection);
            command.Parameters.AddWithValue("@Username", employee.Username);

            connection.Open();
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                int userId = reader.GetInt32(0);
                string storedPasswordHash = reader.GetString(1);
                if (VerifyPassword(employee.Password, storedPasswordHash))
                {
                    return userId;
                }
            }

            return null;
        }

        private bool VerifyPassword(string password, string storedPasswordHash)
        {
            var generator = new Pkcs5S2ParametersGenerator();
            generator.Init(PbeParametersGenerator.Pkcs5PasswordToBytes(password.ToCharArray()), new byte[16], 1000);
            var key = (KeyParameter)generator.GenerateDerivedMacParameters(256);
            var passwordHash = Convert.ToBase64String(key.GetKey());

            return passwordHash == storedPasswordHash;
        }

        public bool Upsert(IModel model)
        {
            if (model is not Employee employee) return false;

            return IsExist(employee.Id) ? Update(employee) : Create(employee);
        }
    }
}
