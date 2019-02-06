using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string text = "Hello";
            System.IO.File.WriteAllText(@"C:\Users\Myuri\Desktop\log.txt", text);
            Random rand = new Random(10);
            int num = rand.Next();
            if (num > 20000)
            {
                return View("About");
            }
            return View();
        }

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
    }
}