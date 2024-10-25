namespace Banking.Views
{
    partial class CustomerView
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
            label1 = new Label();
            txtEmail = new TextBox();
            txtName = new TextBox();
            employeeIdLabel = new Label();
            txtAddress = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dataGridViewCustomer = new DataGridView();
            branchId = new DataGridViewTextBoxColumn();
            branchName = new DataGridViewTextBoxColumn();
            branchAddress = new DataGridViewTextBoxColumn();
            branchCity = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            txtPin = new TextBox();
            label4 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPin);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtCity);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(employeeIdLabel);
            groupBox2.Controls.Add(txtAddress);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2534, 143);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(1763, 57);
            txtCity.Multiline = true;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(300, 61);
            txtCity.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(560, 57);
            label1.Name = "label1";
            label1.Size = new Size(157, 72);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(736, 57);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 61);
            txtEmail.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(202, 57);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 61);
            txtName.TabIndex = 4;
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Font = new Font("Segoe UI", 20F);
            employeeIdLabel.Location = new Point(33, 46);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new Size(172, 72);
            employeeIdLabel.TabIndex = 0;
            employeeIdLabel.Text = "Name";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(1299, 57);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 61);
            txtAddress.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(1071, 57);
            label2.Name = "label2";
            label2.Size = new Size(222, 72);
            label2.TabIndex = 2;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(1637, 46);
            label3.Name = "label3";
            label3.Size = new Size(120, 72);
            label3.TabIndex = 3;
            label3.Text = "City";
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Columns.AddRange(new DataGridViewColumn[] { branchId, branchName, branchAddress, branchCity });
            dataGridViewCustomer.Dock = DockStyle.Fill;
            dataGridViewCustomer.Location = new Point(0, 143);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersWidth = 82;
            dataGridViewCustomer.Size = new Size(2534, 1386);
            dataGridViewCustomer.TabIndex = 16;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 1379);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2534, 150);
            groupBox1.TabIndex = 17;
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
            // 
            // txtPin
            // 
            txtPin.Location = new Point(2209, 57);
            txtPin.Multiline = true;
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(300, 61);
            txtPin.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(2083, 46);
            label4.Name = "label4";
            label4.Size = new Size(104, 72);
            label4.TabIndex = 12;
            label4.Text = "Pin";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewCustomer);
            Controls.Add(groupBox2);
            Name = "CustomerView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerView";
            WindowState = FormWindowState.Maximized;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txtCity;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label employeeIdLabel;
        private TextBox txtAddress;
        private Label label2;
        private Label label3;
        private DataGridView dataGridViewCustomer;
        private DataGridViewTextBoxColumn branchId;
        private DataGridViewTextBoxColumn branchName;
        private DataGridViewTextBoxColumn branchAddress;
        private DataGridViewTextBoxColumn branchCity;
        private GroupBox groupBox1;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtPin;
        private Label label4;
    }
}