using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary.DAL;
using MyLibrary.Forms;
using MyLibrary.Models;


namespace MyLibrary
{
    public partial class Dashboard : Form
    {
        private readonly DAL.LibraryContext _context;
        private decimal totalPrice = 0;

        private int SelectedRow;
        public Dashboard()
        {
            InitializeComponent();
            _context = new DAL.LibraryContext();

            FillCustomerInfoToCmb();
            FillBooks();

        }

        private void FillBooks()
        {
            foreach (Book item in _context.Books)
            {
                cmbBooks.Items.Add(item.Name);
            }
        }

        private void FillCustomerInfoToCmb() 
        {
            var customer = _context.Custmer.Select(c => new ComboBoxItem { Id = c.Id, FullName = c.FullName }
                ).ToList();
            cmbCustomers.Items.AddRange(customer.ToArray());
        }

      
        private void FillPersolanInfoCustomers()
        {

            var selectedBook = cmbBooks.SelectedIndex;
            var selectedBookCount = Convert.ToInt32(NudCount.Value);
            var getdate = dtpGetdate.Value;
            var returndate = dtpReturn.Value;
            var Diffdate = getdate.Subtract(returndate).Days;

            

            Book book = _context.Books.FirstOrDefault(b => b.Name == cmbBooks.Text);
            Customer cmr = _context.Custmer.FirstOrDefault(c => c.FullName == cmbCustomers.Text);


            if (!ValiteForm())
            {
                return;
            }

                Order order = new Order
                {
                    CustomerId = cmr.Id,

                    Paydate = dtpReturn.Value

                };

                _context.Orders.Add(order);
                _context.SaveChanges();

                Report report = new Report
                {

                    BookId = book.Id,
                    OrderId = order.Id,
                    BookingTime = dtpGetdate.Value,
                    Paydate = dtpReturn.Value,
                    IsPaid = false,
                    PaymentCost = (Convert.ToDecimal(selectedBookCount)) * Convert.ToDecimal(book.Price),

                };


                dgwOrder.Rows.Add(cmbCustomers.Text, cmbBooks.Text, NudCount.Value, dtpGetdate.Value, report.Paydate, report.PaymentCost);

                totalPrice += report.PaymentCost;
                _context.Reports.Add(report);
                _context.SaveChanges();

                ResetCustomerInfo();

                lbltotalPrice.Text = totalPrice.ToString();
            }
          
       
        

        private bool ValiteForm()
        {
            if (string.IsNullOrEmpty(cmbCustomers.Text.ToString()))
            {
                lblCustomers.ForeColor = Color.Red;
                return false;

            }
            if (string.IsNullOrEmpty(cmbBooks.Text.ToString()))
            {
                lblBooks.ForeColor = Color.Red;
                return false;
            }

            return true;
        }

        private void ResetCustomerInfo()
        {
            cmbCustomers.SelectedText = string.Empty;
            cmbBooks.SelectedText = string.Empty;
            lblCustomers.ForeColor = Color.White;
            lblBooks.ForeColor = Color.White;

        }


        private void bnOrder_Click(object sender, EventArgs e)
        {
            if ((cmbCustomers.SelectedItem)!=null || cmbBooks.SelectedItem!=null)
            {
                FillPersolanInfoCustomers();
                cmbCustomers.Items.Clear();
                bnOrder.Text = "Sifarişi Yenilə";
            }
            return;

        }

       
        private void dgwOrder_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.SelectedRow = e.RowIndex;
            string selectedName = dgwOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
            Customer customer = _context.Custmer.FirstOrDefault(c => c.FullName == selectedName);
            int id = Convert.ToInt32(customer.Id.ToString());

           
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Səxsi silməyə əminsiniz mi?", "Silmə", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                
                string selectedname = dgwOrder.Rows[this.SelectedRow].Cells[0].Value.ToString();
                Customer customer = _context.Custmer.FirstOrDefault(c => c.FullName == selectedname);

                _context.Custmer.Remove(customer);
                _context.SaveChanges();

                dgwOrder.Rows.Clear();
                lbltotalPrice.Text = string.Empty;
                FillCustomerInfoToCmb();
                cmbCustomers.SelectedText = "";
                cmbBooks.Text = "";
                cmbCustomers.Text = "";
                totalPrice = 0;
                lbltotalPrice.Text = totalPrice.ToString();
                bnOrder.Text = "Sifarişi təsdiqlə";
                btnDelete.Visible = false;



                MessageBox.Show("Səxs silindi");
            }

            
        }










    

        private void DiffTime()
        {
            TimeSpan timeSpan = DateTime.Now.AddDays(7) - DateTime.Now;
            //split ile parse edib tapmaq

            MessageBox.Show(timeSpan.ToString());
        }

        private void kitabQaytaışıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBookForm returnBook = new ReturnBookForm();
            returnBook.Show();
        }


        //iki vaxt arasindaki ferqi tapan method
        private void GetValueDate() //methodyu deqiqlewdir

        {

            DateTime date1 = dtpGetdate.Value;
            DateTime date2 = dtpReturn.Value;

            double diftime = date2.Subtract(date1).TotalDays;

            MessageBox.Show(diftime.ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString());
            if (dtpReturn.Value == DateTime.Now) //burdan davam et,datetime.now hemise ferqli deyer qaytarir.cunki saniye ferqli olur

            {
                //report.Paydate = null;
                MessageBox.Show(dtpReturn.Value.Date.ToString());

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnOpenAdmin_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
            this.Close();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBookForm returnBook = new ReturnBookForm();
            returnBook.ShowDialog();
        }
    }
}
