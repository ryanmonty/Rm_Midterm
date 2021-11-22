namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditCourseStatus : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE CourseStatus ALTER COLUMN Rating nvarchar(255)");
        }
        
        public override void Down()
        {
        }
    }
}
