namespace Banking.Views
{
    partial class LoginView
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			btnLogin = new Button();
			label4 = new Label();
			linkLabel1 = new LinkLabel();
			panel1 = new Panel();
			panel2 = new Panel();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Font = new Font("Segoe UI", 50F);
			label1.Location = new Point(640, 28);
			label1.Name = "label1";
			label1.Size = new Size(644, 204);
			label1.TabIndex = 0;
			label1.Text = "Login";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 20F);
			label2.Location = new Point(318, 322);
			label2.Name = "label2";
			label2.Size = new Size(162, 72);
			label2.TabIndex = 1;
			label2.Text = "Email";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 20F);
			label3.Location = new Point(318, 498);
			label3.Name = "label3";
			label3.Size = new Size(260, 72);
			label3.TabIndex = 2;
			label3.Text = "Password";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(598, 322);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(617, 76);
			textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(598, 498);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(617, 76);
			textBox2.TabIndex = 4;
			// 
			// btnLogin
			// 
			btnLogin.Font = new Font("Segoe UI Variable Small", 20F);
			btnLogin.Location = new Point(598, 649);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(617, 82);
			btnLogin.TabIndex = 5;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 15F);
			label4.Location = new Point(591, 821);
			label4.Name = "label4";
			label4.Size = new Size(449, 54);
			label4.TabIndex = 6;
			label4.Text = "Don't have an Account?";
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Font = new Font("Segoe UI Semibold", 15F);
			linkLabel1.Location = new Point(1046, 821);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(169, 54);
			linkLabel1.TabIndex = 7;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Register";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveCaption;
			panel1.Controls.Add(panel2);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(2510, 1505);
			panel1.TabIndex = 8;
			// 
			// panel2
			// 
			panel2.BackColor = SystemColors.Control;
			panel2.Controls.Add(linkLabel1);
			panel2.Controls.Add(textBox1);
			panel2.Controls.Add(label4);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(label1);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(btnLogin);
			panel2.Controls.Add(textBox2);
			panel2.Location = new Point(353, 239);
			panel2.Name = "panel2";
			panel2.Size = new Size(1849, 998);
			panel2.TabIndex = 0;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(14F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(2534, 1529);
			Controls.Add(panel1);
			Font = new Font("Segoe UI Semibold", 9F);
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			WindowState = FormWindowState.Maximized;
			KeyDown += Login_KeyDown;
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnLogin;
        private Label label4;
        private LinkLabel linkLabel1;
		private Panel panel1;
		private Panel panel2;
	}
}