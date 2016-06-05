using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace YouPersonalTrainer.Models
{
    [Table("Training")]
    public partial  class Training
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Text { get; set; }

        
    }
}