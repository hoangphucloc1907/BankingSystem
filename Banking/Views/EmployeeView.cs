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
            _employeeController = new EmployeeController();
            LoadEmployeeData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var newEmployee = CreateEmployeeFromInput();
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
        }

        private void LoadEmployeeData()
        {
            try
            {
                _employeeController.Load();
                var dataTable = new DataTable();
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
            if (e.RowIndex >= 0)
            {
                var row = dataGridEmpl.Rows[e.RowIndex];
                _employeeId = Convert.ToInt32(row.Cells[0].Value);
                txtName.Text = row.Cells[1].Value.ToString();
                txtUsername.Text = row.Cells[2].Value.ToString();
                txtPass.Text = row.Cells[3].Value.ToString();
                checkAdm.Checked = row.Cells[4].Value.ToString() == "Admin";
                checkEmp.Checked = row.Cells[4].Value.ToString() == "Employee";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var employee = CreateEmployeeFromInput();
                employee.Id = _employeeId;

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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
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
            var employee = CreateEmployeeFromInput();
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
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to delete employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private Employee CreateEmployeeFromInput()
        {
            return new Employee
            {
                Username = txtUsername.Text.Trim(),
                FullName = txtName.Text.Trim(),
                Password = txtPass.Text.Trim(),
                Role = checkAdm.Checked ? "Admin" : "Employee"
            };
        }

        private void ClearInputFields()
        {
            _employeeId = 0;
            txtName.Clear();
            txtUsername.Clear();
            txtPass.Clear();
            checkEmp.Checked = false;
            checkAdm.Checked = false;
        }
    }
}
