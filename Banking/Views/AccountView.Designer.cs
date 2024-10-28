namespace Banking.Views
{
    partial class AccountView
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
            dataGridViewAccount = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAccount
            // 
            dataGridViewAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccount.Dock = DockStyle.Fill;
            dataGridViewAccount.Location = new Point(0, 0);
            dataGridViewAccount.Name = "dataGridViewAccount";
            dataGridViewAccount.RowHeadersVisible = false;
            dataGridViewAccount.RowHeadersWidth = 82;
            dataGridViewAccount.Size = new Size(2534, 1529);
            dataGridViewAccount.TabIndex = 16;
            // 
            // AccountView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(dataGridViewAccount);
            Name = "AccountView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountView";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAccount;
    }
}