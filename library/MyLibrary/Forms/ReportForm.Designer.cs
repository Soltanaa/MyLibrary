namespace MyLibrary.Forms
{
    partial class ReportForm
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
            this.grbOrder = new System.Windows.Forms.GroupBox();
            this.dgwAdminReport = new System.Windows.Forms.DataGridView();
            this.dtpBookingTime = new System.Windows.Forms.DateTimePicker();
            this.dtpPaydate = new System.Windows.Forms.DateTimePicker();
            this.btnSaleInterval = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartdate = new System.Windows.Forms.Label();
            this.btnExportToExcell = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.grbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdminReport)).BeginInit();
            this.SuspendLayout();
            // 
            // grbOrder
            // 
            this.grbOrder.Controls.Add(this.btnQuit);
            this.grbOrder.Controls.Add(this.dgwAdminReport);
            this.grbOrder.Controls.Add(this.dtpBookingTime);
            this.grbOrder.Controls.Add(this.dtpPaydate);
            this.grbOrder.Controls.Add(this.btnSaleInterval);
            this.grbOrder.Controls.Add(this.lblEndDate);
            this.grbOrder.Controls.Add(this.lblStartdate);
            this.grbOrder.Controls.Add(this.btnExportToExcell);
            this.grbOrder.Location = new System.Drawing.Point(12, 29);
            this.grbOrder.Name = "grbOrder";
            this.grbOrder.Size = new System.Drawing.Size(828, 397);
            this.grbOrder.TabIndex = 21;
            this.grbOrder.TabStop = false;
            this.grbOrder.Text = "Hesabat";
            // 
            // dgwAdminReport
            // 
            this.dgwAdminReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAdminReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAdminReport.Location = new System.Drawing.Point(197, 19);
            this.dgwAdminReport.Name = "dgwAdminReport";
            this.dgwAdminReport.Size = new System.Drawing.Size(631, 372);
            this.dgwAdminReport.TabIndex = 5;
            // 
            // dtpBookingTime
            // 
            this.dtpBookingTime.Location = new System.Drawing.Point(6, 56);
            this.dtpBookingTime.Name = "dtpBookingTime";
            this.dtpBookingTime.Size = new System.Drawing.Size(182, 20);
            this.dtpBookingTime.TabIndex = 7;
            // 
            // dtpPaydate
            // 
            this.dtpPaydate.Location = new System.Drawing.Point(9, 120);
            this.dtpPaydate.Name = "dtpPaydate";
            this.dtpPaydate.Size = new System.Drawing.Size(179, 20);
            this.dtpPaydate.TabIndex = 8;
            // 
            // btnSaleInterval
            // 
            this.btnSaleInterval.Location = new System.Drawing.Point(9, 179);
            this.btnSaleInterval.Name = "btnSaleInterval";
            this.btnSaleInterval.Size = new System.Drawing.Size(179, 33);
            this.btnSaleInterval.TabIndex = 9;
            this.btnSaleInterval.Text = "Satış siyahısı";
            this.btnSaleInterval.UseVisualStyleBackColor = true;
            this.btnSaleInterval.Click += new System.EventHandler(this.btnSaleInterval_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(6, 95);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(57, 13);
            this.lblEndDate.TabIndex = 16;
            this.lblEndDate.Text = "Bitmə tarixi";
            // 
            // lblStartdate
            // 
            this.lblStartdate.AutoSize = true;
            this.lblStartdate.Location = new System.Drawing.Point(6, 32);
            this.lblStartdate.Name = "lblStartdate";
            this.lblStartdate.Size = new System.Drawing.Size(77, 13);
            this.lblStartdate.TabIndex = 15;
            this.lblStartdate.Text = "Başlanğıc tarixi";
            // 
            // btnExportToExcell
            // 
            this.btnExportToExcell.Location = new System.Drawing.Point(9, 295);
            this.btnExportToExcell.Name = "btnExportToExcell";
            this.btnExportToExcell.Size = new System.Drawing.Size(179, 33);
            this.btnExportToExcell.TabIndex = 10;
            this.btnExportToExcell.Text = "Excell file";
            this.btnExportToExcell.UseVisualStyleBackColor = true;
            this.btnExportToExcell.Visible = false;
            this.btnExportToExcell.Click += new System.EventHandler(this.btnExportToExcell_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(9, 237);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(179, 33);
            this.btnQuit.TabIndex = 17;
            this.btnQuit.Text = "Çıxış";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.grbOrder);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.grbOrder.ResumeLayout(false);
            this.grbOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdminReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOrder;
        private System.Windows.Forms.DataGridView dgwAdminReport;
        private System.Windows.Forms.DateTimePicker dtpBookingTime;
        private System.Windows.Forms.DateTimePicker dtpPaydate;
        private System.Windows.Forms.Button btnSaleInterval;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartdate;
        private System.Windows.Forms.Button btnExportToExcell;
        private System.Windows.Forms.Button btnQuit;
    }
}