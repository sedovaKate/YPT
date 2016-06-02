using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YouPersonalTrainer.Controllers
{
    public class TrainingPagesController : Controller
    {
        //
        // GET: /TrainingPages/


        public ActionResult TrainingFitness()
        {
            ViewBag.Message = "Фитнес";

            return View();
        }

        public ActionResult TrainingRunning()
        {
            ViewBag.Message = "Бег";

            return View();
        }

        public ActionResult Muscle()
        {
            ViewBag.Message = "Накачаться";

            return View();
        }

        public ActionResult Slim()
        {
            ViewBag.Message = "Похудеть";

            return View();
        }

        public ActionResult FitnessBody()
        {
            ViewBag.Message = "Фитнес-тело";

            return View();
        }



    }
}
