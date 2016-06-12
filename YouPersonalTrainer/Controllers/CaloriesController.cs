using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YouPersonalTrainer.Enum;
using YouPersonalTrainer.Models;

namespace YouPersonalTrainer.Controllers
{
    public class CaloriesController : Controller
    {
        //
        // GET: /Calories/

        public ActionResult CountingCalories()
        {

            return View();
        }
        public ActionResult CaloriesList(string id)
        {
            YPTDB art = new YPTDB();
            var category = ParseId(id);
            var list = art.Product.Where(b => b.Category == category).ToList();
            ProductsViewModel viewModel = new ProductsViewModel();
            foreach (var item in list)
            {
                viewModel.Products.Add(item);
            }
            return View(viewModel);
        }
        private ProductsType ParseId(string id)
        {
            if (id == "Vegerable")
            {
                return ProductsType.Vegerable;
            }
            if (id == "Fruit")
            {
                return ProductsType.Fruit;
            }
            if (id == "Porrage")
            {
                return ProductsType.Porrage;
            }
            if (id == "Protein")
            {
                return ProductsType.Protein;
            }
            if (id == "Confectionery")
            {
                return ProductsType.Confectionery;
            }
            if (id == "Dairy")
            {
                return ProductsType.Dairy;
            }
            return ProductsType.Vegerable;

        }
    }

     
}
