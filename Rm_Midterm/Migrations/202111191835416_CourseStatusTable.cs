namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseStatusTable : DbMigration
    {
        public override void Up()
        {
            Sql("CREATE TABLE CourseStatus (Id int, Name varchar(255))");
        }
        
        public override void Down()
        {
        }
    }
}
