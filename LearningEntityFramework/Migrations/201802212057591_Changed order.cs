namespace LearningEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changedorder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "OrderDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "OrderDescription");
            DropColumn("dbo.Orders", "OrderDate");
        }
    }
}
