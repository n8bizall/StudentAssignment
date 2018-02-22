namespace StudentAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingForiegnKeytoNametable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NameOfStudents", "CollegeOfStudentId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NameOfStudents", "CollegeOfStudentId");
        }
    }
}
