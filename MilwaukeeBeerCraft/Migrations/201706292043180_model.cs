namespace MilwaukeeBeerCraft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class model : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Beer", c => c.String());
            AlterColumn("dbo.Categories", "Brewery", c => c.String());
            AlterColumn("dbo.Categories", "Event", c => c.String());
            AlterColumn("dbo.Categories", "People", c => c.String());
            DropColumn("dbo.MilwaukeeBreweries", "UrlSlug");
            DropColumn("dbo.MilwaukeeBreweries", "GoodCity");
            DropColumn("dbo.MilwaukeeBreweries", "ThirdSpace");
            DropColumn("dbo.MilwaukeeBreweries", "MobCraft");
            DropColumn("dbo.MilwaukeeBreweries", "MilWaukeeBrewing");
            DropColumn("dbo.MilwaukeeBreweries", "LakefrontBrewery");
            DropColumn("dbo.MilwaukeeBreweries", "BrennerBrewing");
            DropColumn("dbo.MilwaukeeBreweries", "EagleParkBrewing");
            DropColumn("dbo.MilwaukeeBreweries", "Enlightened");
            DropColumn("dbo.MilwaukeeBreweries", "D14");
            DropColumn("dbo.MilwaukeeBreweries", "StFrancis");
            DropColumn("dbo.MilwaukeeBreweries", "CompanyBrewing");
            DropColumn("dbo.MilwaukeeBreweries", "GatheringPlace");
            DropColumn("dbo.MilwaukeeBreweries", "CityLights");
            DropColumn("dbo.MilwaukeeBreweries", "BrokenBat");
            DropColumn("dbo.MilwaukeeBreweries", "BlackHusky");
            DropColumn("dbo.MilwaukeeBreweries", "NewBarons");
            DropColumn("dbo.MilwaukeeBreweries", "Sprecher");
            DropColumn("dbo.MilwaukeeBreweries", "RaisedGrain");
            DropColumn("dbo.MilwaukeeBreweries", "Fermentorium");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MilwaukeeBreweries", "Fermentorium", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "RaisedGrain", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "Sprecher", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "NewBarons", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "BlackHusky", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "BrokenBat", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "CityLights", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "GatheringPlace", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "CompanyBrewing", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "StFrancis", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "D14", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "Enlightened", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "EagleParkBrewing", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "BrennerBrewing", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "LakefrontBrewery", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "MilWaukeeBrewing", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "MobCraft", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "ThirdSpace", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "GoodCity", c => c.Boolean(nullable: false));
            AddColumn("dbo.MilwaukeeBreweries", "UrlSlug", c => c.String());
            AlterColumn("dbo.Categories", "People", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Categories", "Event", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Categories", "Brewery", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Categories", "Beer", c => c.Boolean(nullable: false));
        }
    }
}
