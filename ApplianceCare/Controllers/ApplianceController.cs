using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApplianceCare.Models;
namespace ApplianceCare.Controllers
{
    public class ApplianceController : Controller
    {
        // GET: Appliance
        public ActionResult Appliance()
        {
            List<Appliance> appliances = new List<Appliance>();
            {
                appliances.Add(new Appliance
                {
                    type = "Refrigerator",
                    Brand = "Samsung",
                    Model = "RT38K5982SL",
                    Price = 4200000.00
                });
                appliances.Add(new Appliance
                {
                    type = "Washing Machine",
                    Brand = "LG",
                    Model = "WM3488HW",
                    Price = 8000000.00
                });
            }
            return View(appliances);
        }
    }
}