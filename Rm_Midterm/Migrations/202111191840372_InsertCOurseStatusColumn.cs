namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertCOurseStatusColumn : DbMigration
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
            
            CreateIndex("dbo.Students", "CourseId");
            AddForeignKey("dbo.Students", "CourseId", "dbo.CourseStatus", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "CourseId", "dbo.CourseStatus");
            DropIndex("dbo.Students", new[] { "CourseId" });
            DropTable("dbo.CourseStatus");
        }
    }
}
