namespace TRANQUOCKHANH_LAP456_BIGSCHOOL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTableCoursse : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "LecturerID_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "LecturerId" });
            DropIndex("dbo.Courses", new[] { "LecturerID_Id" });
            AlterColumn("dbo.Courses", "LecturerId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Courses", "LecturerId");
            AddForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            DropColumn("dbo.Courses", "LecturerID_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "LecturerID_Id", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "LecturerId" });
            AlterColumn("dbo.Courses", "LecturerId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Courses", "LecturerID_Id");
            CreateIndex("dbo.Courses", "LecturerId");
            AddForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Courses", "LecturerID_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
