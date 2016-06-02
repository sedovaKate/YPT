﻿namespace YouPersonalTrainer.Models
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }


       
    }
}
