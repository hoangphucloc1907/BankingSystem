using Banking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking.Views
{
	public partial class EmployeeView : Form
	{
		private List<Employee> employees = new List<Employee>();

		public EmployeeView()
		{
			InitializeComponent();
			LoadEmployeeData();	
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string role = checkAdm.Checked ? "Admin" : "Employee";
			Employee newEmployee = new Employee
			{
				Name = txtName.Text,
				Password = txtPass.Text,
				Role = role
			};

			string connectionString = "Data Source=DESKTOP-CS11CFJ\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "INSERT INTO Employee (name, password, role) VALUES (@Name, @Password, @Role)";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Name", newEmployee.Name);
					command.Parameters.AddWithValue("@Password", newEmployee.Password);
					command.Parameters.AddWithValue("@Role", newEmployee.Role);

					connection.Open();
					command.ExecuteNonQuery();
				}
			}

			MessageBox.Show("Employee added successfully!");
			LoadEmployeeData();
		}

		private async void LoadEmployeeData()
		{
			string connectionString = "Data Source=DESKTOP-CS11CFJ\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;";
			string query = "SELECT id, name, role FROM Employee";

			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						await connection.OpenAsync();
						using (SqlDataReader reader = await command.ExecuteReaderAsync())
						{
							DataTable dataTable = new DataTable();
							dataTable.Load(reader);
							dataGridEmpl.DataSource = dataTable; 
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while loading data: {ex.Message}");
			}
		}

		private void dataGridEmpl_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
