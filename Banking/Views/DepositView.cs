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
using System.Transactions;
using System.Windows.Forms;

namespace Banking.Views
{
    public partial class DepositView : Form
    {
        private readonly TransactionController _transactionController;
        private readonly AccountController _accountController;

        public DepositView()
        {
            InitializeComponent();
            _transactionController = new TransactionController();
            _accountController = new AccountController();
            LoadAccountNumbers();
        }

        private void LoadAccountNumbers()
        {
            var accountNumbers = _accountController.GetAccountInfo();
            accNumberCb.DataSource = accountNumbers;
            accNumberCb.DisplayMember = "AccountNumber";

            // Gán "Customer.Name" cho accNameTxt nhưng không cho phép chỉnh sửa
            accNameTxt.DataBindings.Add("Text", accountNumbers, "Customer.Name");
            accNameTxt.ReadOnly = true; // Khóa accNameTxt theo mặc định
            accNumberCb.SelectedIndexChanged += accNumberCb_SelectedIndexChanged;
            accNumberCb.SelectedIndex = -1;
        }

        private void accNumberCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accNumberCb.SelectedItem is Account selectedAccount)
            {
                if (string.IsNullOrEmpty(selectedAccount.AccountNumber))
                {
                    // AccountNumber trống, khóa accNameTxt và xóa Text
                    accNameTxt.Text = string.Empty;
                    accNameTxt.ReadOnly = true;
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (accNumberCb.SelectedItem is Account selectedAccount)
            {
                var transaction = new Models.Transaction
                {
                    FromAccountId = selectedAccount.Id,
                    BranchId = GetBranchId(), // Get the logged-in BranchId
                    EmployeeId = GetLoggedInEmployeeId(), // Get the logged-in EmployeeId
                    TransactionType = TransactionType.Deposit,
                    Description = descriptionTxt.Text,
                    Amount = decimal.Parse(amountTxt.Text),
                    DateOfTrans = DateTime.Now
                };

                if (_transactionController.Deposit(transaction))
                {
                    MessageBox.Show("Deposit successful!");
                }
                else
                {
                    MessageBox.Show("Deposit failed.");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid account.");
            }
        }

        private int GetBranchId()
        {
            // Implement logic to get the logged-in BranchId
            return 1; // Placeholder value
        }

        private int GetLoggedInEmployeeId()
        {
            // Implement logic to get the logged-in EmployeeId
            return 1; // Placeholder value
        }
    }
}
