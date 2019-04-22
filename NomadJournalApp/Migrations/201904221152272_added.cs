namespace NomadJournalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Issues", "User_Id", c => c.Guid());
            CreateIndex("dbo.Issues", "User_Id");
            AddForeignKey("dbo.Issues", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Issues", "User_Id", "dbo.Users");
            DropIndex("dbo.Issues", new[] { "User_Id" });
            DropColumn("dbo.Issues", "User_Id");
        }
    }
}
