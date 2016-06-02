using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YouPersonalTrainer.Models
{
    public class ArticlesViewModel
    {
        public List<Article> Articles { get; set; }

        public ArticlesViewModel()
        {
            Articles = new List<Article>();
        }
    }
}