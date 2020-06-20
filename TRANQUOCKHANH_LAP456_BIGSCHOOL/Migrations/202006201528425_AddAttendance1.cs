namespace TRANQUOCKHANH_LAP456_BIGSCHOOL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendance1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendance1",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        AttendeeId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.CourseId, t.AttendeeId })
                .ForeignKey("dbo.AspNetUsers", t => t.AttendeeId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .Index(t => t.CourseId)
                .Index(t => t.AttendeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendance1", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Attendance1", "AttendeeId", "dbo.AspNetUsers");
            DropIndex("dbo.Attendance1", new[] { "AttendeeId" });
            DropIndex("dbo.Attendance1", new[] { "CourseId" });
            DropTable("dbo.Attendance1");
        }
    }
}
