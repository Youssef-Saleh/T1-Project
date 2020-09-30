namespace Beat.Data.Migrations.Beat
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        JoinDate = c.DateTime(nullable: false),
                        Address = c.String(),
                        University = c.String(),
                        Faculty = c.String(),
                        Department = c.String(),
                        Position = c.Int(nullable: false),
                        Committee_Id = c.Int(),
                        Track_Id = c.Int(),
                        Track_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Committees", t => t.Committee_Id)
                .ForeignKey("dbo.Tracks", t => t.Track_Id)
                .ForeignKey("dbo.Tracks", t => t.Track_Id1)
                .Index(t => t.Committee_Id)
                .Index(t => t.Track_Id)
                .Index(t => t.Track_Id1);
            
            CreateTable(
                "dbo.Committees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Abbreviation = c.String(),
                        Leader_Id = c.Int(),
                        Track_Id = c.Int(),
                        Member_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.Leader_Id)
                .ForeignKey("dbo.Tracks", t => t.Track_Id)
                .ForeignKey("dbo.Members", t => t.Member_Id)
                .Index(t => t.Leader_Id)
                .Index(t => t.Track_Id)
                .Index(t => t.Member_Id);
            
            CreateTable(
                "dbo.Tracks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Abbreviation = c.String(),
                        Leader_Id = c.Int(),
                        Member_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.Leader_Id)
                .ForeignKey("dbo.Members", t => t.Member_Id)
                .Index(t => t.Leader_Id)
                .Index(t => t.Member_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "Track_Id1", "dbo.Tracks");
            DropForeignKey("dbo.Tracks", "Member_Id", "dbo.Members");
            DropForeignKey("dbo.Committees", "Member_Id", "dbo.Members");
            DropForeignKey("dbo.Members", "Track_Id", "dbo.Tracks");
            DropForeignKey("dbo.Tracks", "Leader_Id", "dbo.Members");
            DropForeignKey("dbo.Committees", "Track_Id", "dbo.Tracks");
            DropForeignKey("dbo.Members", "Committee_Id", "dbo.Committees");
            DropForeignKey("dbo.Committees", "Leader_Id", "dbo.Members");
            DropIndex("dbo.Tracks", new[] { "Member_Id" });
            DropIndex("dbo.Tracks", new[] { "Leader_Id" });
            DropIndex("dbo.Committees", new[] { "Member_Id" });
            DropIndex("dbo.Committees", new[] { "Track_Id" });
            DropIndex("dbo.Committees", new[] { "Leader_Id" });
            DropIndex("dbo.Members", new[] { "Track_Id1" });
            DropIndex("dbo.Members", new[] { "Track_Id" });
            DropIndex("dbo.Members", new[] { "Committee_Id" });
            DropTable("dbo.Tracks");
            DropTable("dbo.Committees");
            DropTable("dbo.Members");
        }
    }
}
