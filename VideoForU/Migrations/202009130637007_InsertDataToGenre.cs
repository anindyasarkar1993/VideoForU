namespace VideoForU.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDataToGenre : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres values (1,'Animation')");
            Sql("Insert into Genres values (2,'Comedy')");
            Sql("Insert into Genres values (3,'Horror')");
            Sql("Insert into Genres values (4,'Romance')");
            Sql("Insert into Genres values (5,'Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
