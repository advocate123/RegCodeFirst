namespace RegCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class citylistcreated : DbMigration
    {
        public override void Up()
        {
            AddColumn("Admin.Cities", "Registration_RegId", c => c.Int());
            CreateIndex("Admin.Cities", "Registration_RegId");
            AddForeignKey("Admin.Cities", "Registration_RegId", "Student.Registrations", "RegId");
        }
        
        public override void Down()
        {
            DropForeignKey("Admin.Cities", "Registration_RegId", "Student.Registrations");
            DropIndex("Admin.Cities", new[] { "Registration_RegId" });
            DropColumn("Admin.Cities", "Registration_RegId");
        }
    }
}
