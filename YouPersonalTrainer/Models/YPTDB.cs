namespace YouPersonalTrainer.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class YPTDB : DbContext
    {
        public YPTDB()
            : base("name=YPTDB")
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
<<<<<<< HEAD
        public virtual DbSet<Product> Product { get; set; }
=======
        public virtual DbSet<Products> Products { get; set; }
>>>>>>> dcd4f29919c27d78918ffc29f9bfe6d762c7a58d

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }


       
    }
}
