namespace Contrucks.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class check : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contractors", "UserTables_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Contractors", "UserTables_Id");
            AddForeignKey("dbo.Contractors", "UserTables_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contractors", "UserTables_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Contractors", new[] { "UserTables_Id" });
            DropColumn("dbo.Contractors", "UserTables_Id");
        }
    }
}
