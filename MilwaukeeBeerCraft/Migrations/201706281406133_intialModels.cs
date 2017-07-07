namespace MilwaukeeBeerCraft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intialModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beers1",
                c => new
                    {
                        bid = c.Int(nullable: false, identity: true),
                        beer_name = c.String(),
                        beer_label = c.String(),
                        beer_style = c.String(),
                        beer_abv = c.Double(nullable: false),
                        beer_ibu = c.Int(nullable: false),
                        beer_slug = c.String(),
                        beer_description = c.String(),
                        is_in_production = c.Int(nullable: false),
                        created_at = c.String(),
                        auth_rating = c.Int(nullable: false),
                        wish_list = c.Boolean(nullable: false),
                        rating_score = c.Double(nullable: false),
                        rating_count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.bid);
            
            CreateTable(
                "dbo.BeerListObjects",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        meta_id = c.Int(),
                        response_id = c.Int(),
                        ListOfBeerLists_ListId = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Metas", t => t.meta_id)
                .ForeignKey("dbo.Responses", t => t.response_id)
                .ForeignKey("dbo.ListOfBeerLists", t => t.ListOfBeerLists_ListId)
                .Index(t => t.meta_id)
                .Index(t => t.response_id)
                .Index(t => t.ListOfBeerLists_ListId);
            
            CreateTable(
                "dbo.Metas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.Int(nullable: false),
                        init_time_id = c.Int(),
                        response_time_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.InitTimes", t => t.init_time_id)
                .ForeignKey("dbo.ResponseTimes", t => t.response_time_id)
                .Index(t => t.init_time_id)
                .Index(t => t.response_time_id);
            
            CreateTable(
                "dbo.InitTimes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        time = c.Double(nullable: false),
                        measure = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ResponseTimes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        time = c.Double(nullable: false),
                        measure = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Responses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        source = c.String(),
                        total_count_filtered = c.Int(nullable: false),
                        total_count = c.Int(nullable: false),
                        is_search = c.Boolean(nullable: false),
                        type_id = c.Boolean(nullable: false),
                        sort = c.Boolean(nullable: false),
                        sort_name = c.String(),
                        sort_key = c.String(),
                        beers_id = c.Int(),
                        collaborations_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Beers", t => t.beers_id)
                .ForeignKey("dbo.Collaborations", t => t.collaborations_id)
                .Index(t => t.beers_id)
                .Index(t => t.collaborations_id);
            
            CreateTable(
                "dbo.Beers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        total_user_count = c.Int(nullable: false),
                        total_count = c.Int(nullable: false),
                        beer_bid = c.Int(),
                        brewery_brewery_id = c.Int(),
                        friends_id = c.Int(),
                        Beers_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Beers1", t => t.beer_bid)
                .ForeignKey("dbo.Breweries", t => t.brewery_brewery_id)
                .ForeignKey("dbo.Friends", t => t.friends_id)
                .ForeignKey("dbo.Beers", t => t.Beers_id)
                .Index(t => t.beer_bid)
                .Index(t => t.brewery_brewery_id)
                .Index(t => t.friends_id)
                .Index(t => t.Beers_id);
            
            CreateTable(
                "dbo.Breweries",
                c => new
                    {
                        brewery_id = c.Int(nullable: false, identity: true),
                        brewery_name = c.String(),
                        brewery_slug = c.String(),
                        brewery_label = c.String(),
                        country_name = c.String(),
                        brewery_active = c.Int(nullable: false),
                        contact_id = c.Int(),
                        location_id = c.Int(),
                    })
                .PrimaryKey(t => t.brewery_id)
                .ForeignKey("dbo.Contacts", t => t.contact_id)
                .ForeignKey("dbo.Locations", t => t.location_id)
                .Index(t => t.contact_id)
                .Index(t => t.location_id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        twitter = c.String(),
                        facebook = c.String(),
                        instagram = c.String(),
                        url = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        brewery_city = c.String(),
                        brewery_state = c.String(),
                        lat = c.Double(nullable: false),
                        lng = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Friends",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Collaborations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.BeerStyles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UrlSlug = c.String(),
                        AmericanAmber = c.Boolean(nullable: false),
                        RedAle = c.Boolean(nullable: false),
                        AmericanBarleywine = c.Boolean(nullable: false),
                        AmericanBlackAle = c.Boolean(nullable: false),
                        AmericanBlondeAle = c.Boolean(nullable: false),
                        AmericanBrownAle = c.Boolean(nullable: false),
                        AmericanDarkWheatAle = c.Boolean(nullable: false),
                        AmericanDoubleIPA = c.Boolean(nullable: false),
                        ImperialIPA = c.Boolean(nullable: false),
                        AmericanDoubleStout = c.Boolean(nullable: false),
                        ImperialStout = c.Boolean(nullable: false),
                        AmericanIPA = c.Boolean(nullable: false),
                        AmericanPaleAle = c.Boolean(nullable: false),
                        AmericanPaleWheatAle = c.Boolean(nullable: false),
                        AmericanPorter = c.Boolean(nullable: false),
                        AmericanStout = c.Boolean(nullable: false),
                        AmericanStrongAle = c.Boolean(nullable: false),
                        AmericanWildAle = c.Boolean(nullable: false),
                        BlackTan = c.Boolean(nullable: false),
                        ChileBeer = c.Boolean(nullable: false),
                        CreamAle = c.Boolean(nullable: false),
                        PumpkinAle = c.Boolean(nullable: false),
                        RyeBeer = c.Boolean(nullable: false),
                        Wheatwine = c.Boolean(nullable: false),
                        BelgianDarkAle = c.Boolean(nullable: false),
                        BelgianIPA = c.Boolean(nullable: false),
                        BelgianPaleAle = c.Boolean(nullable: false),
                        BelgianStrongDarkAle = c.Boolean(nullable: false),
                        BelgianStrongPaleAle = c.Boolean(nullable: false),
                        BièredeGarde = c.Boolean(nullable: false),
                        Dubbel = c.Boolean(nullable: false),
                        Faro = c.Boolean(nullable: false),
                        FlandersOudBruin = c.Boolean(nullable: false),
                        FlandersRedAle = c.Boolean(nullable: false),
                        Gueuze = c.Boolean(nullable: false),
                        LambicFruit = c.Boolean(nullable: false),
                        LambicUnblended = c.Boolean(nullable: false),
                        Quadrupel = c.Boolean(nullable: false),
                        Saison = c.Boolean(nullable: false),
                        FarmhouseAle = c.Boolean(nullable: false),
                        Tripel = c.Boolean(nullable: false),
                        Witbier = c.Boolean(nullable: false),
                        BalticPorter = c.Boolean(nullable: false),
                        Braggot = c.Boolean(nullable: false),
                        EnglishBarleywine = c.Boolean(nullable: false),
                        EnglishBitter = c.Boolean(nullable: false),
                        EnglishBrownAle = c.Boolean(nullable: false),
                        EnglishDarkMildAle = c.Boolean(nullable: false),
                        EnglishIndiaPaleAle = c.Boolean(nullable: false),
                        EnglishPaleAle = c.Boolean(nullable: false),
                        EnglishPaleMildAle = c.Boolean(nullable: false),
                        EnglishPorter = c.Boolean(nullable: false),
                        EnglishStout = c.Boolean(nullable: false),
                        EnglishStrongAle = c.Boolean(nullable: false),
                        ExtraSpecialBitter = c.Boolean(nullable: false),
                        ExportStout = c.Boolean(nullable: false),
                        MilkStout = c.Boolean(nullable: false),
                        OatmealStout = c.Boolean(nullable: false),
                        OldAle = c.Boolean(nullable: false),
                        RussianImperialStout = c.Boolean(nullable: false),
                        WinterWarmer = c.Boolean(nullable: false),
                        Sahti = c.Boolean(nullable: false),
                        Altbier = c.Boolean(nullable: false),
                        BerlinerWeissbier = c.Boolean(nullable: false),
                        Dunkelweizen = c.Boolean(nullable: false),
                        Gose = c.Boolean(nullable: false),
                        Hefeweizen = c.Boolean(nullable: false),
                        Kölsch = c.Boolean(nullable: false),
                        Kristalweizen = c.Boolean(nullable: false),
                        Roggenbier = c.Boolean(nullable: false),
                        Weizenbock = c.Boolean(nullable: false),
                        IrishDryStout = c.Boolean(nullable: false),
                        IrishRed = c.Boolean(nullable: false),
                        Kvass = c.Boolean(nullable: false),
                        ScotchAle = c.Boolean(nullable: false),
                        WeeHeavy = c.Boolean(nullable: false),
                        ScottishAle = c.Boolean(nullable: false),
                        Gruit = c.Boolean(nullable: false),
                        AncientHerbedAle = c.Boolean(nullable: false),
                        AmericanAdjunctLager = c.Boolean(nullable: false),
                        AmericanAmberLager = c.Boolean(nullable: false),
                        AmericanRedLager = c.Boolean(nullable: false),
                        AmericanImperialPilsner = c.Boolean(nullable: false),
                        AmericanMaltLiquor = c.Boolean(nullable: false),
                        AmericanPaleLager = c.Boolean(nullable: false),
                        CaliforniaCommonSteamBeer = c.Boolean(nullable: false),
                        LightLager = c.Boolean(nullable: false),
                        CzechPilsener = c.Boolean(nullable: false),
                        EuroDarkLager = c.Boolean(nullable: false),
                        EuroPaleLager = c.Boolean(nullable: false),
                        EuroStrongLager = c.Boolean(nullable: false),
                        Bock = c.Boolean(nullable: false),
                        Doppelbock = c.Boolean(nullable: false),
                        Dortmunder = c.Boolean(nullable: false),
                        Eisbock = c.Boolean(nullable: false),
                        GermanPilsener = c.Boolean(nullable: false),
                        KellerbierZwickelbier = c.Boolean(nullable: false),
                        MaibockHellesBock = c.Boolean(nullable: false),
                        MärzenOktoberfest = c.Boolean(nullable: false),
                        MunichDunkelLager = c.Boolean(nullable: false),
                        MunichHellesLager = c.Boolean(nullable: false),
                        Rauchbier = c.Boolean(nullable: false),
                        Schwarzbier = c.Boolean(nullable: false),
                        ViennaLager = c.Boolean(nullable: false),
                        FruitBeer = c.Boolean(nullable: false),
                        HerbedBeer = c.Boolean(nullable: false),
                        SmokedBeer = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Published = c.Boolean(nullable: false),
                        PostedOn = c.DateTime(nullable: false),
                        Modified = c.DateTime(),
                        UrlSlug = c.String(),
                        Content = c.String(),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.MilwaukeeBreweries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UrlSlug = c.String(),
                        GoodCity = c.Boolean(nullable: false),
                        ThirdSpace = c.Boolean(nullable: false),
                        MobCraft = c.Boolean(nullable: false),
                        MilWaukeeBrewing = c.Boolean(nullable: false),
                        LakefrontBrewery = c.Boolean(nullable: false),
                        BrennerBrewing = c.Boolean(nullable: false),
                        EagleParkBrewing = c.Boolean(nullable: false),
                        Enlightened = c.Boolean(nullable: false),
                        D14 = c.Boolean(nullable: false),
                        StFrancis = c.Boolean(nullable: false),
                        CompanyBrewing = c.Boolean(nullable: false),
                        GatheringPlace = c.Boolean(nullable: false),
                        CityLights = c.Boolean(nullable: false),
                        BrokenBat = c.Boolean(nullable: false),
                        BlackHusky = c.Boolean(nullable: false),
                        NewBarons = c.Boolean(nullable: false),
                        Sprecher = c.Boolean(nullable: false),
                        RaisedGrain = c.Boolean(nullable: false),
                        Fermentorium = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UrlSlug = c.String(),
                        Beer = c.Boolean(nullable: false),
                        Brewery = c.Boolean(nullable: false),
                        Event = c.Boolean(nullable: false),
                        People = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ListOfBeerLists",
                c => new
                    {
                        ListId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ListId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.UntappedBreweries",
                c => new
                    {
                        bid = c.Int(nullable: false, identity: true),
                        breweryName = c.String(),
                        untappedBid = c.Int(nullable: false),
                        breweryInfo = c.String(),
                    })
                .PrimaryKey(t => t.bid);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.PostBeerStyles",
                c => new
                    {
                        Post_Id = c.Int(nullable: false),
                        BeerStyles_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Post_Id, t.BeerStyles_Id })
                .ForeignKey("dbo.Posts", t => t.Post_Id, cascadeDelete: true)
                .ForeignKey("dbo.BeerStyles", t => t.BeerStyles_Id, cascadeDelete: true)
                .Index(t => t.Post_Id)
                .Index(t => t.BeerStyles_Id);
            
            CreateTable(
                "dbo.MilwaukeeBreweriesPosts",
                c => new
                    {
                        MilwaukeeBreweries_Id = c.Int(nullable: false),
                        Post_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MilwaukeeBreweries_Id, t.Post_Id })
                .ForeignKey("dbo.MilwaukeeBreweries", t => t.MilwaukeeBreweries_Id, cascadeDelete: true)
                .ForeignKey("dbo.Posts", t => t.Post_Id, cascadeDelete: true)
                .Index(t => t.MilwaukeeBreweries_Id)
                .Index(t => t.Post_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.BeerListObjects", "ListOfBeerLists_ListId", "dbo.ListOfBeerLists");
            DropForeignKey("dbo.Posts", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.MilwaukeeBreweriesPosts", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.MilwaukeeBreweriesPosts", "MilwaukeeBreweries_Id", "dbo.MilwaukeeBreweries");
            DropForeignKey("dbo.PostBeerStyles", "BeerStyles_Id", "dbo.BeerStyles");
            DropForeignKey("dbo.PostBeerStyles", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.BeerListObjects", "response_id", "dbo.Responses");
            DropForeignKey("dbo.Responses", "collaborations_id", "dbo.Collaborations");
            DropForeignKey("dbo.Responses", "beers_id", "dbo.Beers");
            DropForeignKey("dbo.Items", "Beers_id", "dbo.Beers");
            DropForeignKey("dbo.Items", "friends_id", "dbo.Friends");
            DropForeignKey("dbo.Items", "brewery_brewery_id", "dbo.Breweries");
            DropForeignKey("dbo.Breweries", "location_id", "dbo.Locations");
            DropForeignKey("dbo.Breweries", "contact_id", "dbo.Contacts");
            DropForeignKey("dbo.Items", "beer_bid", "dbo.Beers1");
            DropForeignKey("dbo.BeerListObjects", "meta_id", "dbo.Metas");
            DropForeignKey("dbo.Metas", "response_time_id", "dbo.ResponseTimes");
            DropForeignKey("dbo.Metas", "init_time_id", "dbo.InitTimes");
            DropIndex("dbo.MilwaukeeBreweriesPosts", new[] { "Post_Id" });
            DropIndex("dbo.MilwaukeeBreweriesPosts", new[] { "MilwaukeeBreweries_Id" });
            DropIndex("dbo.PostBeerStyles", new[] { "BeerStyles_Id" });
            DropIndex("dbo.PostBeerStyles", new[] { "Post_Id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Posts", new[] { "Category_Id" });
            DropIndex("dbo.Breweries", new[] { "location_id" });
            DropIndex("dbo.Breweries", new[] { "contact_id" });
            DropIndex("dbo.Items", new[] { "Beers_id" });
            DropIndex("dbo.Items", new[] { "friends_id" });
            DropIndex("dbo.Items", new[] { "brewery_brewery_id" });
            DropIndex("dbo.Items", new[] { "beer_bid" });
            DropIndex("dbo.Responses", new[] { "collaborations_id" });
            DropIndex("dbo.Responses", new[] { "beers_id" });
            DropIndex("dbo.Metas", new[] { "response_time_id" });
            DropIndex("dbo.Metas", new[] { "init_time_id" });
            DropIndex("dbo.BeerListObjects", new[] { "ListOfBeerLists_ListId" });
            DropIndex("dbo.BeerListObjects", new[] { "response_id" });
            DropIndex("dbo.BeerListObjects", new[] { "meta_id" });
            DropTable("dbo.MilwaukeeBreweriesPosts");
            DropTable("dbo.PostBeerStyles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.UntappedBreweries");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.ListOfBeerLists");
            DropTable("dbo.Categories");
            DropTable("dbo.MilwaukeeBreweries");
            DropTable("dbo.Posts");
            DropTable("dbo.BeerStyles");
            DropTable("dbo.Collaborations");
            DropTable("dbo.Friends");
            DropTable("dbo.Locations");
            DropTable("dbo.Contacts");
            DropTable("dbo.Breweries");
            DropTable("dbo.Items");
            DropTable("dbo.Beers");
            DropTable("dbo.Responses");
            DropTable("dbo.ResponseTimes");
            DropTable("dbo.InitTimes");
            DropTable("dbo.Metas");
            DropTable("dbo.BeerListObjects");
            DropTable("dbo.Beers1");
        }
    }
}
