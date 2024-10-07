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
	public partial class LoginView : Form
	{
		public LoginView()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Register register = new Register();
			register.Show();
			this.Hide();
		}

		private void Login_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					this.Close();
				}
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Dashboard manage = new Dashboard();
			manage.Show();
			this.Hide();
		}
	}
}
