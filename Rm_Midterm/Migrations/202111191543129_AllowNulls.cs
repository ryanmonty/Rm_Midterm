namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllowNulls : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Students ALTER COLUMN CourseId int NULL");
            Sql("ALTER TABLE Students ALTER COLUMN CourseEnrolledDate datetime NULL");
            Sql("ALTER TABLE Students ALTER COLUMN CourseStatusId int NULL");
        }

        public override void Down()
        {
        }
    }
}
