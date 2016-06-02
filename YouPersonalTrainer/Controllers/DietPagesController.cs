using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YouPersonalTrainer.Controllers
{
    public class DietPagesController : Controller
    {
        //
        // GET: /DietPages/

        public ActionResult Recipes()
        {
            ViewBag.Message = "Рецепты";
            return View();
        }

        public ActionResult ProperNutrition()
        {
            ViewBag.Message = "Правильное питание";
            return View();
        }
        public ActionResult ProteinDiet()
        {
            ViewBag.Message = "Белковая диета";
            return View();
        }

        public ActionResult VegetarianCuisine()
        {
            ViewBag.Message = "Вегетарианская кухня";
            return View();
        }


    }
}
