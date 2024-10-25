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
    public partial class Home : Form
    {
        private bool _isLoggedIn = false;

        public Home()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Home_KeyDown);
            this.KeyPreview = true;
            UpdateMenuItems();
        }

        private void bankingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ensure there's only one LoginView open
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm is LoginView)
                {
                    childForm.Activate();
                    return;
                }
            }

            // Open LoginView if no instance exists
            LoginView login = new LoginView();
            login.MdiParent = this;
            login.LoginSuccessful += OnLoginSuccessful;
            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_isLoggedIn)
            {
                MessageBox.Show("You must login first.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            EmployeeView employee = new EmployeeView();
            employee.MdiParent = this;
            employee.Show();
        }

        private void branchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_isLoggedIn)
            {
                MessageBox.Show("You must login first.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BranchView branch = new BranchView();
            branch.MdiParent = this;
            branch.Show();
        }

        private void OnLoginSuccessful(object sender, EventArgs e)
        {
            _isLoggedIn = true;
            UpdateMenuItems();
        }

        private void UpdateMenuItems()
        {
            loginToolStripMenuItem.Visible = !_isLoggedIn;
            logoutToolStripMenuItem.Visible = _isLoggedIn;

            bankingToolStripMenuItem.Enabled = _isLoggedIn;
            employeeToolStripMenuItem.Enabled = _isLoggedIn;
            branchToolStripMenuItem.Enabled = _isLoggedIn;
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            _isLoggedIn = false;
            UpdateMenuItems();
            MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void withdrawAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WithdrawView withdrawView = new WithdrawView();
            withdrawView.MdiParent = this;
            withdrawView.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositView depositView = new DepositView();
            depositView.MdiParent = this;
            depositView.Show();
        }

        private void transactionAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionView transactionView = new TransactionView();
            transactionView.MdiParent = this;
            transactionView.Show();
        }

        private void transactionLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionLogView transactionLogView = new TransactionLogView();
            transactionLogView.MdiParent = this;
            transactionLogView.Show();
        }
    }
}
