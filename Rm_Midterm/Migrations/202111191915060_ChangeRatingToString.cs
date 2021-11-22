namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeRatingToString : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE CourseStatus ALTER COLUMN Rating nvarchar");
        }
        
        public override void Down()
        {
        }
    }
}
