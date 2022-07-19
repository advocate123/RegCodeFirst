namespace RegCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fkeyadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Admin.States",
                c => new
                    {
                        StateId = c.Int(nullable: false, identity: true),
                        StateName = c.String(),
                        StateCntId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StateId)
                .ForeignKey("Admin.Country", t => t.StateCntId, cascadeDelete: true)
                .Index(t => t.StateCntId);
            
            CreateTable(
                "Admin.Country",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryName = c.String(),
                    })
                .PrimaryKey(t => t.CountryId);
            
            AddColumn("Admin.Cities", "CityStateId", c => c.Int(nullable: false));
            CreateIndex("Admin.Cities", "CityStateId");
            AddForeignKey("Admin.Cities", "CityStateId", "Admin.States", "StateId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Admin.Cities", "CityStateId", "Admin.States");
            DropForeignKey("Admin.States", "StateCntId", "Admin.Country");
            DropIndex("Admin.States", new[] { "StateCntId" });
            DropIndex("Admin.Cities", new[] { "CityStateId" });
            DropColumn("Admin.Cities", "CityStateId");
            DropTable("Admin.Country");
            DropTable("Admin.States");
        }
    }
}
