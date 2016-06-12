namespace YouPersonalTrainer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrMigrTest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Protein = c.Double(nullable: false),
                        Fat = c.Double(nullable: false),
                        Carbohidrate = c.Double(nullable: false),
                        Energy = c.Double(nullable: false),
                        Category = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Product");
        }
    }
}
