namespace RegCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class d1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("Student.Registrations", "RegCityId");
            AddForeignKey("Student.Registrations", "RegCityId", "Admin.Cities", "CityId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Student.Registrations", "RegCityId", "Admin.Cities");
            DropIndex("Student.Registrations", new[] { "RegCityId" });
        }
    }
}
