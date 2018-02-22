namespace StudentAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedmaxlimittomajor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CollegeOfStudents", "Major", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CollegeOfStudents", "Major", c => c.String());
        }
    }
}
