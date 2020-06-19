namespace TRANQUOCKHANH_LAP456_BIGSCHOOL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsCanceled = c.Boolean(nullable: false),
                        LecturerId = c.String(maxLength: 128),
                        Place = c.String(nullable: false, maxLength: 255),
                        DateTime = c.DateTime(nullable: false),
                        CategoryId = c.Byte(nullable: false),
                        LecturerID_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.LecturerId)
                .ForeignKey("dbo.AspNetUsers", t => t.LecturerID_Id, cascadeDelete: true)
                .Index(t => t.LecturerId)
                .Index(t => t.CategoryId)
                .Index(t => t.LecturerID_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "LecturerID_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "LecturerID_Id" });
            DropIndex("dbo.Courses", new[] { "CategoryId" });
            DropIndex("dbo.Courses", new[] { "LecturerId" });
            DropTable("dbo.Courses");
            DropTable("dbo.Categories");
        }
    }
}
