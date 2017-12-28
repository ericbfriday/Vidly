namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class S3E3PopulateGenreAndUpdateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Name) VALUES(1, 'Comedy')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(2, 'Action')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(3, 'Dramady')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(4, 'Anime')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(5, 'Action')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(6, 'Family')");
        }
        
        public override void Down()
        {
        }
    }
}
