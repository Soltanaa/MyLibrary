namespace MyLibrary
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.NudCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.dgwOrder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.bnOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grbOrder = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbltotalPrice = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpGetdate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOpenAdmin = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrder)).BeginInit();
            this.grbOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(126, 26);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(114, 21);
            this.cmbBooks.TabIndex = 5;
            // 
            // NudCount
            // 
            this.NudCount.Location = new System.Drawing.Point(246, 27);
            this.NudCount.Name = "NudCount";
            this.NudCount.Size = new System.Drawing.Size(56, 20);
            this.NudCount.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kitab sayı";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(6, 26);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(114, 21);
            this.cmbCustomers.TabIndex = 19;
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(131, 12);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(42, 13);
            this.lblBooks.TabIndex = 16;
            this.lblBooks.Text = "Kitablar";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.ForeColor = System.Drawing.Color.White;
            this.lblCustomers.Location = new System.Drawing.Point(6, 12);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(37, 13);
            this.lblCustomers.TabIndex = 20;
            this.lblCustomers.Text = "Üzvlər";
            // 
            // dgwOrder
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.dgwOrder.Location = new System.Drawing.Point(5, 67);
            this.dgwOrder.Name = "dgwOrder";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgwOrder.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwOrder.Size = new System.Drawing.Size(578, 301);
            this.dgwOrder.TabIndex = 21;
            this.dgwOrder.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwOrder_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ad soyad";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kitablar";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kitab sayi";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Götürmə tarixi";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Geri qaytaris";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Qiymet";
            this.Column5.Name = "Column5";
            // 
            // dtpReturn
            // 
            this.dtpReturn.Location = new System.Drawing.Point(455, 28);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(128, 20);
            this.dtpReturn.TabIndex = 22;
            // 
            // bnOrder
            // 
            this.bnOrder.BackColor = System.Drawing.Color.MidnightBlue;
            this.bnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnOrder.ForeColor = System.Drawing.Color.White;
            this.bnOrder.Location = new System.Drawing.Point(101, 386);
            this.bnOrder.Name = "bnOrder";
            this.bnOrder.Size = new System.Drawing.Size(155, 36);
            this.bnOrder.TabIndex = 12;
            this.bnOrder.Text = "Sifarişi təsdiqlə";
            this.bnOrder.UseVisualStyleBackColor = false;
            this.bnOrder.Click += new System.EventHandler(this.bnOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Geri qaytarış tarixi";
            // 
            // grbOrder
            // 
            this.grbOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbOrder.Controls.Add(this.btnExit);
            this.grbOrder.Controls.Add(this.label7);
            this.grbOrder.Controls.Add(this.lbltotalPrice);
            this.grbOrder.Controls.Add(this.btnDelete);
            this.grbOrder.Controls.Add(this.label1);
            this.grbOrder.Controls.Add(this.dtpGetdate);
            this.grbOrder.Controls.Add(this.lblCustomers);
            this.grbOrder.Controls.Add(this.bnOrder);
            this.grbOrder.Controls.Add(this.label6);
            this.grbOrder.Controls.Add(this.dgwOrder);
            this.grbOrder.Controls.Add(this.cmbCustomers);
            this.grbOrder.Controls.Add(this.cmbBooks);
            this.grbOrder.Controls.Add(this.label3);
            this.grbOrder.Controls.Add(this.lblBooks);
            this.grbOrder.Controls.Add(this.dtpReturn);
            this.grbOrder.Controls.Add(this.NudCount);
            this.grbOrder.Location = new System.Drawing.Point(195, 21);
            this.grbOrder.Name = "grbOrder";
            this.grbOrder.Size = new System.Drawing.Size(590, 428);
            this.grbOrder.TabIndex = 24;
            this.grbOrder.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(273, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 36);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Çıxış";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(66, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "AZN";
            // 
            // lbltotalPrice
            // 
            this.lbltotalPrice.AutoSize = true;
            this.lbltotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lbltotalPrice.Location = new System.Drawing.Point(6, 398);
            this.lbltotalPrice.Name = "lbltotalPrice";
            this.lbltotalPrice.Size = new System.Drawing.Size(13, 13);
            this.lbltotalPrice.TabIndex = 28;
            this.lbltotalPrice.Text = "0";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(445, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 36);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Sifariş sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Götürülmə tarixi";
            // 
            // dtpGetdate
            // 
            this.dtpGetdate.Location = new System.Drawing.Point(316, 28);
            this.dtpGetdate.Name = "dtpGetdate";
            this.dtpGetdate.Size = new System.Drawing.Size(133, 20);
            this.dtpGetdate.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpenAdmin
            // 
            this.btnOpenAdmin.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnOpenAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAdmin.ForeColor = System.Drawing.Color.White;
            this.btnOpenAdmin.Location = new System.Drawing.Point(12, 21);
            this.btnOpenAdmin.Name = "btnOpenAdmin";
            this.btnOpenAdmin.Size = new System.Drawing.Size(155, 36);
            this.btnOpenAdmin.TabIndex = 30;
            this.btnOpenAdmin.Text = "Admin";
            this.btnOpenAdmin.UseVisualStyleBackColor = false;
            this.btnOpenAdmin.Click += new System.EventHandler(this.btnOpenAdmin_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.Location = new System.Drawing.Point(12, 83);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(155, 36);
            this.btnReturnBook.TabIndex = 31;
            this.btnReturnBook.Text = "Kitab Qaytarmaq";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 482);
            this.Controls.Add(this.btnOpenAdmin);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbOrder);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.NudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrder)).EndInit();
            this.grbOrder.ResumeLayout(false);
            this.grbOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txbFullName;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NudCount;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.DataGridView dgwOrder;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Button bnOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpGetdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbltotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOpenAdmin;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnExit;
    }
}

