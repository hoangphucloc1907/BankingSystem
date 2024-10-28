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
            txtPhone = new TextBox();
            label5 = new Label();
            txtPin = new TextBox();
            label4 = new Label();
            txtCity = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            txtName = new TextBox();
            employeeIdLabel = new Label();
            txtAddress = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dataGridViewCustomer = new DataGridView();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(label5);
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
            groupBox2.Size = new Size(2534, 238);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(1694, 68);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(300, 61);
            txtPhone.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(1488, 57);
            label5.Name = "label5";
            label5.Size = new Size(182, 72);
            label5.TabIndex = 14;
            label5.Text = "Phone";
            // 
            // txtPin
            // 
            txtPin.Location = new Point(1694, 148);
            txtPin.Multiline = true;
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(300, 61);
            txtPin.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(1488, 137);
            label4.Name = "label4";
            label4.Size = new Size(104, 72);
            label4.TabIndex = 12;
            label4.Text = "Pin";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(1072, 148);
            txtCity.Multiline = true;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(300, 61);
            txtCity.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(108, 148);
            label1.Name = "label1";
            label1.Size = new Size(157, 72);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(313, 148);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 61);
            txtEmail.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(313, 57);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 61);
            txtName.TabIndex = 4;
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Font = new Font("Segoe UI", 20F);
            employeeIdLabel.Location = new Point(108, 46);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new Size(172, 72);
            employeeIdLabel.TabIndex = 0;
            employeeIdLabel.Text = "Name";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(1072, 68);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 61);
            txtAddress.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(812, 57);
            label2.Name = "label2";
            label2.Size = new Size(222, 72);
            label2.TabIndex = 2;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(812, 137);
            label3.Name = "label3";
            label3.Size = new Size(120, 72);
            label3.TabIndex = 3;
            label3.Text = "City";
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Dock = DockStyle.Fill;
            dataGridViewCustomer.Location = new Point(0, 238);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersVisible = false;
            dataGridViewCustomer.RowHeadersWidth = 82;
            dataGridViewCustomer.Size = new Size(2534, 1291);
            dataGridViewCustomer.TabIndex = 16;
            dataGridViewCustomer.CellClick += dataGridViewCustomer_CellClick;
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
        private GroupBox groupBox1;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtPin;
        private Label label4;
        private TextBox txtPhone;
        private Label label5;
    }
}