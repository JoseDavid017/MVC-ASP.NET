using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplianceCare.Models
{
    public class Technician
    {
        public String Name { get; set; }
        public String LastName { get; set; }
        public String Experience { get; set; }
        public String Specialty { get; set; }
        public int NIF { get; set; }
        public String movile { get; set; }
    }
}