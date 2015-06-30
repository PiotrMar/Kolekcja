namespace Kolekcja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Walidjacja_pol : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Elements", "Tytul", c => c.String(maxLength: 60));
            AlterColumn("dbo.Elements", "Gatunek", c => c.String(nullable: false, maxLength: 45));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Elements", "Gatunek", c => c.String());
            AlterColumn("dbo.Elements", "Tytul", c => c.String());
        }
    }
}
