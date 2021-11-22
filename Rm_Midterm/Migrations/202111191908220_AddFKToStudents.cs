namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFKToStudents : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Students ADD FOREIGN KEY(CourseStatusId) REFERENCES CourseStatus(Id); ");
        }
        
        public override void Down()
        {
        }
    }
}
