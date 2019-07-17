namespace MyLibrary.Forms
{
    partial class LoginForm
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
            this.grbCheckIn = new System.Windows.Forms.GroupBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.btncheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblstar = new System.Windows.Forms.Label();
            this.txbPhonenumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txbfulName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.grbCheckIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCheckIn
            // 
            this.grbCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.grbCheckIn.Controls.Add(this.BtnCancel);
            this.grbCheckIn.Controls.Add(this.btncheck);
            this.grbCheckIn.Controls.Add(this.label2);
            this.grbCheckIn.Controls.Add(this.lblstar);
            this.grbCheckIn.Controls.Add(this.txbPhonenumber);
            this.grbCheckIn.Controls.Add(this.lblPhoneNumber);
            this.grbCheckIn.Controls.Add(this.txbfulName);
            this.grbCheckIn.Controls.Add(this.lblFullName);
            this.grbCheckIn.Location = new System.Drawing.Point(99, 47);
            this.grbCheckIn.Name = "grbCheckIn";
            this.grbCheckIn.Size = new System.Drawing.Size(203, 309);
            this.grbCheckIn.TabIndex = 5;
            this.grbCheckIn.TabStop = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Red;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(10, 242);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(183, 45);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Çıxış";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.Color.Blue;
            this.btncheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.ForeColor = System.Drawing.Color.White;
            this.btncheck.Location = new System.Drawing.Point(10, 158);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(183, 44);
            this.btncheck.TabIndex = 5;
            this.btncheck.Text = "Daxil ol";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(92, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "*";
            // 
            // lblstar
            // 
            this.lblstar.AutoSize = true;
            this.lblstar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstar.ForeColor = System.Drawing.Color.Red;
            this.lblstar.Location = new System.Drawing.Point(111, 27);
            this.lblstar.Name = "lblstar";
            this.lblstar.Size = new System.Drawing.Size(13, 15);
            this.lblstar.TabIndex = 8;
            this.lblstar.Text = "*";
            // 
            // txbPhonenumber
            // 
            this.txbPhonenumber.Location = new System.Drawing.Point(10, 107);
            this.txbPhonenumber.Name = "txbPhonenumber";
            this.txbPhonenumber.Size = new System.Drawing.Size(183, 20);
            this.txbPhonenumber.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(7, 90);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(79, 13);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Mobil Nömrəniz";
            // 
            // txbfulName
            // 
            this.txbfulName.Location = new System.Drawing.Point(10, 44);
            this.txbfulName.Name = "txbfulName";
            this.txbfulName.Size = new System.Drawing.Size(183, 20);
            this.txbfulName.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(7, 27);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(98, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Adınız və Soyadınız";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.grbCheckIn);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.grbCheckIn.ResumeLayout(false);
            this.grbCheckIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCheckIn;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblstar;
        private System.Windows.Forms.TextBox txbPhonenumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txbfulName;
        private System.Windows.Forms.Label lblFullName;
    }
}