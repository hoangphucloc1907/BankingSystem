﻿namespace Banking.Views
{
    partial class TransactionLogView
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
            dataGridViewTransLog = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransLog).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTransLog
            // 
            dataGridViewTransLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransLog.Dock = DockStyle.Fill;
            dataGridViewTransLog.Location = new Point(0, 0);
            dataGridViewTransLog.Name = "dataGridViewTransLog";
            dataGridViewTransLog.RowHeadersWidth = 82;
            dataGridViewTransLog.Size = new Size(2534, 1529);
            dataGridViewTransLog.TabIndex = 0;
            // 
            // TransactionLogView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(dataGridViewTransLog);
            Name = "TransactionLogView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransactionLogView";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTransLog;
    }
}