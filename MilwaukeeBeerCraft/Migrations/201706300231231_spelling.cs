namespace MilwaukeeBeerCraft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class spelling : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Beer", c => c.String());
            DropColumn("dbo.Posts", "Beers");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "Beers", c => c.String());
            DropColumn("dbo.Posts", "Beer");
        }
    }
}
