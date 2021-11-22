namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReseedRetry : DbMigration
    {
        public override void Up()
        {
            Sql("DBCC CHECKIDENT ('CourseStatus', RESEED, 0)");
        }
        
        public override void Down()
        {
        }
    }
}
