using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplianceCare.Models
{
    public class TechnicianController : Controller
    {
        // GET: Technician
        public ActionResult Technician()
        {
            List<Technician> technicians = new List<Technician>();
            {
                technicians.Add(new Technician
                {
                    Name = "John",
                    LastName = "Doe",
                    Experience = "5 years",
                    Specialty = "Refrigerators",
                    NIF = 123456789,
                    movile = "555-1234"
                });
                technicians.Add(new Technician
                {
                    Name = "Jane",
                    LastName = "Smith",
                    Experience = "3 years",
                    Specialty = "Washing Machines",
                    NIF = 987654321,
                    movile = "555-5678"
                });
            }
            return View(technicians);
        }
    }
}