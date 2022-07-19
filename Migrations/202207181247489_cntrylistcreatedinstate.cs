namespace RegCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cntrylistcreatedinstate : DbMigration
    {
        public override void Up()
        {
            AddColumn("Admin.Country", "State_StateId", c => c.Int());
            CreateIndex("Admin.Country", "State_StateId");
            AddForeignKey("Admin.Country", "State_StateId", "Admin.States", "StateId");
        }
        
        public override void Down()
        {
            DropForeignKey("Admin.Country", "State_StateId", "Admin.States");
            DropIndex("Admin.Country", new[] { "State_StateId" });
            DropColumn("Admin.Country", "State_StateId");
        }
    }
}
