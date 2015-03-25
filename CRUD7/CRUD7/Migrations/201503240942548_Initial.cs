namespace CRUD7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        title = c.String(nullable: false),
                        description = c.String(),
                        year = c.Int(nullable: false),
                        isbn = c.String(),
                        stock = c.Int(nullable: false),
                        ratingId = c.Int(nullable: false),
                        imagesId = c.Int(nullable: false),
                        genresId = c.Int(nullable: false),
                        authorsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.authors", t => t.authorsId, cascadeDelete: true)
                .ForeignKey("dbo.genres", t => t.genresId, cascadeDelete: true)
                .ForeignKey("dbo.images", t => t.imagesId, cascadeDelete: true)
                .ForeignKey("dbo.ratings", t => t.ratingId, cascadeDelete: true)
                .Index(t => t.authorsId)
                .Index(t => t.genresId)
                .Index(t => t.imagesId)
                .Index(t => t.ratingId);
            
            CreateTable(
                "dbo.genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        genre = c.String(nullable: false),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        imageUrl = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ratings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        rate = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.books", "ratingId", "dbo.ratings");
            DropForeignKey("dbo.books", "imagesId", "dbo.images");
            DropForeignKey("dbo.books", "genresId", "dbo.genres");
            DropForeignKey("dbo.books", "authorsId", "dbo.authors");
            DropIndex("dbo.books", new[] { "ratingId" });
            DropIndex("dbo.books", new[] { "imagesId" });
            DropIndex("dbo.books", new[] { "genresId" });
            DropIndex("dbo.books", new[] { "authorsId" });
            DropTable("dbo.ratings");
            DropTable("dbo.images");
            DropTable("dbo.genres");
            DropTable("dbo.books");
            DropTable("dbo.authors");
        }
    }
}
