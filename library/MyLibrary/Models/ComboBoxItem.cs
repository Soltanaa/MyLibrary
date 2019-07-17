using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Models
{
    class ComboBoxItem
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public override string ToString()
        {
            return FullName;
        }
    }
}
