namespace Banking.Views
{
    partial class TransactionView
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
            contentTxt = new TextBox();
            label8 = new Label();
            tgAccNameTxt = new TextBox();
            label7 = new Label();
            tgAccNumberCb = new ComboBox();
            label6 = new Label();
            srcNameTxt = new TextBox();
            label1 = new Label();
            label5 = new Label();
            srcAccNumberCb = new ComboBox();
            amountTxt = new TextBox();
            label2 = new Label();
            srcBalanceTxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            saveBtn = new Button();
            closeBtn = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(contentTxt);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tgAccNameTxt);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tgAccNumberCb);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(srcNameTxt);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(srcAccNumberCb);
            groupBox2.Controls.Add(amountTxt);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(srcBalanceTxt);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(505, 411);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1239, 449);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // contentTxt
            // 
            contentTxt.Location = new Point(872, 255);
            contentTxt.Name = "contentTxt";
            contentTxt.Size = new Size(242, 39);
            contentTxt.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(587, 262);
            label8.Name = "label8";
            label8.Size = new Size(100, 32);
            label8.TabIndex = 15;
            label8.Text = "Content";
            // 
            // tgAccNameTxt
            // 
            tgAccNameTxt.Location = new Point(872, 185);
            tgAccNameTxt.Name = "tgAccNameTxt";
            tgAccNameTxt.Size = new Size(242, 39);
            tgAccNameTxt.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(587, 188);
            label7.Name = "label7";
            label7.Size = new Size(244, 32);
            label7.TabIndex = 14;
            label7.Text = "Target Account Name";
            // 
            // tgAccNumberCb
            // 
            tgAccNumberCb.FormattingEnabled = true;
            tgAccNumberCb.Location = new Point(302, 180);
            tgAccNumberCb.Name = "tgAccNumberCb";
            tgAccNumberCb.Size = new Size(242, 40);
            tgAccNumberCb.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 180);
            label6.Name = "label6";
            label6.Size = new Size(268, 32);
            label6.TabIndex = 11;
            label6.Text = "Target Account Number";
            // 
            // srcNameTxt
            // 
            srcNameTxt.Location = new Point(872, 38);
            srcNameTxt.Name = "srcNameTxt";
            srcNameTxt.Size = new Size(242, 39);
            srcNameTxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(276, 32);
            label1.TabIndex = 0;
            label1.Text = "Source Account Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(587, 38);
            label5.Name = "label5";
            label5.Size = new Size(252, 32);
            label5.TabIndex = 10;
            label5.Text = "Source Account Name";
            // 
            // srcAccNumberCb
            // 
            srcAccNumberCb.FormattingEnabled = true;
            srcAccNumberCb.Location = new Point(302, 38);
            srcAccNumberCb.Name = "srcAccNumberCb";
            srcAccNumberCb.Size = new Size(242, 40);
            srcAccNumberCb.TabIndex = 1;
            // 
            // amountTxt
            // 
            amountTxt.Location = new Point(302, 255);
            amountTxt.Name = "amountTxt";
            amountTxt.Size = new Size(242, 39);
            amountTxt.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 109);
            label2.Name = "label2";
            label2.Size = new Size(270, 32);
            label2.TabIndex = 1;
            label2.Text = "Source Account Balance";
            // 
            // srcBalanceTxt
            // 
            srcBalanceTxt.Location = new Point(302, 109);
            srcBalanceTxt.Name = "srcBalanceTxt";
            srcBalanceTxt.Size = new Size(242, 39);
            srcBalanceTxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 262);
            label3.Name = "label3";
            label3.Size = new Size(191, 32);
            label3.TabIndex = 2;
            label3.Text = "Transfer Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 30F);
            label4.Location = new Point(900, 199);
            label4.Name = "label4";
            label4.Size = new Size(444, 106);
            label4.TabIndex = 3;
            label4.Text = "Transaction";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(saveBtn);
            groupBox1.Controls.Add(closeBtn);
            groupBox1.Location = new Point(944, 886);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 113);
            groupBox1.TabIndex = 11;
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
            // TransactionView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Name = "TransactionView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransactionView";
            WindowState = FormWindowState.Maximized;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Label label4;
        private TextBox srcNameTxt;
        private Label label1;
        private Label label5;
        private ComboBox srcAccNumberCb;
        private TextBox amountTxt;
        private Label label2;
        private TextBox srcBalanceTxt;
        private Label label3;
        private TextBox tgAccNameTxt;
        private Label label7;
        private ComboBox tgAccNumberCb;
        private Label label6;
        private GroupBox groupBox1;
        private Button saveBtn;
        private Button closeBtn;
        private TextBox contentTxt;
        private Label label8;
    }
}