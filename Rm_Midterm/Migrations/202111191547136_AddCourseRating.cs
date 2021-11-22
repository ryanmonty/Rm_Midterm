namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourseRating : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseRatings",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Rating = c.Byte(nullable: false),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.CourseRatings");
        }
    }
}
