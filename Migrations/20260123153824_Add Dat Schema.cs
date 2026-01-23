using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventsApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDatSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "EVENTSAPP_DAT");

            migrationBuilder.RenameTable(
                name: "USER",
                schema: "EVENTSAPP",
                newName: "USER",
                newSchema: "EVENTSAPP_DAT");

            migrationBuilder.RenameTable(
                name: "TEAM",
                schema: "EVENTSAPP",
                newName: "TEAM",
                newSchema: "EVENTSAPP_DAT");

            migrationBuilder.RenameTable(
                name: "SIDEEVENT",
                schema: "EVENTSAPP",
                newName: "SIDEEVENT",
                newSchema: "EVENTSAPP_DAT");

            migrationBuilder.RenameTable(
                name: "ROLE",
                schema: "EVENTSAPP",
                newName: "ROLE",
                newSchema: "EVENTSAPP_DAT");

            migrationBuilder.RenameTable(
                name: "LOCATION",
                schema: "EVENTSAPP",
                newName: "LOCATION",
                newSchema: "EVENTSAPP_DAT");

            migrationBuilder.RenameTable(
                name: "EVENT",
                schema: "EVENTSAPP",
                newName: "EVENT",
                newSchema: "EVENTSAPP_DAT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "USER",
                schema: "EVENTSAPP_DAT",
                newName: "USER",
                newSchema: "EVENTSAPP");

            migrationBuilder.RenameTable(
                name: "TEAM",
                schema: "EVENTSAPP_DAT",
                newName: "TEAM",
                newSchema: "EVENTSAPP");

            migrationBuilder.RenameTable(
                name: "SIDEEVENT",
                schema: "EVENTSAPP_DAT",
                newName: "SIDEEVENT",
                newSchema: "EVENTSAPP");

            migrationBuilder.RenameTable(
                name: "ROLE",
                schema: "EVENTSAPP_DAT",
                newName: "ROLE",
                newSchema: "EVENTSAPP");

            migrationBuilder.RenameTable(
                name: "LOCATION",
                schema: "EVENTSAPP_DAT",
                newName: "LOCATION",
                newSchema: "EVENTSAPP");

            migrationBuilder.RenameTable(
                name: "EVENT",
                schema: "EVENTSAPP_DAT",
                newName: "EVENT",
                newSchema: "EVENTSAPP");
        }
    }
}
