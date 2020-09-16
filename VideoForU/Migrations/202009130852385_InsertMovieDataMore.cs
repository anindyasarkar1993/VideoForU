namespace VideoForU.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMovieDataMore : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, StockCount) VALUES ('Ramleela',4, '2012-06-18', '2012-06-18',30)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, StockCount) VALUES ('DJ',5, '2018-06-18', '2018-06-18',35)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, StockCount) VALUES ('Junglee',1, '2017-06-18', '2017-06-18',35)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, StockCount) VALUES ('Gotro',5, '2018-06-16', '2018-06-18',300)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, StockCount) VALUES ('Lathi',2, '2011-06-13', '2018-06-18',32)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, StockCount) VALUES ('Awarapan',5, '2018-06-16', '2018-06-18',36)");

        }
        
        public override void Down()
        {
        }
    }
}
