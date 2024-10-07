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
		public Home()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(Home_KeyDown);
			this.KeyPreview = true;
		}

		private void bankingToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void loginToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LoginView login = new LoginView();
			login.MdiParent = this;
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
			EmployeeView employee = new EmployeeView();
			employee.MdiParent = this;
			employee.Show();
		}

		private void branchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BranchView branch = new BranchView();
			branch.MdiParent = this;
			branch.Show();
		}
	}
}
