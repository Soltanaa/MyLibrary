using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Models
{
    class Report
    {

        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

        public Nullable<DateTime> Paydate { get; set; }
        public DateTime BookingTime { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        [Column(TypeName = "money")]
        public decimal PaymentCost { get; set; }

        public bool IsPaid { get; set; }
    }
}
