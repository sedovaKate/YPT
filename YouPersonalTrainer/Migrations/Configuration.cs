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
            var collection = context.Articles;
            foreach (var item in collection)
            {
                context.Articles.Remove(item);
            }
            context.Articles.AddOrUpdate(new Article { Title = "œŒ√Œ¬Œ–»Ã Œ  ¿ÀŒ–»ﬂ’", Text = "text1234566‡‚Ô‚Ô‚Â‚Â‚ÂÂ", Category = 0, Id = 1 });
            
            
            context.Trainings.AddOrUpdate(new Training { Title = "Test", Text = "text09877654038409729" });
            

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
