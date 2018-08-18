namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSuscribedToCostumer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSuscribedToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSuscribedToNewsLetter");
        }
    }
}
