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

namespace MyLibrary.Forms
{
    public partial class LoginForm : Form
    {
        private readonly DAL.LibraryContext _context;
        public LoginForm()
        {
            InitializeComponent();
            _context = new DAL.LibraryContext();

        }

        private bool ValiteForm()
        {

            if (string.IsNullOrEmpty(txbfulName.Text))
            {
                lblFullName.ForeColor = Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(txbPhonenumber.Text))
            {
                lblPhoneNumber.ForeColor = Color.Red;
                return false;
            }

            return true;
        }

        private void ValiteReset()
        {
            txbfulName.Text = string.Empty;
            txbPhonenumber.Text = string.Empty;
            txbfulName.ForeColor = SystemColors.ControlText;
            lblPhoneNumber.ForeColor = SystemColors.ControlLightLight;

           
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            if (!ValiteForm())
            {
                return;
            }


            Customer user = new Customer
            {

                FullName = txbfulName.Text,
                PhoneNumber = txbPhonenumber.Text,

            };

            _context.Custmer.Add(user);
            _context.SaveChanges();

            

            ValiteReset();


            Dashboard dashboard = new Dashboard();
            dashboard.Show();

         


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ValiteReset();
            
            this.Close();
        }

       
    }
}
