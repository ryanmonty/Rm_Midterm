namespace Rm_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStudentNames : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Students (FirstName, LastName) VALUES ('Ryan', 'Montelibano')");
            Sql("INSERT INTO Students (FirstName, LastName) VALUES ('Florentine', 'Friedrich')");
            Sql("INSERT INTO Students (FirstName, LastName) VALUES ('Sudheer', 'Kurup')");

        }

        public override void Down()
        {
        }
    }
}
