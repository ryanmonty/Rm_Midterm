namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReseedCourseStatus : DbMigration
    {
        public override void Up()
        {
            Sql("DBCC CHECKIDENT ('CourseStatus', RESEED, 1)");
        }
        
        public override void Down()
        {
        }
    }
}
