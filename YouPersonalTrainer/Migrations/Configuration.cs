namespace YouPersonalTrainer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using YouPersonalTrainer.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<YouPersonalTrainer.Models.YPTDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(YouPersonalTrainer.Models.YPTDB context)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\1\ÒÚ‡Ú¸ˇ1.txt");
            context.Articles.AddOrUpdate(new Article { Title = "œŒ√Œ¬Œ–»Ã Œ  ¿ÀŒ–»ﬂ’", Text = text });
            context.Trainings.AddOrUpdate(new Training { Title = "Test" });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
