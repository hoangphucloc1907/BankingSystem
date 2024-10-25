namespace Banking.Views
{
    partial class WithdrawView
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
            label4 = new Label();
            accNumberCb = new ComboBox();
            balanceTxt = new TextBox();
            amountTxt = new TextBox();
            saveBtn = new Button();
            closeBtn = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            accNameTxt = new TextBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 275);
            label2.Name = "label2";
            label2.Size = new Size(190, 32);
            label2.TabIndex = 1;
            label2.Text = "Account Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 362);
            label3.Name = "label3";
            label3.Size = new Size(226, 32);
            label3.TabIndex = 2;
            label3.Text = "Withdrawal Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 35);
            label4.Name = "label4";
            label4.Size = new Size(115, 32);
            label4.TabIndex = 3;
            label4.Text = "Withdraw";
            // 
            // accNumberCb
            // 
            accNumberCb.FormattingEnabled = true;
            accNumberCb.Location = new Point(302, 107);
            accNumberCb.Name = "accNumberCb";
            accNumberCb.Size = new Size(242, 40);
            accNumberCb.TabIndex = 1;
            // 
            // balanceTxt
            // 
            balanceTxt.Location = new Point(302, 272);
            balanceTxt.Name = "balanceTxt";
            balanceTxt.Size = new Size(242, 39);
            balanceTxt.TabIndex = 3;
            // 
            // amountTxt
            // 
            amountTxt.Location = new Point(302, 359);
            amountTxt.Name = "amountTxt";
            amountTxt.Size = new Size(242, 39);
            amountTxt.TabIndex = 4;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(saveBtn);
            groupBox1.Controls.Add(closeBtn);
            groupBox1.Location = new Point(1146, 821);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 113);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
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
            // accNameTxt
            // 
            accNameTxt.Location = new Point(302, 175);
            accNameTxt.Name = "accNameTxt";
            accNameTxt.Size = new Size(242, 39);
            accNameTxt.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(accNameTxt);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(accNumberCb);
            groupBox2.Controls.Add(amountTxt);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(balanceTxt);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(937, 366);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(609, 449);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // WithdrawView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "WithdrawView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WithdrawView";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox accNumberCb;
        private TextBox balanceTxt;
        private TextBox amountTxt;
        private Button saveBtn;
        private Button closeBtn;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox accNameTxt;
        private GroupBox groupBox2;
    }
}