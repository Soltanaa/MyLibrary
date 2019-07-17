namespace MyLibrary.Forms
{
    partial class ReturnBookForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbOrder = new System.Windows.Forms.GroupBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbltotalPrice = new System.Windows.Forms.Label();
            this.btnCloseOrder = new System.Windows.Forms.Button();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgwOrder = new System.Windows.Forms.DataGridView();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.dgwToday = new System.Windows.Forms.DataGridView();
            this.dgwTomorrow = new System.Windows.Forms.DataGridView();
            this.lblTodayreturn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLate = new System.Windows.Forms.Label();
            this.dgwLate = new System.Windows.Forms.DataGridView();
            this.grbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLate)).BeginInit();
            this.SuspendLayout();
            // 
            // grbOrder
            // 
            this.grbOrder.Controls.Add(this.btnQuit);
            this.grbOrder.Controls.Add(this.label7);
            this.grbOrder.Controls.Add(this.lbltotalPrice);
            this.grbOrder.Controls.Add(this.btnCloseOrder);
            this.grbOrder.Controls.Add(this.lblCustomers);
            this.grbOrder.Controls.Add(this.btnSearch);
            this.grbOrder.Controls.Add(this.dgwOrder);
            this.grbOrder.Controls.Add(this.cmbCustomers);
            this.grbOrder.Location = new System.Drawing.Point(31, 2);
            this.grbOrder.Name = "grbOrder";
            this.grbOrder.Size = new System.Drawing.Size(589, 226);
            this.grbOrder.TabIndex = 25;
            this.grbOrder.TabStop = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Blue;
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuit.Location = new System.Drawing.Point(251, 19);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(80, 36);
            this.btnQuit.TabIndex = 30;
            this.btnQuit.Text = "Çıxış";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(61, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "AZN";
            // 
            // lbltotalPrice
            // 
            this.lbltotalPrice.AutoSize = true;
            this.lbltotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lbltotalPrice.Location = new System.Drawing.Point(4, 203);
            this.lbltotalPrice.Name = "lbltotalPrice";
            this.lbltotalPrice.Size = new System.Drawing.Size(13, 13);
            this.lbltotalPrice.TabIndex = 28;
            this.lbltotalPrice.Text = "0";
            // 
            // btnCloseOrder
            // 
            this.btnCloseOrder.BackColor = System.Drawing.Color.Blue;
            this.btnCloseOrder.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCloseOrder.Location = new System.Drawing.Point(361, 19);
            this.btnCloseOrder.Name = "btnCloseOrder";
            this.btnCloseOrder.Size = new System.Drawing.Size(80, 36);
            this.btnCloseOrder.TabIndex = 27;
            this.btnCloseOrder.Text = "Sifarişi bağla";
            this.btnCloseOrder.UseVisualStyleBackColor = false;
            this.btnCloseOrder.Click += new System.EventHandler(this.btnCloseOrder_Click);
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(3, 10);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(37, 13);
            this.lblCustomers.TabIndex = 20;
            this.lblCustomers.Text = "Üzvlər";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Blue;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(138, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 36);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Axtarış";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgwOrder
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrder.Location = new System.Drawing.Point(5, 67);
            this.dgwOrder.Name = "dgwOrder";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgwOrder.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwOrder.Size = new System.Drawing.Size(578, 129);
            this.dgwOrder.TabIndex = 21;
            this.dgwOrder.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwOrder_RowHeaderMouseDoubleClick_1);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(6, 26);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(114, 21);
            this.cmbCustomers.TabIndex = 19;
            // 
            // dgwToday
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwToday.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwToday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwToday.Location = new System.Drawing.Point(28, 272);
            this.dgwToday.Name = "dgwToday";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgwToday.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwToday.Size = new System.Drawing.Size(578, 129);
            this.dgwToday.TabIndex = 31;
            // 
            // dgwTomorrow
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwTomorrow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwTomorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTomorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTomorrow.Location = new System.Drawing.Point(643, 69);
            this.dgwTomorrow.Name = "dgwTomorrow";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgwTomorrow.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgwTomorrow.Size = new System.Drawing.Size(578, 129);
            this.dgwTomorrow.TabIndex = 32;
            // 
            // lblTodayreturn
            // 
            this.lblTodayreturn.AutoSize = true;
            this.lblTodayreturn.ForeColor = System.Drawing.Color.Black;
            this.lblTodayreturn.Location = new System.Drawing.Point(34, 245);
            this.lblTodayreturn.Name = "lblTodayreturn";
            this.lblTodayreturn.Size = new System.Drawing.Size(88, 13);
            this.lblTodayreturn.TabIndex = 31;
            this.lblTodayreturn.Text = "Bu gün ödənişləri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(650, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Sabahkı dənişlər";
            // 
            // lblLate
            // 
            this.lblLate.AutoSize = true;
            this.lblLate.ForeColor = System.Drawing.Color.Black;
            this.lblLate.Location = new System.Drawing.Point(650, 253);
            this.lblLate.Name = "lblLate";
            this.lblLate.Size = new System.Drawing.Size(92, 13);
            this.lblLate.TabIndex = 35;
            this.lblLate.Text = "Gecikən ödənişlər";
            // 
            // dgwLate
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwLate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgwLate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwLate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLate.Location = new System.Drawing.Point(643, 272);
            this.dgwLate.Name = "dgwLate";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgwLate.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgwLate.Size = new System.Drawing.Size(578, 129);
            this.dgwLate.TabIndex = 34;
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1250, 749);
            this.Controls.Add(this.lblLate);
            this.Controls.Add(this.dgwLate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTodayreturn);
            this.Controls.Add(this.dgwTomorrow);
            this.Controls.Add(this.dgwToday);
            this.Controls.Add(this.grbOrder);
            this.Name = "ReturnBookForm";
            this.Text = "ReturnBook";
            this.grbOrder.ResumeLayout(false);
            this.grbOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbltotalPrice;
        private System.Windows.Forms.Button btnCloseOrder;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.DataGridView dgwOrder;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DataGridView dgwToday;
        private System.Windows.Forms.DataGridView dgwTomorrow;
        private System.Windows.Forms.Label lblTodayreturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLate;
        private System.Windows.Forms.DataGridView dgwLate;
    }
}