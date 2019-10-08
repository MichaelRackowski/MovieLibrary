namespace MovieLibraryProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String());
            DropColumn("dbo.Movies", "Genere");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Genere", c => c.String());
            DropColumn("dbo.Movies", "Genre");
        }
    }
}
