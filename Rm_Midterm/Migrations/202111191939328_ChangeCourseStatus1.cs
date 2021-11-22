namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCourseStatus1 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT CourseStatus ON ");
            Sql("INSERT INTO CourseStatus(Id, Rating) VALUES(1, 'In Progress')");
            Sql("INSERT INTO CourseStatus(Id, Rating) VALUES(2, 'Completed')");
        }
        
        public override void Down()
        {
        }
    }
}
