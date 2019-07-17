using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace MyLibrary.Models
{
    class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Nullable<DateTime> Paydate { get; set; }
        public List<Report> Report { get; set; }

    }
}
