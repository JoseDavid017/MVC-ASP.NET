using ApplianceCare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplianceCare.Controllers
{
    public class RepairController : Controller
    {
        // GET: Repair
        public ActionResult Repair()
        {
            List<Repair> repair = new List<Repair>();
            {
                repair.Add(new Repair
                {
                    description = "Refrigerator not cooling",
                    Date = new DateTime(2023, 5, 10),
                    time = new DateTime(2023, 5, 10, 14, 30, 0),
                    cost = 150000.00,
                    ApplianceCare = true
                });
                repair.Add(new Repair
                {
                    description = "Washing machine leaking water",
                    Date = new DateTime(2026, 5, 12),
                    time = new DateTime(2026, 5, 12, 10, 0, 0),
                    cost = 100000.00,
                    ApplianceCare = false
                });
            }
            return View(repair);
        }
    }
}