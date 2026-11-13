using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApplianceCare.Models;
namespace ApplianceCare.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Cusatomers
        public ActionResult Customers()
        {
            List<Customers> customers = new List<Customers>();
            {
                customers.Add(new Customers
                {
                    Name = "Jose",
                    LastName = "Ariza",
                    Email = "jordarlo2006@gmail.com",
                    DNI = 12345678,
                    Phone = 318123456,
                    Address = "Calle 123 # 45-67"
                });
                customers.Add(new Customers
                {
                    Name = "Maria",
                    LastName = "Gomez",
                    Email = "mariagomez@gmail.com",
                    DNI = 87654321,
                    Phone = 318987654,
                    Address = "Carrera 45 # 67-89"
                });
            }
            return View(customers);
        }
    }
}