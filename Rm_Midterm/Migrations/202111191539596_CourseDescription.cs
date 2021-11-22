namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseDescription : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Courses SET CourseDescription = 'Intro 2D Art' WHERE Id=1");
            Sql("UPDATE Courses SET CourseDescription = 'Intermediate 2D Art' WHERE Id=2");
            Sql("UPDATE Courses SET CourseDescription = 'Advanced 2D Art' WHERE Id=3");
            Sql("UPDATE Courses SET CourseDescription = 'Intro 3D Art' WHERE Id=4");
            Sql("UPDATE Courses SET CourseDescription = 'Intermediate 3D Art' WHERE Id=5");
            Sql("UPDATE Courses SET CourseDescription = 'Advanced 3D Art' WHERE Id=6");
            Sql("UPDATE Courses SET CourseDescription = 'Intro Art History' WHERE Id=7");
            Sql("UPDATE Courses SET CourseDescription = 'Intermediate Art History' WHERE Id=8");
            Sql("UPDATE Courses SET CourseDescription = 'Advanced Art History' WHERE Id=9");
        }

        public override void Down()
        {
        }
    }
}
