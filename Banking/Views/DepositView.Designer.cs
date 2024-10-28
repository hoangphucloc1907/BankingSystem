namespace Banking.Views
{
    partial class DepositView
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
            label4 = new Label();
            accNameTxt = new TextBox();
            label1 = new Label();
            label5 = new Label();
            accNumberCb = new ComboBox();
            amountTxt = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            saveBtn = new Button();
            closeBtn = new Button();
            descriptionTxt = new TextBox();
            label2 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(descriptionTxt);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(accNameTxt);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(accNumberCb);
            groupBox2.Controls.Add(amountTxt);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(978, 381);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(609, 449);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 35);
            label4.Name = "label4";
            label4.Size = new Size(96, 32);
            label4.TabIndex = 3;
            label4.Text = "Deposit";
            // 
            // accNameTxt
            // 
            accNameTxt.Location = new Point(302, 175);
            accNameTxt.Name = "accNameTxt";
            accNameTxt.Size = new Size(242, 39);
            accNameTxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 107);
            label1.Name = "label1";
            label1.Size = new Size(196, 32);
            label1.TabIndex = 0;
            label1.Text = "Account Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 175);
            label5.Name = "label5";
            label5.Size = new Size(172, 32);
            label5.TabIndex = 10;
            label5.Text = "Account Name";
            // 
            // accNumberCb
            // 
            accNumberCb.FormattingEnabled = true;
            accNumberCb.Location = new Point(302, 107);
            accNumberCb.Name = "accNumberCb";
            accNumberCb.Size = new Size(242, 40);
            accNumberCb.TabIndex = 1;
            accNumberCb.SelectedIndexChanged += accNumberCb_SelectedIndexChanged;
            // 
            // amountTxt
            // 
            amountTxt.Location = new Point(302, 262);
            amountTxt.Name = "amountTxt";
            amountTxt.Size = new Size(242, 39);
            amountTxt.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 262);
            label3.Name = "label3";
            label3.Size = new Size(189, 32);
            label3.TabIndex = 2;
            label3.Text = "Deposit Amount";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(saveBtn);
            groupBox1.Controls.Add(closeBtn);
            groupBox1.Location = new Point(1187, 847);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 113);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(42, 48);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(150, 46);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(244, 48);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(150, 46);
            closeBtn.TabIndex = 6;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            // 
            // descriptionTxt
            // 
            descriptionTxt.Location = new Point(309, 349);
            descriptionTxt.Name = "descriptionTxt";
            descriptionTxt.Size = new Size(242, 39);
            descriptionTxt.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 349);
            label2.Name = "label2";
            label2.Size = new Size(100, 32);
            label2.TabIndex = 11;
            label2.Text = "Content";
            // 
            // DepositView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "DepositView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DepositView";
            WindowState = FormWindowState.Maximized;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label4;
        private TextBox accNameTxt;
        private Label label1;
        private Label label5;
        private ComboBox accNumberCb;
        private TextBox amountTxt;
        private Label label3;
        private GroupBox groupBox1;
        private Button saveBtn;
        private Button closeBtn;
        private TextBox descriptionTxt;
        private Label label2;
    }
}