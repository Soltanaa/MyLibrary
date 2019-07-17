using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Models
{
    class Customer
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        [DisplayName("Ad Soyad")]
        public string FullName { get; set; }

        [MaxLength(50)]
        public string PhoneNumber { get; set; }

        public List<Order> Order { get; set; }

        public string Adi
        {
            get { return FullName; }
        }
    }
}
