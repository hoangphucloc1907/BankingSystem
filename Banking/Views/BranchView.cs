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
    public partial class BranchView : Form, IView
    {
        private readonly BranchController _branchController;
        private int _branchId;

        public BranchView()
        {
            InitializeComponent();
            _branchController = new BranchController();
            LoadBranchData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var branch = CreateBranchFromInput();
                branch.Id = _branchId;

                if (_branchController.Upsert(branch))
                {
                    MessageBox.Show("Branch saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBranchData();
                }
                else
                {
                    MessageBox.Show("Failed to save branch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_branchId == 0)
            {
                MessageBox.Show("Please select a branch to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this branch?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (_branchController.Delete(_branchId))
                {
                    MessageBox.Show("Branch deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBranchData();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to delete branch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void LoadBranchData()
        {
            try
            {
                _branchController.Load();
                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Name", typeof(string));
                dataTable.Columns.Add("Address", typeof(string));
                dataTable.Columns.Add("City", typeof(string));

                int id = 1;
                foreach (var item in _branchController.Items)
                {
                    if (item is Branch branch)
                    {
                        dataTable.Rows.Add(id, branch.Name, branch.Address, branch.City);
                        id++;
                    }
                }

                dataGridViewBranch.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private Branch CreateBranchFromInput()
        {
            return new Branch
            {
                Name = txtName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                City = txtCity.Text.Trim()
            };
        }

        private void ClearInputFields()
        {
            _branchId = 0;
            txtName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
        }

        public void SetDataToText(object item)
        {
            throw new NotImplementedException();
        }

        public void GetDataFromText()
        {
            throw new NotImplementedException();
        }

        private void dataGridViewBranch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var row = dataGridViewBranch.Rows[e.RowIndex];

                _branchId = row.Cells[0].Value != DBNull.Value ? Convert.ToInt32(row.Cells[0].Value) : 0;

                txtName.Text = row.Cells[1].Value != DBNull.Value ? row.Cells[1].Value.ToString() : string.Empty;
                txtAddress.Text = row.Cells[2].Value != DBNull.Value ? row.Cells[2].Value.ToString() : string.Empty;
                txtCity.Text = row.Cells[3].Value != DBNull.Value ? row.Cells[3].Value.ToString() : string.Empty;

            }
        }
    }
}
