using System;
using EFCore.Snowflake.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventsApp.Migrations
{
    /// <inheritdoc />
    public partial class Refactor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "EVENTSAPP_DAT");

            migrationBuilder.EnsureSchema(
                name: "EVENTSAPP_MAP");

            migrationBuilder.CreateTable(
                name: "EVENT",
                schema: "EVENTSAPP_DAT",
                columns: table => new
                {
                    EVENTID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: false)
                        .Annotation("Snowflake:Identity", "START 1 INCREMENT 1 NOORDER")
                        .Annotation("Snowflake:ValueGenerationStrategy", SnowflakeValueGenerationStrategy.AutoIncrement),
                    EVENTNAME = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    EVENTDESC = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: true),
                    EVENTCOST = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: true),
                    EVENTSTART = table.Column<DateTime>(type: "TIMESTAMP_NTZ(9)", nullable: true),
                    EVENTEND = table.Column<DateTime>(type: "TIMESTAMP_NTZ(9)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_CONSTRAINT_ac76d4d1-1630-46ef-a5e4-3f4e04cfaddc", x => x.EVENTID);
                })
                .Annotation("Snowflake:TableType", SnowflakeTableType.Permanent);

            migrationBuilder.CreateTable(
                name: "LOCATION",
                schema: "EVENTSAPP_DAT",
                columns: table => new
                {
                    LOCATIONID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: false)
                        .Annotation("Snowflake:Identity", "START 1 INCREMENT 1 NOORDER")
                        .Annotation("Snowflake:ValueGenerationStrategy", SnowflakeValueGenerationStrategy.AutoIncrement),
                    LOCATIONNAME = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: true),
                    LOCATIONADDRESS1 = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: true),
                    LOCATIONADDRESS2 = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: true),
                    LOCATIONCITY = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: true),
                    LOCATIONSTATEPROV = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: true),
                    LOCATIONPOSTCODE = table.Column<string>(type: "VARCHAR(10)", maxLength: 10, nullable: true),
                    LOCATIONREMOTE = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: true),
                    LOCATIONEMAIL = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: true),
                    LOCATIONPHONE = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_CONSTRAINT_d082a293-d8bd-4531-8502-d17d075c4562", x => x.LOCATIONID);
                })
                .Annotation("Snowflake:TableType", SnowflakeTableType.Permanent);

            migrationBuilder.CreateTable(
                name: "ROLE",
                schema: "EVENTSAPP_DAT",
                columns: table => new
                {
                    ROLEID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: false)
                        .Annotation("Snowflake:Identity", "START 1 INCREMENT 1 NOORDER")
                        .Annotation("Snowflake:ValueGenerationStrategy", SnowflakeValueGenerationStrategy.AutoIncrement),
                    ROLENAME = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    ROLEDESC = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_CONSTRAINT_4108a80a-0971-4aa5-9238-8887cc26873b", x => x.ROLEID);
                })
                .Annotation("Snowflake:TableType", SnowflakeTableType.Permanent);

            migrationBuilder.CreateTable(
                name: "SIDEEVENT",
                schema: "EVENTSAPP_DAT",
                columns: table => new
                {
                    SIDEEVENTID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: false)
                        .Annotation("Snowflake:Identity", "START 1 INCREMENT 1 NOORDER")
                        .Annotation("Snowflake:ValueGenerationStrategy", SnowflakeValueGenerationStrategy.AutoIncrement),
                    SIDEEVENTNAME = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    SIDEEVENTDESC = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: true),
                    SIDEEVENTCOST = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_CONSTRAINT_469cadd1-282a-496d-9d63-d8f3690a375a", x => x.SIDEEVENTID);
                })
                .Annotation("Snowflake:TableType", SnowflakeTableType.Permanent);

            migrationBuilder.CreateTable(
                name: "TEAM",
                schema: "EVENTSAPP_DAT",
                columns: table => new
                {
                    TEAMID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: false)
                        .Annotation("Snowflake:Identity", "START 1 INCREMENT 1 NOORDER")
                        .Annotation("Snowflake:ValueGenerationStrategy", SnowflakeValueGenerationStrategy.AutoIncrement),
                    TEAMNAME = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_CONSTRAINT_f9bfe607-791d-4386-87f0-5861a9a8c56a", x => x.TEAMID);
                })
                .Annotation("Snowflake:TableType", SnowflakeTableType.Permanent);

            migrationBuilder.CreateTable(
                name: "USER",
                schema: "EVENTSAPP_DAT",
                columns: table => new
                {
                    USERID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: false)
                        .Annotation("Snowflake:Identity", "START 1 INCREMENT 1 NOORDER")
                        .Annotation("Snowflake:ValueGenerationStrategy", SnowflakeValueGenerationStrategy.AutoIncrement),
                    FNAME = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: true),
                    LNAME = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_CONSTRAINT_95fad561-982d-4f4a-976d-8eefc31552d0", x => x.USERID);
                })
                .Annotation("Snowflake:TableType", SnowflakeTableType.Permanent);

            migrationBuilder.CreateTable(
                name: "EVENTLOCATION",
                schema: "EVENTSAPP_MAP",
                columns: table => new
                {
                    EVENTID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: true),
                    LOCATIONID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "EVENTLOCATION_EVENTID",
                        column: x => x.EVENTID,
                        principalSchema: "EVENTSAPP_DAT",
                        principalTable: "EVENT",
                        principalColumn: "EVENTID");
                    table.ForeignKey(
                        name: "EVENTLOCATION_LOCATIONID",
                        column: x => x.LOCATIONID,
                        principalSchema: "EVENTSAPP_DAT",
                        principalTable: "LOCATION",
                        principalColumn: "LOCATIONID");
                })
                .Annotation("Snowflake:TableType", SnowflakeTableType.Permanent);

            migrationBuilder.CreateTable(
                name: "EVENTSIDEEVENT",
                schema: "EVENTSAPP_MAP",
                columns: table => new
                {
                    EVENTID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: true),
                    SIDEEVENTID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "EVENTSIDEEVENT_EVENTID",
                        column: x => x.EVENTID,
                        principalSchema: "EVENTSAPP_DAT",
                        principalTable: "EVENT",
                        principalColumn: "EVENTID");
                    table.ForeignKey(
                        name: "EVENTSIDEEVENT_SIDEEVENTID",
                        column: x => x.SIDEEVENTID,
                        principalSchema: "EVENTSAPP_DAT",
                        principalTable: "SIDEEVENT",
                        principalColumn: "SIDEEVENTID");
                })
                .Annotation("Snowflake:TableType", SnowflakeTableType.Permanent);

            migrationBuilder.CreateTable(
                name: "EVENTSIDEEVENTUSER",
                schema: "EVENTSAPP_MAP",
                columns: table => new
                {
                    EVENTID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: true),
                    SIDEEVENTID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: true),
                    USERID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "EVENTSIDEEVENTUSER_EVENTID",
                        column: x => x.EVENTID,
                        principalSchema: "EVENTSAPP_DAT",
                        principalTable: "EVENT",
                        principalColumn: "EVENTID");
                    table.ForeignKey(
                        name: "EVENTSIDEEVENTUSER_SIDEEVENTID",
                        column: x => x.SIDEEVENTID,
                        principalSchema: "EVENTSAPP_DAT",
                        principalTable: "SIDEEVENT",
                        principalColumn: "SIDEEVENTID");
                    table.ForeignKey(
                        name: "EVENTSIDEEVENTUSER_USERID",
                        column: x => x.USERID,
                        principalSchema: "EVENTSAPP_DAT",
                        principalTable: "USER",
                        principalColumn: "USERID");
                })
                .Annotation("Snowflake:TableType", SnowflakeTableType.Permanent);

            migrationBuilder.CreateTable(
                name: "MAP_EVENTTEAMUSER",
                schema: "EVENTSAPP_MAP",
                columns: table => new
                {
                    EVENTID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: true),
                    TEAMID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: true),
                    USERID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "EVENTTEAMUSER_EVENTID",
                        column: x => x.EVENTID,
                        principalSchema: "EVENTSAPP_DAT",
                        principalTable: "EVENT",
                        principalColumn: "EVENTID");
                    table.ForeignKey(
                        name: "EVENTTEAMUSER_TEAMID",
                        column: x => x.TEAMID,
                        principalSchema: "EVENTSAPP_DAT",
                        principalTable: "TEAM",
                        principalColumn: "TEAMID");
                    table.ForeignKey(
                        name: "EVENTTEAMUSER_USERID",
                        column: x => x.USERID,
                        principalSchema: "EVENTSAPP_DAT",
                        principalTable: "USER",
                        principalColumn: "USERID");
                })
                .Annotation("Snowflake:TableType", SnowflakeTableType.Permanent);

            migrationBuilder.CreateTable(
                name: "MAP_EVENTUSER",
                schema: "EVENTSAPP_MAP",
                columns: table => new
                {
                    EVENTID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: true),
                    USERID = table.Column<long>(type: "NUMBER(38,0)", precision: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "EVENTUSER_EVENTID",
                        column: x => x.EVENTID,
                        principalSchema: "EVENTSAPP_DAT",
                        principalTable: "EVENT",
                        principalColumn: "EVENTID");
                    table.ForeignKey(
                        name: "EVENTUSER_USERID",
                        column: x => x.USERID,
                        principalSchema: "EVENTSAPP_DAT",
                        principalTable: "USER",
                        principalColumn: "USERID");
                })
                .Annotation("Snowflake:TableType", SnowflakeTableType.Permanent);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EVENTLOCATION",
                schema: "EVENTSAPP_MAP");

            migrationBuilder.DropTable(
                name: "EVENTSIDEEVENT",
                schema: "EVENTSAPP_MAP");

            migrationBuilder.DropTable(
                name: "EVENTSIDEEVENTUSER",
                schema: "EVENTSAPP_MAP");

            migrationBuilder.DropTable(
                name: "MAP_EVENTTEAMUSER",
                schema: "EVENTSAPP_MAP");

            migrationBuilder.DropTable(
                name: "MAP_EVENTUSER",
                schema: "EVENTSAPP_MAP");

            migrationBuilder.DropTable(
                name: "ROLE",
                schema: "EVENTSAPP_DAT");

            migrationBuilder.DropTable(
                name: "LOCATION",
                schema: "EVENTSAPP_DAT");

            migrationBuilder.DropTable(
                name: "SIDEEVENT",
                schema: "EVENTSAPP_DAT");

            migrationBuilder.DropTable(
                name: "TEAM",
                schema: "EVENTSAPP_DAT");

            migrationBuilder.DropTable(
                name: "EVENT",
                schema: "EVENTSAPP_DAT");

            migrationBuilder.DropTable(
                name: "USER",
                schema: "EVENTSAPP_DAT");
        }
    }
}
