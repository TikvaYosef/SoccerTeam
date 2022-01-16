namespace SoccerTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Fname = c.String(nullable: false),
                        Lname = c.String(nullable: false, maxLength: 15),
                        position = c.String(),
                        age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Players");
        }
    }
}
