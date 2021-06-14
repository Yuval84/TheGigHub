namespace TheGigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class populateGeneresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Jazz')");
            Sql("INSERT INTO Genres (Name) VALUES ('Rock')");
            Sql("INSERT INTO Genres (Name) VALUES ('Metal')");
            Sql("INSERT INTO Genres (Name) VALUES ('Classic')");
            Sql("INSERT INTO Genres (Name) VALUES ('HipHop')");
            Sql("INSERT INTO Genres (Name) VALUES ('Blues')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1, 2, 3, 4, 5, 6)");
        }
    }
}
