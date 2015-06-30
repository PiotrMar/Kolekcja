namespace Kolekcja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Start : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Elements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Tytul = c.String(),
                        RokWydania = c.DateTime(nullable: false),
                        Gatunek = c.String(),
                        Rodzaj = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Elements");
        }
    }
}
