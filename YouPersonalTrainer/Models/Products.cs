namespace YouPersonalTrainer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using YouPersonalTrainer.Enum;

    
    [Table("Products")]
    public partial class Products
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int Protein { get; set; }

        public int Fat { get; set; }

        public int Carbohidrate { get; set; }

        [Required]
        public int Energy { get; set; }

        public ProductsType Category { get; set; }

    }
}