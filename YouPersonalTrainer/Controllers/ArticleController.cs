using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YouPersonalTrainer.Enum;
using YouPersonalTrainer.Models;

namespace YouPersonalTrainer.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Article/
      public ActionResult Article()
        {

            ViewBag.Message = "Статьи";
            return View();
        }
      /* public ActionResult Article_Running()
     {

         ViewBag.Message = "Бег";
         return View();
     }

     public ActionResult Articles_Motivation()
     {

         ViewBag.Message = "Мотивация";
         return View();
     }

     public ActionResult Articles_Diet()
     {

         ViewBag.Message = "Питание";
         return View();
     }

     public ActionResult Articles_Health()
     {

         ViewBag.Message = "Здоровье";
         return View();
     }

     public ActionResult Articles_News()
     {

         ViewBag.Message = "Новости";
         return View();
     }

     public ActionResult Articles_Fitness()
       {

           ViewBag.Message = "Фитнес";
            return View();
       }*/
       
          public ActionResult ArticlesList(string id)
          {
              if (id == null)
              {
                  return new HttpStatusCodeResult(400);
              }
              YPTDB art = new YPTDB();
              var category = ParseId(id);
              var list = art.Articles.Where(a => a.Category == category).ToList();
              ArticlesViewModel viewModel = new ArticlesViewModel();
              foreach (var item in list)
              {
                  viewModel.Articles.Add(item);
              }
              return View(viewModel);
          }


          private ArticlesTypes ParseId(string id)
          {
              if (id == "Diet")
              {
                  return ArticlesTypes.Diet;
              }
               
        

              if (id == "Training")
              {
                  return ArticlesTypes.Training;
              }
              
        
           
              if (id == "News")
              {
                  return ArticlesTypes.News;
              }
              

              if (id == "Health")
              {
                  return ArticlesTypes.Health;
              }
              

              if (id == "Motivation")
              {
                  return ArticlesTypes.Motivation;
              }
              return ArticlesTypes.Diet;
          }
         
         
         /* 
         * string text = System.IO.File.ReadAllText(@"C:\Users\1\статья1.txt");
       */


    }

}
