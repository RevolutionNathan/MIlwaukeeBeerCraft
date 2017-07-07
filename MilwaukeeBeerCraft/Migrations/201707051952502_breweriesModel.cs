namespace MilwaukeeBeerCraft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class breweriesModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MilwaukeeBreweries", "Lat", c => c.Int(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "Long", c => c.Int(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "url", c => c.String());
            AddColumn("dbo.MilwaukeeBreweries", "description", c => c.String());
        }
        
        public override void Down()
        {
        }
    }
}
