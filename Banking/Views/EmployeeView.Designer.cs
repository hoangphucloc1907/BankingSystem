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
			txtId = new TextBox();
			checkEmp = new CheckBox();
			checkAdm = new CheckBox();
			txtName = new TextBox();
			txtPass = new TextBox();
			dataGridEmpl = new DataGridView();
			groupBox1 = new GroupBox();
			btnClear = new Button();
			btnDelete = new Button();
			btnEdit = new Button();
			btnAdd = new Button();
			groupBox2 = new GroupBox();
			empId = new DataGridViewTextBoxColumn();
			empName = new DataGridViewTextBoxColumn();
			empPass = new DataGridViewTextBoxColumn();
			empRole = new DataGridViewTextBoxColumn();
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
			employeeIdLabel.Size = new Size(309, 72);
			employeeIdLabel.TabIndex = 0;
			employeeIdLabel.Text = "EmployeeId";
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
			label2.Click += label2_Click;
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
			label3.Click += label3_Click;
			// 
			// txtId
			// 
			txtId.Location = new Point(367, 46);
			txtId.Multiline = true;
			txtId.Name = "txtId";
			txtId.Size = new Size(300, 61);
			txtId.TabIndex = 4;
			// 
			// checkEmp
			// 
			checkEmp.AutoSize = true;
			checkEmp.Location = new Point(2350, 48);
			checkEmp.Name = "checkEmp";
			checkEmp.Size = new Size(151, 36);
			checkEmp.TabIndex = 7;
			checkEmp.Text = "Employee";
			checkEmp.UseVisualStyleBackColor = true;
			// 
			// checkAdm
			// 
			checkAdm.AutoSize = true;
			checkAdm.Location = new Point(2350, 90);
			checkAdm.Name = "checkAdm";
			checkAdm.Size = new Size(116, 36);
			checkAdm.TabIndex = 8;
			checkAdm.Text = "Admin";
			checkAdm.UseVisualStyleBackColor = true;
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
			dataGridEmpl.Columns.AddRange(new DataGridViewColumn[] { empId, empName, empPass, empRole });
			dataGridEmpl.Dock = DockStyle.Fill;
			dataGridEmpl.Location = new Point(0, 121);
			dataGridEmpl.Name = "dataGridEmpl";
			dataGridEmpl.RowHeadersWidth = 82;
			dataGridEmpl.Size = new Size(2534, 1408);
			dataGridEmpl.TabIndex = 11;
			dataGridEmpl.CellContentClick += dataGridEmpl_CellContentClick;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnClear);
			groupBox1.Controls.Add(btnDelete);
			groupBox1.Controls.Add(btnEdit);
			groupBox1.Controls.Add(btnAdd);
			groupBox1.Dock = DockStyle.Bottom;
			groupBox1.Location = new Point(0, 1379);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(2534, 150);
			groupBox1.TabIndex = 12;
			groupBox1.TabStop = false;
			// 
			// btnClear
			// 
			btnClear.Location = new Point(1215, 53);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(397, 76);
			btnClear.TabIndex = 3;
			btnClear.Text = "Clear";
			btnClear.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(812, 53);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(397, 76);
			btnDelete.TabIndex = 2;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(409, 53);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(397, 76);
			btnEdit.TabIndex = 1;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(6, 53);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(397, 76);
			btnAdd.TabIndex = 0;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(txtName);
			groupBox2.Controls.Add(txtId);
			groupBox2.Controls.Add(checkAdm);
			groupBox2.Controls.Add(employeeIdLabel);
			groupBox2.Controls.Add(txtPass);
			groupBox2.Controls.Add(checkEmp);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(label3);
			groupBox2.Dock = DockStyle.Top;
			groupBox2.Location = new Point(0, 0);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(2534, 121);
			groupBox2.TabIndex = 13;
			groupBox2.TabStop = false;
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
			empName.DataPropertyName = "Name";
			empName.HeaderText = "Employee Name";
			empName.MinimumWidth = 10;
			empName.Name = "empName";
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
		private TextBox txtId;
		private CheckBox checkEmp;
		private CheckBox checkAdm;
		private TextBox txtName;
		private TextBox txtPass;
		private DataGridView dataGridEmpl;
		private GroupBox groupBox1;
		private Button btnClear;
		private Button btnDelete;
		private Button btnEdit;
		private Button btnAdd;
		private GroupBox groupBox2;
		private DataGridViewTextBoxColumn empId;
		private DataGridViewTextBoxColumn empName;
		private DataGridViewTextBoxColumn empPass;
		private DataGridViewTextBoxColumn empRole;
	}
}