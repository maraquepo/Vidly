namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoviesData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Shrek', 3, 01/01/2001, 01/01/2001, 5)");

        }

        public override void Down()
        {
        }
    }
}
