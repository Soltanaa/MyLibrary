namespace MyLibrary.Forms
{
    partial class AdminForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnCreateAdmin = new System.Windows.Forms.Button();
            this.btnUpdateAdmin = new System.Windows.Forms.Button();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.grbCheckAdmin = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbAdminName = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.grbCheckAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(26, 118);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(156, 33);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(19, 38);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(171, 20);
            this.txbUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(19, 19);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(19, 61);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(19, 80);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(171, 20);
            this.txbPassword.TabIndex = 3;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(96, 216);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(156, 32);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Çıxış";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnCreateAdmin
            // 
            this.btnCreateAdmin.Location = new System.Drawing.Point(96, 266);
            this.btnCreateAdmin.Name = "btnCreateAdmin";
            this.btnCreateAdmin.Size = new System.Drawing.Size(156, 37);
            this.btnCreateAdmin.TabIndex = 11;
            this.btnCreateAdmin.Text = "Yeni admin yarat";
            this.btnCreateAdmin.UseVisualStyleBackColor = true;
            this.btnCreateAdmin.Click += new System.EventHandler(this.btnCreateAdmin_Click);
            // 
            // btnUpdateAdmin
            // 
            this.btnUpdateAdmin.Location = new System.Drawing.Point(96, 322);
            this.btnUpdateAdmin.Name = "btnUpdateAdmin";
            this.btnUpdateAdmin.Size = new System.Drawing.Size(156, 35);
            this.btnUpdateAdmin.TabIndex = 12;
            this.btnUpdateAdmin.Text = "Yenilə";
            this.btnUpdateAdmin.UseVisualStyleBackColor = true;
            this.btnUpdateAdmin.Click += new System.EventHandler(this.btnUpdateAdmin_Click);
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.Location = new System.Drawing.Point(96, 375);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(156, 36);
            this.btnDeleteAdmin.TabIndex = 13;
            this.btnDeleteAdmin.Text = "Admin sil";
            this.btnDeleteAdmin.UseVisualStyleBackColor = true;
            this.btnDeleteAdmin.Click += new System.EventHandler(this.btnDeleteAdmin_Click);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Location = new System.Drawing.Point(93, 187);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(0, 13);
            this.lblwelcome.TabIndex = 17;
            // 
            // grbCheckAdmin
            // 
            this.grbCheckAdmin.Controls.Add(this.btnDelete);
            this.grbCheckAdmin.Controls.Add(this.cmbAdminName);
            this.grbCheckAdmin.Controls.Add(this.btnUpdate);
            this.grbCheckAdmin.Controls.Add(this.btnSave);
            this.grbCheckAdmin.Controls.Add(this.txbUserName);
            this.grbCheckAdmin.Controls.Add(this.btnLogin);
            this.grbCheckAdmin.Controls.Add(this.lblUserName);
            this.grbCheckAdmin.Controls.Add(this.txbPassword);
            this.grbCheckAdmin.Controls.Add(this.lblPassword);
            this.grbCheckAdmin.Location = new System.Drawing.Point(70, 12);
            this.grbCheckAdmin.Name = "grbCheckAdmin";
            this.grbCheckAdmin.Size = new System.Drawing.Size(210, 157);
            this.grbCheckAdmin.TabIndex = 18;
            this.grbCheckAdmin.TabStop = false;
            this.grbCheckAdmin.Text = "Admin Yoxlanışı";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(26, 118);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 36);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(26, 119);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 36);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbAdminName
            // 
            this.cmbAdminName.FormattingEnabled = true;
            this.cmbAdminName.Location = new System.Drawing.Point(19, 38);
            this.cmbAdminName.Name = "cmbAdminName";
            this.cmbAdminName.Size = new System.Drawing.Size(171, 21);
            this.cmbAdminName.TabIndex = 19;
            this.cmbAdminName.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 118);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(96, 431);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(156, 35);
            this.btnShowReport.TabIndex = 19;
            this.btnShowReport.Text = "Hesabat";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Visible = false;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // AdminForm
            // 
            this.ClientSize = new System.Drawing.Size(349, 485);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.grbCheckAdmin);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.btnDeleteAdmin);
            this.Controls.Add(this.btnUpdateAdmin);
            this.Controls.Add(this.btnCreateAdmin);
            this.Controls.Add(this.btnQuit);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.grbCheckAdmin.ResumeLayout(false);
            this.grbCheckAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnCreateAdmin;
        private System.Windows.Forms.Button btnUpdateAdmin;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.GroupBox grbCheckAdmin;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbAdminName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowReport;
    }
}