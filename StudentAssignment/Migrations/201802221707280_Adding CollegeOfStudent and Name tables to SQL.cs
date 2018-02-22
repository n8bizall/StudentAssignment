namespace StudentAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingCollegeOfStudentandNametablestoSQL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CollegeOfStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MyProperty = c.String(nullable: false, maxLength: 30),
                        Major = c.String(),
                        GradYear = c.Int(nullable: false),
                        GradWithHonors = c.Boolean(nullable: false),
                        AlumniDoner = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NameOfStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NameOfStudents");
            DropTable("dbo.CollegeOfStudents");
        }
    }
}
