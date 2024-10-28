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
    public partial class AccountView : Form, IView
    {
        private readonly AccountController _accountController;
        public AccountView()
        {
            InitializeComponent();
            _accountController = new AccountController();
            LoadAccountData();
        }

        private void LoadAccountData()
        {
            _accountController.Load();
            var dataTable = new DataTable();
            dataTable.Columns.Add("Account Number");
            dataTable.Columns.Add("Balance");
            dataTable.Columns.Add("Created At");
            dataTable.Columns.Add("Customer Id");

            foreach (var item in _accountController.Items)
            {
                if (item is Account account) 
                    dataTable.Rows.Add(account.AccountNumber, account.Balance, account.CreatedAt, account.CustomerId);
            }

            dataGridViewAccount.DataSource = dataTable;
        }

        public void GetDataFromText()
        {
            throw new NotImplementedException();
        }

        public void SetDataToText(object item)
        {
            throw new NotImplementedException();
        }
    }
}
