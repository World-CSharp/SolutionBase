namespace Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aproaches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdStateApproaches = c.Int(nullable: false),
                        IdTypeSolution = c.Int(nullable: false),
                        Topic = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false),
                        Label = c.String(),
                        Date = c.DateTime(nullable: false),
                        IdUser = c.Int(nullable: false),
                        Registered_By = c.String(nullable: false, maxLength: 30),
                        Registered_On = c.DateTime(nullable: false),
                        Modified_By = c.String(),
                        Modified_On = c.DateTime(nullable: false),
                        StateApproaches_Id = c.Int(nullable: false),
                        TypeSolution_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StateApproaches", t => t.StateApproaches_Id, cascadeDelete: true)
                .ForeignKey("dbo.TypeSolutions", t => t.TypeSolution_Id, cascadeDelete: true)
                .Index(t => t.StateApproaches_Id)
                .Index(t => t.TypeSolution_Id);
            
            CreateTable(
                "dbo.DetailedApproaches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        Comment = c.String(maxLength: 2000),
                        PositivePoint = c.Int(),
                        NegativePoint = c.Int(),
                        Registered_By = c.String(nullable: false, maxLength: 30),
                        Registered_On = c.DateTime(nullable: false),
                        Modified_By = c.String(),
                        Modified_On = c.DateTime(nullable: false),
                        Aproaches_Id = c.Int(nullable: false),
                        StateDetailApproaches_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aproaches", t => t.Aproaches_Id, cascadeDelete: true)
                .ForeignKey("dbo.StateDetailApproaches", t => t.StateDetailApproaches_Id, cascadeDelete: true)
                .Index(t => t.Aproaches_Id)
                .Index(t => t.StateDetailApproaches_Id);
            
            CreateTable(
                "dbo.StateDetailApproaches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 50),
                        Registered_By = c.String(),
                        Registered_On = c.DateTime(nullable: false),
                        Modified_By = c.String(),
                        Modified_On = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StateApproaches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 50),
                        Registered_By = c.String(),
                        Registered_On = c.DateTime(nullable: false),
                        Modified_By = c.String(),
                        Modified_On = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeSolutions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 50),
                        Registered_By = c.String(),
                        Registered_On = c.DateTime(nullable: false),
                        Modified_By = c.String(),
                        Modified_On = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Labels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 50),
                        Comment = c.String(maxLength: 100),
                        Registered_By = c.String(nullable: false, maxLength: 30),
                        Registered_On = c.DateTime(nullable: false),
                        Modified_By = c.String(),
                        Modified_On = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 100),
                        Slogan = c.String(maxLength: 50),
                        Logo = c.Binary(),
                        Email = c.String(maxLength: 100),
                        PhoneNumber = c.String(maxLength: 15),
                        Comment = c.String(maxLength: 200),
                        Registered_By = c.String(nullable: false, maxLength: 30),
                        Registered_On = c.DateTime(nullable: false),
                        Modified_By = c.String(),
                        Modified_On = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 100),
                        Comment = c.String(maxLength: 200),
                        Registered_By = c.String(nullable: false, maxLength: 30),
                        Registered_On = c.DateTime(nullable: false),
                        Modified_By = c.String(),
                        Modified_On = c.DateTime(nullable: false),
                        Organization_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.Organization_Id, cascadeDelete: true)
                .Index(t => t.Organization_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Registered_By = c.String(),
                        Registered_On = c.DateTime(nullable: false),
                        Modified_By = c.String(),
                        Modified_On = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.Aproaches", "TypeSolution_Id", "dbo.TypeSolutions");
            DropForeignKey("dbo.Aproaches", "StateApproaches_Id", "dbo.StateApproaches");
            DropForeignKey("dbo.DetailedApproaches", "StateDetailApproaches_Id", "dbo.StateDetailApproaches");
            DropForeignKey("dbo.DetailedApproaches", "Aproaches_Id", "dbo.Aproaches");
            DropIndex("dbo.Projects", new[] { "Organization_Id" });
            DropIndex("dbo.DetailedApproaches", new[] { "StateDetailApproaches_Id" });
            DropIndex("dbo.DetailedApproaches", new[] { "Aproaches_Id" });
            DropIndex("dbo.Aproaches", new[] { "TypeSolution_Id" });
            DropIndex("dbo.Aproaches", new[] { "StateApproaches_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Projects");
            DropTable("dbo.Organizations");
            DropTable("dbo.Labels");
            DropTable("dbo.TypeSolutions");
            DropTable("dbo.StateApproaches");
            DropTable("dbo.StateDetailApproaches");
            DropTable("dbo.DetailedApproaches");
            DropTable("dbo.Aproaches");
        }
    }
}
