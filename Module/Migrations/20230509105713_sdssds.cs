using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module.Migrations
{
    /// <inheritdoc />
    public partial class sdssds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityChaesons",
                columns: table => new
                {
                    ActivityChaesonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityChaesonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityChaesonDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityChaesons", x => x.ActivityChaesonID);
                });

            migrationBuilder.CreateTable(
                name: "LocationRests",
                columns: table => new
                {
                    LocationRestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationRestName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationRests", x => x.LocationRestID);
                });

            migrationBuilder.CreateTable(
                name: "LocationTravels",
                columns: table => new
                {
                    LocationTravelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationTravelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationTravelDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationTravels", x => x.LocationTravelID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityChaesons");

            migrationBuilder.DropTable(
                name: "LocationRests");

            migrationBuilder.DropTable(
                name: "LocationTravels");
        }
    }
}
