namespace VideoForU.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMovieData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, StockCount) VALUES ('Hang Over 3',5, '2012-06-18', '2012-06-18',3)");
            
        }
        
        public override void Down()
        {
        }
    }
}
