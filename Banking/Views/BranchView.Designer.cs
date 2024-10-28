namespace Banking.Views
{
	partial class BranchView
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
            groupBox2 = new GroupBox();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridViewBranch = new DataGridView();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBranch).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCity);
            groupBox2.Controls.Add(txtAddress);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2534, 143);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 10F);
            txtCity.Location = new Point(1846, 65);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(327, 43);
            txtCity.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(1133, 70);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(327, 43);
            txtAddress.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(348, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(327, 43);
            txtName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(71, 51);
            label1.Name = "label1";
            label1.Size = new Size(260, 54);
            label1.TabIndex = 1;
            label1.Text = "Branch Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(905, 46);
            label2.Name = "label2";
            label2.Size = new Size(222, 72);
            label2.TabIndex = 2;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(1708, 46);
            label3.Name = "label3";
            label3.Size = new Size(120, 72);
            label3.TabIndex = 3;
            label3.Text = "City";
            // 
            // dataGridViewBranch
            // 
            dataGridViewBranch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBranch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBranch.Dock = DockStyle.Fill;
            dataGridViewBranch.Location = new Point(0, 143);
            dataGridViewBranch.Name = "dataGridViewBranch";
            dataGridViewBranch.RowHeadersVisible = false;
            dataGridViewBranch.RowHeadersWidth = 82;
            dataGridViewBranch.Size = new Size(2534, 1386);
            dataGridViewBranch.TabIndex = 15;
            dataGridViewBranch.CellClick += dataGridViewBranch_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 1379);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2534, 150);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Silver;
            btnClear.Location = new Point(812, 53);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(397, 76);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Location = new Point(409, 53);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(397, 76);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.Location = new Point(6, 53);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(397, 76);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // BranchView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewBranch);
            Controls.Add(groupBox2);
            Name = "BranchView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Branch";
            WindowState = FormWindowState.Maximized;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBranch).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
		private Label label1;
		private TextBox textBox4;
		private TextBox textBox1;
		private Label employeeIdLabel;
		private TextBox textBox2;
		private Label label2;
		private Label label3;
		private TextBox textBox3;
		private DataGridView dataGridViewBranch;
        private GroupBox groupBox1;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtCity;
        private TextBox txtAddress;
        private TextBox txtName;
    }
}