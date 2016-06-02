using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YouPersonalTrainer.Models;
using System.Collections;

namespace YouPersonalTrainer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult BasePage()
        {
            ViewBag.Message = "Твой личный тренер";
            return View();
        }

        public ActionResult Training()
        {
            ViewBag.Message = "Тренировки";
            /*string text = System.IO.File.ReadAllText(@"C:\Users\1\статья1.txt");
            System.Console.WriteLine("Contents of статья1.txt = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();*/
            return View();
        }


        public ActionResult Diet()
        {
            ViewBag.Message = "Питание";
            return View();
        }
        public ActionResult Journal()
        {
            ViewBag.Message = "Дневник";
            return View();
        }
    }
}
