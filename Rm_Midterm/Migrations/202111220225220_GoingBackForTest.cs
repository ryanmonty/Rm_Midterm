namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GoingBackForTest : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "FirstName", c => c.String());
            AlterColumn("dbo.Students", "Grade", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Grade", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false));
        }
    }
}
