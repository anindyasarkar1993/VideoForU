namespace VideoForU.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreAdded : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genre values (1,'Animation')");
            Sql("Insert into Genre values (2,'Comedy')");
            Sql("Insert into Genre values (3,'Horror')");
            Sql("Insert into Genre values (4,'Romance')");
            Sql("Insert into Genre values (5,'Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
