namespace Kolekcja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Autor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Elements", "Autor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Elements", "Autor");
        }
    }
}
