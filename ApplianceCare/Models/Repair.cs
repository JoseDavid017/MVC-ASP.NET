using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplianceCare.Models
{
    public class Repair
    {
        public String description { get; set; }
        
        public DateTime Date { get; set; }
        public DateTime time { get; set; }
        public double cost { get; set; }
        public bool ApplianceCare { get; set; }

    }
}