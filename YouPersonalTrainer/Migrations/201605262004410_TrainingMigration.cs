namespace YouPersonalTrainer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrainingMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Training",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Training");
        }
    }
}
