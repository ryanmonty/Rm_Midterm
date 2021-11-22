namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class DropForeignKey : DbMigration

    { 
        public override void Up()
    {
        CreateTable(
            "dbo.CourseStatus",
            c => new
            {
                Id = c.Int(nullable: false, identity: true),
                Name = c.String(),
            })
            .PrimaryKey(t => t.Id);

        CreateIndex("dbo.Students", "CourseStatusId");
        AddForeignKey("dbo.Students", "CourseStatusId", "dbo.CourseStatus", "Id", cascadeDelete: true);
    }

    public override void Down()
    {
        DropForeignKey("dbo.Students", "CourseStatusId", "dbo.CourseStatus");
        DropIndex("dbo.Students", new[] { "CourseStatusId" });
        DropTable("dbo.CourseStatus");
    }
}

}
