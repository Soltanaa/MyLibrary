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
using MyLibrary.Models;

namespace MyLibrary.Forms
{
    public partial class ReturnBookForm : Form
    {
        private readonly DAL.LibraryContext _context;

        public int SelectedRow { get; private set; }

        public ReturnBookForm()
        {
            _context = new DAL.LibraryContext();
            InitializeComponent();
            FillCustomerInfoToCmb();

            FillDataGridViews();

        }

        private void FillCustomerInfoToCmb()
        {
            var customer = _context.Custmer.Select(c => new ComboBoxItem { Id = c.Id, FullName = c.FullName }
                ).ToList();
            cmbCustomers.Items.AddRange(customer.ToArray());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!Valite())
            {
                return;
            }


            if ((cmbCustomers.SelectedItem) != null)
            {


                var selectedname = cmbCustomers.SelectedItem.ToString();
                var report = _context.Reports.Where(r => r.Order.Customer.FullName == selectedname).Select(r => new
                {
                    r.Order.Customer.FullName,
                    r.Order.Customer.PhoneNumber,
                    r.Book.Name,
                    r.Book.BookCount,
                    r.Book.Price,
                    r.BookingTime,
                    r.Paydate,
                    r.PaymentCost,


                }).ToList();

                dgwOrder.DataSource = report;

                Report _report = _context.Reports.FirstOrDefault(r => r.Order.Customer.FullName == selectedname);
                _report.IsPaid = true;


                _context.Reports.Add(_report);
                _context.SaveChanges();




            }
            return;
        }

        private void Reset()
        {

            lblCustomers.ForeColor = Color.Black;

        }

        private bool Valite()
        {
            if (cmbCustomers.Text == string.Empty)
            {
                lblCustomers.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private void CalculateBookPrice()
        {
            var SelectedName = cmbCustomers.SelectedItem.ToString();

            Report report = _context.Reports.FirstOrDefault(b => b.Order.Customer.FullName == SelectedName);
            double totalPrice = 0;

            var bookPrice = Convert.ToInt32(report.Book.Price);

            var getdate = report.BookingTime;

            var returndate = report.Paydate;

            var dateToday = DateTime.Now;

            var Diffdate = Convert.ToDateTime(returndate).Subtract(dateToday).Days;

            var diffdatereturn = Convert.ToDateTime(returndate).Subtract(getdate).Days;



            if (returndate == null)
            {
                returndate = DateTime.Now;
                // return returndate;
            }


            if (Diffdate < 0)
            {
                report.PaymentCost = Convert.ToDecimal(bookPrice * 0.5 * Diffdate);

                MessageBox.Show(bookPrice.ToString());

                MessageBox.Show(report.PaymentCost.ToString());
            }

            totalPrice += Convert.ToDouble(report.PaymentCost);
            lbltotalPrice.Text = totalPrice.ToString();

        }




        private void dgwOrder_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.SelectedRow = e.RowIndex;
            string selectedName = dgwOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
            Customer customer = _context.Custmer.FirstOrDefault(c => c.FullName == selectedName);
            int id = Convert.ToInt32(customer.Id.ToString());

        }

        private void btnCloseOrder_Click(object sender, EventArgs e)
        {

            //CalculateBookPrice();



            string selectedname = dgwOrder.Rows[this.SelectedRow].Cells[0].Value.ToString();
            //var dateToday = DateTime.Now;

            Customer customer = _context.Custmer.FirstOrDefault(c => c.FullName == selectedname);
            Report report = _context.Reports.FirstOrDefault(b => b.Order.Customer.FullName == selectedname);
            report.IsPaid = true;

            _context.Reports.Add(report);
            _context.SaveChanges();

            cmbCustomers.SelectedText = "";



        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillDataGridViews()
        {
            var todayDate = DateTime.Now;
            var report = _context.Reports.Where(r => r.Paydate == todayDate).Select(r => new
            {
                r.Order.Customer.FullName,
                r.Order.Customer.PhoneNumber,
                r.Book.Name,
                r.Book.BookCount,
                r.Book.Price,
                r.BookingTime,
                r.Paydate,
                r.PaymentCost,


            }).ToList();

            dgwToday.DataSource = report;


            var Tomorrowdate = DateTime.Now.AddDays(1);
            var reportTomorrow = _context.Reports.Where(r => r.Paydate == todayDate).Select(r => new
            {
                r.Order.Customer.FullName,
                r.Order.Customer.PhoneNumber,
                r.Book.Name,
                r.Book.BookCount,
                r.Book.Price,
                r.BookingTime,
                r.Paydate,
                r.PaymentCost,


            }).ToList();

            dgwTomorrow.DataSource = reportTomorrow;

            var LateDate = DateTime.Now.AddDays(-1);
            var reportlate = _context.Reports.Where(r => r.Paydate <= todayDate).Select(r => new
            {
                r.Order.Customer.FullName,
                r.Order.Customer.PhoneNumber,
                r.Book.Name,
                r.Book.BookCount,
                r.Book.Price,
                r.BookingTime,
                r.Paydate,
                r.PaymentCost,


            }).ToList();

            dgwLate.DataSource = reportlate;
        }


    }
}
