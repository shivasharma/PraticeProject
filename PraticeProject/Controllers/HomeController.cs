using Pratice.DataLayer;
using Pratice.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PraticeProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Index()
        {
            var db = new PaticeContext();
            var customer = new Customer()
            {
                Name = "Shiva"
            };
            db.Customers.Add(customer);
            db.SaveChanges();

            return View();
        }
    }
}