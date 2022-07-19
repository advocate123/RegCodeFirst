namespace RegCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class statelistcreated : DbMigration
    {
        public override void Up()
        {
            AddColumn("Admin.States", "City_CityId", c => c.Int());
            CreateIndex("Admin.States", "City_CityId");
            AddForeignKey("Admin.States", "City_CityId", "Admin.Cities", "CityId");
        }
        
        public override void Down()
        {
            DropForeignKey("Admin.States", "City_CityId", "Admin.Cities");
            DropIndex("Admin.States", new[] { "City_CityId" });
            DropColumn("Admin.States", "City_CityId");
        }
    }
}
