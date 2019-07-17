using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary.Models;
using MyLibrary.DAL;
using MyLibrary.Forms;
using System.Globalization;

namespace MyLibrary.Forms
{
    public partial class AdminForm : Form
    {
        private readonly DAL.LibraryContext _context;

        public AdminForm()
        {
            _context = new DAL.LibraryContext();

            InitializeComponent();

            btnCreateAdmin.Visible = false;
            btnUpdateAdmin.Visible = false;
            btnDeleteAdmin.Visible = false;
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
      
            if (!ValiteAdmin())
            {
                return;
            }
            btnLogin.Visible = false;



            Admin admin = _context.Admins.FirstOrDefault(a => a.UserName == txbUserName.Text);

            if (admin.UserName == txbUserName.Text && admin.Password == txbPassword.Text)
            {
                lblwelcome.Text = "Xoş gəlmisiz " +  admin.UserName;
                ResetAdminInfo();
                btnShowReport.Visible = true;
               
            }
            else { this.Close(); }

            btnCreateAdmin.Visible = true;
            btnUpdateAdmin.Visible = true;
            btnDeleteAdmin.Visible = true;


        }

        private bool ValiteAdmin()
        {
            if (string.IsNullOrEmpty(txbUserName.Text))
            {
                lblUserName.ForeColor = Color.Red;
              return false;

            }
            if (string.IsNullOrEmpty(txbPassword.Text))
            {
                lblPassword.ForeColor = Color.Red;
              return false;
            }

            return true;
        }

        private void ResetAdminInfo()
        {
            txbUserName.Text = string.Empty;
            txbPassword.Text = string.Empty;
            lblUserName.ForeColor = Color.Black;
            lblPassword.ForeColor = Color.Black;

        }
        
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        


        //Admin CRUD
        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
           
            btnLogin.Visible = false;
            btnSave.Visible = true;
            btnUpdateAdmin.Visible = false;
            btnDeleteAdmin.Visible = false;


        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnLogin.Visible = false;
            cmbAdminName.Visible = true;
            txbUserName.Visible = false;
            AdminNamesToCmb();
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            btnLogin.Visible = false;
            cmbAdminName.Visible = true;
            txbUserName.Visible = false;
            AdminNamesToCmb();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValiteAdmin())
            {
                return;
            }

            Admin admin = new Admin
            {
                UserName = txbUserName.Text,
                Password = txbPassword.Text
            };
            _context.Admins.Add(admin);
            _context.SaveChanges();

            lblwelcome.Text = txbUserName.Text + " adlı admin yaradıldı.";


            btnLogin.Visible = true;
            btnSave.Visible = false;
            
            btnDeleteAdmin.Visible = true;
            btnUpdateAdmin.Visible = true;
            ResetAdminInfo();
            btnShowReport.Visible = true;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            Admin admin = _context.Admins.FirstOrDefault(a => a.UserName == cmbAdminName.SelectedItem.ToString());
            txbUserName.Text = cmbAdminName.SelectedItem.ToString();

            cmbAdminName.Visible = false;
            txbUserName.Visible = true;
            if (!ValiteAdmin())
            {
                return;
            }
            Admin _admin = new Admin
            {
                UserName = txbUserName.Text,
                Password = txbPassword.Text
            };
            _context.Admins.Remove(admin);
            _context.Admins.Add(_admin);
            _context.SaveChanges();

            btnLogin.Visible = true;
            btnSave.Visible = false;
            ResetAdminInfo();

            btnLogin.Visible = true;
            btnUpdate.Visible = false;
        }

        private void AdminNamesToCmb()
        {
            foreach (Admin item in _context.Admins)
            {
               cmbAdminName.Items.Add(item.UserName);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Admin admin = _context.Admins.FirstOrDefault(a => a.UserName == cmbAdminName.SelectedItem.ToString());

            DialogResult r = MessageBox.Show("Şəxsi silməyə əminsinizmi ?", "Silmə", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                if (txbPassword.Text==admin.Password)
                {
                    _context.Admins.Remove(admin);
                    _context.SaveChanges();
                    cmbAdminName.Visible = false;
                    ResetAdminInfo();
                }
              
                
                
                MessageBox.Show(admin.UserName.ToString() +
                    " Şəxsi silindi");
            }

          
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
            this.Hide();
        }

       
    }
}
