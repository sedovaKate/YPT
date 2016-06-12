using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using YouPersonalTrainer.Enum;


namespace YouPersonalTrainer.Models
{
   
        [Table("Product")]
        public partial class Product
        {
            public int Id { get; set; }

            [Required]
            public string Title { get; set; }

            public double Protein { get; set; }

            public double Fat { get; set; }

            public double Carbohidrate { get; set; }

            [Required]
            public double Energy { get; set; }

            public ProductsType Category { get; set; }


        }
    
}