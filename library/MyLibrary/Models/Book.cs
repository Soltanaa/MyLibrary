using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Models
{
    class Book
    {
        public int Id { get; set; }

        [Required]
        public int BookCount { get; set; }
        
        [Required(ErrorMessage ="Kitab secimini unutmayin."),MaxLength(50)]
        public string Name { get; set; }

        [Column(TypeName ="money")]
        public decimal Price { get; set; }

        public List<Report> Reports { get; set; }

        // public Nullable<int> PersonId { get; set; }

        // public Person Person { get; set; }

        //public Report Report { get; set; }
    }
}
