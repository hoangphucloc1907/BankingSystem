namespace Banking.Views
{
	partial class Home
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            systemToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            branchToolStripMenuItem = new ToolStripMenuItem();
            bankingToolStripMenuItem = new ToolStripMenuItem();
            createCustomerToolStripMenuItem = new ToolStripMenuItem();
            createAccountToolStripMenuItem = new ToolStripMenuItem();
            depositToolStripMenuItem = new ToolStripMenuItem();
            withdrawAmountToolStripMenuItem = new ToolStripMenuItem();
            transactionAmountToolStripMenuItem = new ToolStripMenuItem();
            balanceAccountToolStripMenuItem = new ToolStripMenuItem();
            transactionLogToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, systemToolStripMenuItem, bankingToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2534, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 38);
            fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(229, 44);
            loginToolStripMenuItem.Text = "Log in";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(229, 44);
            logoutToolStripMenuItem.Text = "Log out";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click_1;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(229, 44);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { employeeToolStripMenuItem, branchToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(110, 38);
            systemToolStripMenuItem.Text = "System";
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(252, 44);
            employeeToolStripMenuItem.Text = "Employee";
            employeeToolStripMenuItem.Click += employeeToolStripMenuItem_Click;
            // 
            // branchToolStripMenuItem
            // 
            branchToolStripMenuItem.Name = "branchToolStripMenuItem";
            branchToolStripMenuItem.Size = new Size(252, 44);
            branchToolStripMenuItem.Text = "Branch";
            branchToolStripMenuItem.Click += branchToolStripMenuItem_Click;
            // 
            // bankingToolStripMenuItem
            // 
            bankingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createCustomerToolStripMenuItem, createAccountToolStripMenuItem, depositToolStripMenuItem, withdrawAmountToolStripMenuItem, transactionAmountToolStripMenuItem, balanceAccountToolStripMenuItem, transactionLogToolStripMenuItem });
            bankingToolStripMenuItem.Name = "bankingToolStripMenuItem";
            bankingToolStripMenuItem.Size = new Size(120, 38);
            bankingToolStripMenuItem.Text = "Banking";
            bankingToolStripMenuItem.Click += bankingToolStripMenuItem_Click;
            // 
            // createCustomerToolStripMenuItem
            // 
            createCustomerToolStripMenuItem.Name = "createCustomerToolStripMenuItem";
            createCustomerToolStripMenuItem.Size = new Size(360, 44);
            createCustomerToolStripMenuItem.Text = "Create Customer";
            createCustomerToolStripMenuItem.Click += createCustomerToolStripMenuItem_Click;
            // 
            // createAccountToolStripMenuItem
            // 
            createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            createAccountToolStripMenuItem.Size = new Size(360, 44);
            createAccountToolStripMenuItem.Text = "Create Account";
            createAccountToolStripMenuItem.Click += createAccountToolStripMenuItem_Click;
            // 
            // depositToolStripMenuItem
            // 
            depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            depositToolStripMenuItem.Size = new Size(360, 44);
            depositToolStripMenuItem.Text = "Deposit Amount";
            depositToolStripMenuItem.Click += depositToolStripMenuItem_Click;
            // 
            // withdrawAmountToolStripMenuItem
            // 
            withdrawAmountToolStripMenuItem.Name = "withdrawAmountToolStripMenuItem";
            withdrawAmountToolStripMenuItem.Size = new Size(360, 44);
            withdrawAmountToolStripMenuItem.Text = "Withdraw Amount";
            withdrawAmountToolStripMenuItem.Click += withdrawAmountToolStripMenuItem_Click;
            // 
            // transactionAmountToolStripMenuItem
            // 
            transactionAmountToolStripMenuItem.Name = "transactionAmountToolStripMenuItem";
            transactionAmountToolStripMenuItem.Size = new Size(360, 44);
            transactionAmountToolStripMenuItem.Text = "Transaction Amount";
            transactionAmountToolStripMenuItem.Click += transactionAmountToolStripMenuItem_Click;
            // 
            // balanceAccountToolStripMenuItem
            // 
            balanceAccountToolStripMenuItem.Name = "balanceAccountToolStripMenuItem";
            balanceAccountToolStripMenuItem.Size = new Size(360, 44);
            balanceAccountToolStripMenuItem.Text = "Balance Account";
            // 
            // transactionLogToolStripMenuItem
            // 
            transactionLogToolStripMenuItem.Name = "transactionLogToolStripMenuItem";
            transactionLogToolStripMenuItem.Size = new Size(360, 44);
            transactionLogToolStripMenuItem.Text = "Transaction log";
            transactionLogToolStripMenuItem.Click += transactionLogToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(84, 38);
            helpToolStripMenuItem.Text = "Help";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(275, 44);
            userToolStripMenuItem.Text = "User guilde ";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(275, 44);
            aboutToolStripMenuItem.Text = "About";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banking System";
            WindowState = FormWindowState.Maximized;
            KeyDown += Home_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem loginToolStripMenuItem;
		private ToolStripMenuItem logoutToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem systemToolStripMenuItem;
		private ToolStripMenuItem employeeToolStripMenuItem;
		private ToolStripMenuItem branchToolStripMenuItem;
		private ToolStripMenuItem bankingToolStripMenuItem;
		private ToolStripMenuItem createCustomerToolStripMenuItem;
		private ToolStripMenuItem createAccountToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem depositToolStripMenuItem;
		private ToolStripMenuItem withdrawAmountToolStripMenuItem;
		private ToolStripMenuItem transactionAmountToolStripMenuItem;
		private ToolStripMenuItem balanceAccountToolStripMenuItem;
		private ToolStripMenuItem transactionLogToolStripMenuItem;
		private ToolStripMenuItem userToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
	}
}