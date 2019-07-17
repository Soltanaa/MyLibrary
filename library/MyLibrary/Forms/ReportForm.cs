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


using ClosedXML.Excel;
using System.IO;

namespace MyLibrary.Forms
{
    public partial class ReportForm : Form
    {
        private readonly DAL.LibraryContext _context;

        public ReportForm()
        {
            _context = new DAL.LibraryContext();

            InitializeComponent();
        }

        /// <summary>
        /// this Method Fills datagridview with reports.
        /// By searching between two values from  two date time picker
        /// </summary>
        private void FillReports()
        {

            DateTime date1 = dtpBookingTime.Value;
            DateTime date2 = dtpPaydate.Value;

            var report = _context.Reports.Where(r => (r.Order.Paydate != null ? r.Order.Paydate >= date1 : r.Order.Paydate == null) & r.Order.Paydate <= date2).Select(r => new
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

            dgwAdminReport.DataSource = report;
        }

        private void btnSaleInterval_Click(object sender, EventArgs e)
        {
            FillReports();
            btnExportToExcell.Visible = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportToExcell_Click(object sender, EventArgs e)
        {
            CreateExcellfile();
        }

        private void CreateExcellfile()
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dgwAdminReport.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgwAdminReport.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgwAdminReport.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgwAdminReport.Columns.Count; j++)
                {
                    if(dgwAdminReport.Rows[i].Cells[j].Value == null)
                    {
                        dgwAdminReport.Rows[i].Cells[j].Value = Convert.ToDateTime(dgwAdminReport.Rows[i].Cells[j].Value);
                    }
                    worksheet.Cells[i + 2, j + 1] = dgwAdminReport.Rows[i].Cells[j].Value;
                }
            }
            // save the application  
            workbook.SaveAs(@"C:\Users\code\Desktop\report.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        
        }
    }
}
