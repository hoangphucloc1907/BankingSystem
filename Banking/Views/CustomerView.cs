using Banking.Controllers;
using Banking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking.Views
{
    public partial class CustomerView : Form, IView
    {
        private readonly CustomerController _customerController;
        private int _customerId;

        public CustomerView()
        {
            InitializeComponent();
            _customerController = new CustomerController();
            LoadCustomerData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var customer = CreateCustomerFromInput();
                customer.Id = _customerId;

                if (_customerController.Upsert(customer))
                {
                    MessageBox.Show("Customer saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomerData();
                }
                else
                {
                    MessageBox.Show("Failed to save customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_customerId == 0)
            {
                MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (_customerController.Delete(_customerId))
                {
                    MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomerData();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to delete customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void LoadCustomerData()
        {
            try
            {
                _customerController.Load();
                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Name", typeof(string));
                dataTable.Columns.Add("Phone", typeof(string));
                dataTable.Columns.Add("Email", typeof(string));
                dataTable.Columns.Add("Address", typeof(string));
                dataTable.Columns.Add("City", typeof(string));
                dataTable.Columns.Add("Pin", typeof(string));
                int id = 0;

                foreach (var item in _customerController.Items)
                {
                    if (item is Customer customer)
                    {
                        dataTable.Rows.Add(id, customer.Name, customer.Phone, customer.Email, customer.Address, customer.City, customer.Pin);
                        id++;
                    }
                }

                dataGridViewCustomer.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtCity.Text) || string.IsNullOrEmpty(txtPin.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private Customer CreateCustomerFromInput()
        {
            return new Customer
            {
                Name = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                City = txtCity.Text.Trim(),
                Pin = txtPin.Text.Trim()
            };
        }

        private void ClearInputFields()
        {
            _customerId = 0;
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtPin.Clear();
        }

        public void SetDataToText(object item)
        {
            if (item is Customer customer)
            {
                _customerId = customer.Id;
                txtName.Text = customer.Name;
                txtPhone.Text = customer.Phone;
                txtEmail.Text = customer.Email;
                txtAddress.Text = customer.Address;
                txtCity.Text = customer.City;
                txtPin.Text = customer.Pin;
            }
        }

        public void GetDataFromText()
        {
            var customer = new Customer
            {
                Id = _customerId,
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                Pin = txtPin.Text
            };

            if (_customerId == 0)
            {
                _customerController.Create(customer);
            }
            else
            {
                _customerController.Update(customer);
            }
        }

        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewCustomer.Rows[e.RowIndex];

                _customerId = row.Cells[0].Value != DBNull.Value ? Convert.ToInt32(row.Cells[0].Value) : 0;

                txtName.Text = row.Cells[1].Value != DBNull.Value ? row.Cells[1].Value.ToString() : string.Empty;
                txtPhone.Text = row.Cells[2].Value != DBNull.Value ? row.Cells[2].Value.ToString() : string.Empty;
                txtEmail.Text = row.Cells[3].Value != DBNull.Value ? row.Cells[3].Value.ToString() : string.Empty;
                txtAddress.Text = row.Cells[4].Value != DBNull.Value ? row.Cells[4].Value.ToString() : string.Empty;
                txtCity.Text = row.Cells[5].Value != DBNull.Value ? row.Cells[5].Value.ToString() : string.Empty;
                txtPin.Text = row.Cells[6].Value != DBNull.Value ? row.Cells[6].Value.ToString() : string.Empty;
            }
        }

        
    }
}
