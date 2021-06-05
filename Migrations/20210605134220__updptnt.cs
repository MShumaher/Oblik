using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oblik.Migrations
{
    public partial class _updptnt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TitleImagePath = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKeywords = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    CodeWord = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Subtitle = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    Birthday = table.Column<string>(nullable: true),
                    TelNumb = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    BloodType = table.Column<string>(nullable: true),
                    Rhesus = table.Column<string>(nullable: true),
                    DocumentType = table.Column<string>(nullable: true),
                    NumbDocument = table.Column<int>(nullable: false),
                    SerialDocument = table.Column<string>(nullable: true),
                    Rknopp = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5CB180AC-1325-444F-8177-D9A517162427",
                column: "ConcurrencyStamp",
                value: "c7d628cb-5e55-4505-b063-6dd07f08a537");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52D5A142-F7A2-428E-A603-3AFDC8C79206",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "07d897db-5158-456e-87da-581fa168d0e3", "AQAAAAEAACcQAAAAEKUXuS7EwRntR9VAtB/12XcxAWaQpW69AGPQ8OR1mzV4jZ4NUUc9cyRIq2nzIe7tXw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("1e82fb54-c4f1-49d1-a229-3ddf578b8ddc"),
                column: "DateAdded",
                value: new DateTime(2021, 6, 5, 16, 42, 20, 366, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("419ad9ba-4570-4325-80d6-edfd965ace14"),
                column: "DateAdded",
                value: new DateTime(2021, 6, 5, 16, 42, 20, 366, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("ef86a70c-be92-4255-bda3-ee43b6fb401d"),
                column: "DateAdded",
                value: new DateTime(2021, 6, 5, 16, 42, 20, 365, DateTimeKind.Local).AddTicks(8586));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5CB180AC-1325-444F-8177-D9A517162427",
                column: "ConcurrencyStamp",
                value: "f357992f-5c25-4841-abfc-032f74a05cdf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52D5A142-F7A2-428E-A603-3AFDC8C79206",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "930b5633-e233-400a-a6df-c07ebfbd630d", "AQAAAAEAACcQAAAAEG4FVrywSQRV7sMQoyh4NQ+9wul4AaJVfhYCbCY1Iz5G+CNukEJgCc8yi+TTc+8gNQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("1e82fb54-c4f1-49d1-a229-3ddf578b8ddc"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 23, 22, 48, 17, 523, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("419ad9ba-4570-4325-80d6-edfd965ace14"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 23, 22, 48, 17, 523, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("ef86a70c-be92-4255-bda3-ee43b6fb401d"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 23, 22, 48, 17, 521, DateTimeKind.Local).AddTicks(9315));
        }
    }
}
