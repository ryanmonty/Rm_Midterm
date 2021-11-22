namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseTutors : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Courses SET TutorName = 'S. Herwood' WHERE Id=1");
            Sql("UPDATE Courses SET TutorName = 'M. Rosas' WHERE Id=2");
            Sql("UPDATE Courses SET TutorName = 'J. Spranks' WHERE Id=3");
            Sql("UPDATE Courses SET TutorName = 'G. Haskins' WHERE Id=4");
            Sql("UPDATE Courses SET TutorName = 'V. Bramble' WHERE Id=5");
            Sql("UPDATE Courses SET TutorName = 'J. Powers' WHERE Id=6");
            Sql("UPDATE Courses SET TutorName = 'G. Rockfist' WHERE Id=7");
            Sql("UPDATE Courses SET TutorName = 'F. Tanaki' WHERE Id=8");
            Sql("UPDATE Courses SET TutorName = 'B. Mulligan' WHERE Id=9");
        }

        public override void Down()
        {
        }
    }
}
