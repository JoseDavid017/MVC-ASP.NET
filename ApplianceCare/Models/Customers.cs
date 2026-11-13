using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplianceCare.Models
{
    public class Customers
    {
        public String Name { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public int DNI { get; set; }
        public int Phone { get; set; }
        public String Address { get; set; }
    }
}