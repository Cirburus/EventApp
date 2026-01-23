using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventsApp.Migrations
{
    /// <inheritdoc />
    public partial class CorrectTableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "DAT_USER",
                schema: "EVENTSAPP",
                newName: "USER",
                newSchema: "EVENTSAPP");

            migrationBuilder.RenameTable(
                name: "DAT_TEAM",
                schema: "EVENTSAPP",
                newName: "TEAM",
                newSchema: "EVENTSAPP");

            migrationBuilder.RenameTable(
                name: "DAT_SIDEEVENT",
                schema: "EVENTSAPP",
                newName: "SIDEEVENT",
                newSchema: "EVENTSAPP");

            migrationBuilder.RenameTable(
                name: "DAT_ROLE",
                schema: "EVENTSAPP",
                newName: "ROLE",
                newSchema: "EVENTSAPP");

            migrationBuilder.RenameTable(
                name: "DAT_LOCATION",
                schema: "EVENTSAPP",
                newName: "LOCATION",
                newSchema: "EVENTSAPP");

            migrationBuilder.RenameTable(
                name: "DAT_EVENT",
                schema: "EVENTSAPP",
                newName: "EVENT",
                newSchema: "EVENTSAPP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "USER",
                schema: "EVENTSAPP",
                newName: "DAT_USER",
                newSchema: "EVENTSAPP");

            migrationBuilder.RenameTable(
                name: "TEAM",
                schema: "EVENTSAPP",
                newName: "DAT_TEAM",
                newSchema: "EVENTSAPP");

            migrationBuilder.RenameTable(
                name: "SIDEEVENT",
                schema: "EVENTSAPP",
                newName: "DAT_SIDEEVENT",
                newSchema: "EVENTSAPP");

            migrationBuilder.RenameTable(
                name: "ROLE",
                schema: "EVENTSAPP",
                newName: "DAT_ROLE",
                newSchema: "EVENTSAPP");

            migrationBuilder.RenameTable(
                name: "LOCATION",
                schema: "EVENTSAPP",
                newName: "DAT_LOCATION",
                newSchema: "EVENTSAPP");

            migrationBuilder.RenameTable(
                name: "EVENT",
                schema: "EVENTSAPP",
                newName: "DAT_EVENT",
                newSchema: "EVENTSAPP");
        }
    }
}
