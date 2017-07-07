namespace MilwaukeeBeerCraft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class models : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PostBeerStyles", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.PostBeerStyles", "BeerStyles_Id", "dbo.BeerStyles");
            DropForeignKey("dbo.MilwaukeeBreweriesPosts", "MilwaukeeBreweries_Id", "dbo.MilwaukeeBreweries");
            DropForeignKey("dbo.MilwaukeeBreweriesPosts", "Post_Id", "dbo.Posts");
            DropIndex("dbo.PostBeerStyles", new[] { "Post_Id" });
            DropIndex("dbo.PostBeerStyles", new[] { "BeerStyles_Id" });
            DropIndex("dbo.MilwaukeeBreweriesPosts", new[] { "MilwaukeeBreweries_Id" });
            DropIndex("dbo.MilwaukeeBreweriesPosts", new[] { "Post_Id" });
            AddColumn("dbo.Posts", "Category", c => c.String());
            AddColumn("dbo.Posts", "Brewery", c => c.String());
            AddColumn("dbo.Posts", "Beers", c => c.String());
            AddColumn("dbo.Posts", "BeerStyles_Id", c => c.Int());
            AddColumn("dbo.Posts", "MilwaukeeBreweries_Id", c => c.Int());
            CreateIndex("dbo.Posts", "BeerStyles_Id");
            CreateIndex("dbo.Posts", "MilwaukeeBreweries_Id");
            AddForeignKey("dbo.Posts", "BeerStyles_Id", "dbo.BeerStyles", "Id");
            AddForeignKey("dbo.Posts", "MilwaukeeBreweries_Id", "dbo.MilwaukeeBreweries", "Id");
            DropColumn("dbo.Posts", "Description");
            DropColumn("dbo.Posts", "UrlSlug");
            DropTable("dbo.PostBeerStyles");
            DropTable("dbo.MilwaukeeBreweriesPosts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MilwaukeeBreweriesPosts",
                c => new
                    {
                        MilwaukeeBreweries_Id = c.Int(nullable: false),
                        Post_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MilwaukeeBreweries_Id, t.Post_Id });
            
            CreateTable(
                "dbo.PostBeerStyles",
                c => new
                    {
                        Post_Id = c.Int(nullable: false),
                        BeerStyles_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Post_Id, t.BeerStyles_Id });
            
            AddColumn("dbo.Posts", "UrlSlug", c => c.String());
            AddColumn("dbo.Posts", "Description", c => c.String());
            DropForeignKey("dbo.Posts", "MilwaukeeBreweries_Id", "dbo.MilwaukeeBreweries");
            DropForeignKey("dbo.Posts", "BeerStyles_Id", "dbo.BeerStyles");
            DropIndex("dbo.Posts", new[] { "MilwaukeeBreweries_Id" });
            DropIndex("dbo.Posts", new[] { "BeerStyles_Id" });
            DropColumn("dbo.Posts", "MilwaukeeBreweries_Id");
            DropColumn("dbo.Posts", "BeerStyles_Id");
            DropColumn("dbo.Posts", "Beers");
            DropColumn("dbo.Posts", "Brewery");
            DropColumn("dbo.Posts", "Category");
            CreateIndex("dbo.MilwaukeeBreweriesPosts", "Post_Id");
            CreateIndex("dbo.MilwaukeeBreweriesPosts", "MilwaukeeBreweries_Id");
            CreateIndex("dbo.PostBeerStyles", "BeerStyles_Id");
            CreateIndex("dbo.PostBeerStyles", "Post_Id");
            AddForeignKey("dbo.MilwaukeeBreweriesPosts", "Post_Id", "dbo.Posts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MilwaukeeBreweriesPosts", "MilwaukeeBreweries_Id", "dbo.MilwaukeeBreweries", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PostBeerStyles", "BeerStyles_Id", "dbo.BeerStyles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PostBeerStyles", "Post_Id", "dbo.Posts", "Id", cascadeDelete: true);
        }
    }
}
