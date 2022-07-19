namespace RegCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbcreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Admin.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "Student.Registrations",
                c => new
                    {
                        RegId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        EMail = c.String(),
                        RegCityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RegId);
            
        }
        
        public override void Down()
        {
            DropTable("Student.Registrations");
            DropTable("Admin.Cities");
        }
    }
}
