using Banking.Controllers;
using Banking.Models;
using Banking.Utils;
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
    public partial class EmployeeView : Form, IView
    {
        private readonly EmployeeController _employeeController;
        private int _employeeId;

        public EmployeeView()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-CS11CFJ\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;";
            _employeeController = new EmployeeController(connectionString);
            LoadEmployeeData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string role = checkAdm.Checked ? "Admin" : "Employee";
            Employee newEmployee = new Employee
            {
                Username = txtUsername.Text,
                FullName = txtName.Text,
                Password = txtPass.Text,
                Role = role
            };

            if (_employeeController.Create(newEmployee))
            {
                MessageBox.Show("Employee added successfully!");
                LoadEmployeeData();
            }
            else
            {
                MessageBox.Show("Failed to add employee.");
            }
        }

        private void LoadEmployeeData()
        {
            try
            {
                _employeeController.Load();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("FullName", typeof(string));
                dataTable.Columns.Add("Username", typeof(string));
                dataTable.Columns.Add("Password", typeof(string));
                dataTable.Columns.Add("Role", typeof(string));
                dataTable.Columns.Add("IsDeleted", typeof(bool));

                foreach (Employee employee in _employeeController.Items)
                {
                    dataTable.Rows.Add(employee.Id, employee.FullName, employee.Username, employee.Password, employee.Role, employee.IsDeleted);
                }

                dataGridEmpl.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
        }

        private void dataGridEmpl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row
            {
                DataGridViewRow row = dataGridEmpl.Rows[e.RowIndex];

                _employeeId = Convert.ToInt32(row.Cells[0].Value);
                txtName.Text = row.Cells[1].Value.ToString();
                txtUsername.Text = row.Cells[2].Value.ToString();
                txtPass.Text = row.Cells[3].Value.ToString();

                string role = row.Cells[4].Value.ToString();
                checkAdm.Checked = role == "Admin";
                checkEmp.Checked = role == "Employee";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string role = checkAdm.Checked ? "Admin" : "Employee";

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee employee = new Employee
            {
                Id = _employeeId, // Assuming _employeeId is set correctly when updating an existing employee.
                Username = txtUsername.Text.Trim(),
                FullName = txtName.Text.Trim(),
                Password = txtPass.Text.Trim(),
                Role = role
            };

            // Use Upsert instead of Update
            if (_employeeController.Upsert(employee))
            {
                MessageBox.Show("Employee saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployeeData();
            }
            else
            {
                MessageBox.Show("Failed to save employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _employeeId = 0; 
            txtName.Clear();
            txtUsername.Clear();
            txtPass.Clear();
            checkEmp.Checked = false;
            checkAdm.Checked = false;
        }

        public void SetDataToText(object item)
        {
            if (item is Employee employee)
            {
                txtName.Text = employee.FullName;
                txtUsername.Text = employee.Username;
                txtPass.Text = employee.Password;
                checkAdm.Checked = employee.Role == "Admin";
                checkEmp.Checked = employee.Role == "Employee";
            }
        }

        public void GetDataFromText()
        {
            string role = checkAdm.Checked ? "Admin" : "Employee";
            Employee employee = new Employee
            {
                FullName = txtName.Text,
                Username = txtUsername.Text,
                Password = txtPass.Text,
                Role = role
            };
            // This method can be used to get data from text fields and create/update an employee object.
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_employeeId == 0)
            {
                MessageBox.Show("Please select an employee to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (_employeeController.Delete(_employeeId))
                {
                    MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployeeData();
                    btnClear_Click(sender, e); // Clear the form after deletion
                }
                else
                {
                    MessageBox.Show("Failed to delete employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
