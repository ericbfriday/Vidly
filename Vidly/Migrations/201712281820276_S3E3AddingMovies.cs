namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class S3E3AddingMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, Genre, Stock) VALUES('Good Will Hunting', '12/04/1994', '12/07/1994', 'Dramady', 5)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, Genre, Stock) VALUES('Terminator', '08/12/1994', '08/13/1994', 'Action', 2)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, Genre, Stock) VALUES('Shrek!', '05/18/2009', '06/28/2009', 'Family', 8)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, Genre, Stock) VALUES('Romancing the Stone', '10/30/1983', '10/31/1983', 'Comedy', 1)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, Genre, Stock) VALUES('Indiana Jones', '12/25/1986', '01/18/1987', 'Action', 4)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, Genre, Stock) VALUES('Howls Moving Castle', '08/13/1997', '08/13/1997', 'Anime', 19)");
        }
        
        public override void Down()
        {
        }
    }
}
