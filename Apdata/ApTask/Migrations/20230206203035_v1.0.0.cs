using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApTask.Migrations
{
    /// <inheritdoc />
    public partial class v100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configuration",
                columns: table => new
                {
                    Parameter = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuration", x => x.Parameter);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    TaskName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HostName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NextRunTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastRunTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastResult = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskToRun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduledTaskState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Show = table.Column<bool>(type: "bit", nullable: false),
                    Rerun = table.Column<bool>(type: "bit", nullable: false),
                    Force = table.Column<bool>(type: "bit", nullable: false),
                    SendMail = table.Column<bool>(type: "bit", nullable: false),
                    MailTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attempts = table.Column<int>(type: "int", nullable: false),
                    LastStopStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.TaskName);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuration");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Task");
        }
    }
}
