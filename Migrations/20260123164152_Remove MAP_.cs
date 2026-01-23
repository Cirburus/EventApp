using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventsApp.Migrations
{
    /// <inheritdoc />
    public partial class RemoveMAP_ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "MAP_EVENTUSER",
                schema: "EVENTSAPP_MAP",
                newName: "EVENTUSER",
                newSchema: "EVENTSAPP_MAP");

            migrationBuilder.RenameTable(
                name: "MAP_EVENTTEAMUSER",
                schema: "EVENTSAPP_MAP",
                newName: "EVENTTEAMUSER",
                newSchema: "EVENTSAPP_MAP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "EVENTUSER",
                schema: "EVENTSAPP_MAP",
                newName: "MAP_EVENTUSER",
                newSchema: "EVENTSAPP_MAP");

            migrationBuilder.RenameTable(
                name: "EVENTTEAMUSER",
                schema: "EVENTSAPP_MAP",
                newName: "MAP_EVENTTEAMUSER",
                newSchema: "EVENTSAPP_MAP");
        }
    }
}
