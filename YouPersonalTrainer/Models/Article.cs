namespace YouPersonalTrainer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using YouPersonalTrainer.Enum;

    [Table("Articles")]
    public partial class Article
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Footnote { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public ArticlesTypes Category { get; set; }

        public string Photo { get; set; }
    }
}
