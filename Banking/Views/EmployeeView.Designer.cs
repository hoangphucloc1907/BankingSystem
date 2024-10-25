namespace Banking.Views
{
	partial class EmployeeView
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
            employeeIdLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtName = new TextBox();
            txtPass = new TextBox();
            dataGridEmpl = new DataGridView();
            empId = new DataGridViewTextBoxColumn();
            empName = new DataGridViewTextBoxColumn();
            empUsername = new DataGridViewTextBoxColumn();
            empPass = new DataGridViewTextBoxColumn();
            empRole = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            groupBox2 = new GroupBox();
            checkEmp = new RadioButton();
            checkAdm = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridEmpl).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Font = new Font("Segoe UI", 20F);
            employeeIdLabel.Location = new Point(52, 35);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new Size(270, 72);
            employeeIdLabel.TabIndex = 0;
            employeeIdLabel.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(789, 35);
            label1.Name = "label1";
            label1.Size = new Size(420, 72);
            label1.TabIndex = 1;
            label1.Text = "Employee Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(1597, 35);
            label2.Name = "label2";
            label2.Size = new Size(253, 72);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(2201, 46);
            label3.Name = "label3";
            label3.Size = new Size(133, 72);
            label3.TabIndex = 3;
            label3.Text = "Role";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(367, 46);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 61);
            txtUsername.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(1215, 46);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 61);
            txtName.TabIndex = 9;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(1856, 46);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(300, 61);
            txtPass.TabIndex = 10;
            // 
            // dataGridEmpl
            // 
            dataGridEmpl.AllowUserToAddRows = false;
            dataGridEmpl.AllowUserToDeleteRows = false;
            dataGridEmpl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridEmpl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmpl.Columns.AddRange(new DataGridViewColumn[] { empId, empName, empUsername, empPass, empRole });
            dataGridEmpl.Dock = DockStyle.Fill;
            dataGridEmpl.Location = new Point(0, 121);
            dataGridEmpl.Name = "dataGridEmpl";
            dataGridEmpl.RowHeadersVisible = false;
            dataGridEmpl.RowHeadersWidth = 82;
            dataGridEmpl.Size = new Size(2534, 1408);
            dataGridEmpl.TabIndex = 11;
            dataGridEmpl.CellClick += dataGridEmpl_CellClick;
            // 
            // empId
            // 
            empId.DataPropertyName = "Id";
            empId.HeaderText = "Employee Id";
            empId.MinimumWidth = 10;
            empId.Name = "empId";
            // 
            // empName
            // 
            empName.DataPropertyName = "FullName";
            empName.HeaderText = "Employee Name";
            empName.MinimumWidth = 10;
            empName.Name = "empName";
            // 
            // empUsername
            // 
            empUsername.DataPropertyName = "UserName";
            empUsername.HeaderText = "Username";
            empUsername.MinimumWidth = 10;
            empUsername.Name = "empUsername";
            // 
            // empPass
            // 
            empPass.DataPropertyName = "Password";
            empPass.HeaderText = "Password";
            empPass.MinimumWidth = 10;
            empPass.Name = "empPass";
            // 
            // empRole
            // 
            empRole.DataPropertyName = "Role";
            empRole.HeaderText = "Role";
            empRole.MinimumWidth = 10;
            empRole.Name = "empRole";
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
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(812, 53);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(397, 76);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(409, 53);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(397, 76);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(6, 53);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(397, 76);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkEmp);
            groupBox2.Controls.Add(checkAdm);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(txtUsername);
            groupBox2.Controls.Add(employeeIdLabel);
            groupBox2.Controls.Add(txtPass);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2534, 121);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // checkEmp
            // 
            checkEmp.AutoSize = true;
            checkEmp.Location = new Point(2344, 75);
            checkEmp.Name = "checkEmp";
            checkEmp.Size = new Size(150, 36);
            checkEmp.TabIndex = 12;
            checkEmp.TabStop = true;
            checkEmp.Text = "Employee";
            checkEmp.UseVisualStyleBackColor = true;
            // 
            // checkAdm
            // 
            checkAdm.AutoSize = true;
            checkAdm.Location = new Point(2344, 38);
            checkAdm.Name = "checkAdm";
            checkAdm.Size = new Size(115, 36);
            checkAdm.TabIndex = 11;
            checkAdm.TabStop = true;
            checkAdm.Text = "Admin";
            checkAdm.UseVisualStyleBackColor = true;
            // 
            // EmployeeView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(groupBox1);
            Controls.Add(dataGridEmpl);
            Controls.Add(groupBox2);
            Name = "EmployeeView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridEmpl).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label employeeIdLabel;
		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txtUsername;
		private TextBox txtName;
		private TextBox txtPass;
		private DataGridView dataGridEmpl;
		private GroupBox groupBox1;
		private Button btnClear;
		private Button btnDelete;
		private Button btnSave;
		private GroupBox groupBox2;
        private RadioButton checkEmp;
        private RadioButton checkAdm;
        private DataGridViewTextBoxColumn empId;
        private DataGridViewTextBoxColumn empName;
        private DataGridViewTextBoxColumn empUsername;
        private DataGridViewTextBoxColumn empPass;
        private DataGridViewTextBoxColumn empRole;
    }
}