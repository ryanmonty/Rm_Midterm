namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCourseStatus : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT CourseStatus ON ");
            
        }
        
        public override void Down()
        {
        }
    }
}
