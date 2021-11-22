namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "BirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "BirthDate");
        }
    }
}
