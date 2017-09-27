namespace Contrucks.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LoadTypes", "LoadName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LoadTypes", "LoadName");
        }
    }
}
