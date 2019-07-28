using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace qgb48.Orders
{
    [NotMapped]
    public class Address
    {
        public string Province { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
