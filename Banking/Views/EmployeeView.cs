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
    public partial class EmployeeView : Form
    {
        private EmployeeController employeeController;

        public EmployeeView()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-CS11CFJ\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;";
            employeeController = new EmployeeController(connectionString);
            LoadEmployeeData();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Event handler logic
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Event handler logic
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

            if (employeeController.Create(newEmployee))
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
                DataTable dataTable = employeeController.LoadEmployeeData();
                dataGridEmpl.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
        }

        private void dataGridEmpl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Event handler logic
        }
    }
}
