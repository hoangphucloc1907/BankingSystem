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
			textBox3 = new TextBox();
			label1 = new Label();
			textBox4 = new TextBox();
			textBox1 = new TextBox();
			employeeIdLabel = new Label();
			textBox2 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			dataGridView1 = new DataGridView();
			groupBox1 = new GroupBox();
			btnClear = new Button();
			btnDelete = new Button();
			btnEdit = new Button();
			btnAdd = new Button();
			branchId = new DataGridViewTextBoxColumn();
			branchName = new DataGridViewTextBoxColumn();
			branchAddress = new DataGridViewTextBoxColumn();
			branchCity = new DataGridViewTextBoxColumn();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(textBox3);
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(textBox4);
			groupBox2.Controls.Add(textBox1);
			groupBox2.Controls.Add(employeeIdLabel);
			groupBox2.Controls.Add(textBox2);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(label3);
			groupBox2.Dock = DockStyle.Top;
			groupBox2.Location = new Point(0, 0);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(2534, 143);
			groupBox2.TabIndex = 14;
			groupBox2.TabStop = false;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(2124, 57);
			textBox3.Multiline = true;
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(300, 61);
			textBox3.TabIndex = 11;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 20F);
			label1.Location = new Point(664, 46);
			label1.Name = "label1";
			label1.Size = new Size(351, 72);
			label1.TabIndex = 1;
			label1.Text = "Branch Name";
			// 
			// textBox4
			// 
			textBox4.Location = new Point(1021, 57);
			textBox4.Multiline = true;
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(300, 61);
			textBox4.TabIndex = 9;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(294, 57);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(300, 61);
			textBox1.TabIndex = 4;
			// 
			// employeeIdLabel
			// 
			employeeIdLabel.AutoSize = true;
			employeeIdLabel.Font = new Font("Segoe UI", 20F);
			employeeIdLabel.Location = new Point(33, 46);
			employeeIdLabel.Name = "employeeIdLabel";
			employeeIdLabel.Size = new Size(255, 72);
			employeeIdLabel.TabIndex = 0;
			employeeIdLabel.Text = "Branch Id";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(1624, 57);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(300, 61);
			textBox2.TabIndex = 10;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 20F);
			label2.Location = new Point(1396, 57);
			label2.Name = "label2";
			label2.Size = new Size(222, 72);
			label2.TabIndex = 2;
			label2.Text = "Address";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 20F);
			label3.Location = new Point(1998, 46);
			label3.Name = "label3";
			label3.Size = new Size(120, 72);
			label3.TabIndex = 3;
			label3.Text = "City";
			// 
			// dataGridView1
			// 
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { branchId, branchName, branchAddress, branchCity });
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.Location = new Point(0, 143);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 82;
			dataGridView1.Size = new Size(2534, 1386);
			dataGridView1.TabIndex = 15;
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
			groupBox1.TabIndex = 16;
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
			// 
			// branchId
			// 
			branchId.HeaderText = "Branch Id";
			branchId.MinimumWidth = 10;
			branchId.Name = "branchId";
			// 
			// branchName
			// 
			branchName.HeaderText = "Branch Name";
			branchName.MinimumWidth = 10;
			branchName.Name = "branchName";
			// 
			// branchAddress
			// 
			branchAddress.HeaderText = "Address";
			branchAddress.MinimumWidth = 10;
			branchAddress.Name = "branchAddress";
			// 
			// branchCity
			// 
			branchCity.HeaderText = "City";
			branchCity.MinimumWidth = 10;
			branchCity.Name = "branchCity";
			// 
			// Branch
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(2534, 1529);
			Controls.Add(groupBox1);
			Controls.Add(dataGridView1);
			Controls.Add(groupBox2);
			Name = "Branch";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Branch";
			WindowState = FormWindowState.Maximized;
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
		private DataGridView dataGridView1;
		private GroupBox groupBox1;
		private Button btnClear;
		private Button btnDelete;
		private Button btnEdit;
		private Button btnAdd;
		private DataGridViewTextBoxColumn branchId;
		private DataGridViewTextBoxColumn branchName;
		private DataGridViewTextBoxColumn branchAddress;
		private DataGridViewTextBoxColumn branchCity;
	}
}