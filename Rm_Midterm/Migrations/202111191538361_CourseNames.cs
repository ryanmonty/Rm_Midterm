namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseNames : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses (CourseName, CourseRating) VALUES ('Drawing Fundamentals', 1)");
            Sql("INSERT INTO Courses (CourseName, CourseRating) VALUES ('Figure Drawing', 3)");
            Sql("INSERT INTO Courses (CourseName, CourseRating) VALUES ('Experimental Oil Painting', 7)");
            Sql("INSERT INTO Courses (CourseName, CourseRating) VALUES ('Intro to Sculpture', 2)");
            Sql("INSERT INTO Courses (CourseName, CourseRating) VALUES ('Ceramics', 4)");
            Sql("INSERT INTO Courses (CourseName, CourseRating) VALUES ('Blacksmithing and Welding', 9)");
            Sql("INSERT INTO Courses (CourseName, CourseRating) VALUES ('Prehistoric through Medieval Arts', 2)");
            Sql("INSERT INTO Courses (CourseName, CourseRating) VALUES ('Modern Art - 20th century and Beyond', 5)");
            Sql("INSERT INTO Courses (CourseName, CourseRating) VALUES ('Greek Mythology in Pottery', 8)");
        }

        public override void Down()
        {
        }
    }
}
