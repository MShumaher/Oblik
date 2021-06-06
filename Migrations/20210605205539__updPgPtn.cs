using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oblik.Migrations
{
    public partial class _updPgPtn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5CB180AC-1325-444F-8177-D9A517162427",
                column: "ConcurrencyStamp",
                value: "b0f3f26f-fcdb-484f-aa6b-e3609cce2322");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52D5A142-F7A2-428E-A603-3AFDC8C79206",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3179254c-f04e-419c-b6d9-3a70fb8786b6", "AQAAAAEAACcQAAAAELBap8pH0XsvUOLiAMRwxFEzDPVmjJJf19cMH596MK96U71wfbiHx0skivenTzEB2w==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("1e82fb54-c4f1-49d1-a229-3ddf578b8ddc"),
                column: "DateAdded",
                value: new DateTime(2021, 6, 5, 23, 55, 38, 738, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("419ad9ba-4570-4325-80d6-edfd965ace14"),
                column: "DateAdded",
                value: new DateTime(2021, 6, 5, 23, 55, 38, 738, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("ef86a70c-be92-4255-bda3-ee43b6fb401d"),
                column: "DateAdded",
                value: new DateTime(2021, 6, 5, 23, 55, 38, 737, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[] { new Guid("832a6532-512f-44b0-bdab-fb913e0fda24"), "PagePatients", new DateTime(2021, 6, 5, 23, 55, 38, 738, DateTimeKind.Local).AddTicks(4362), null, null, null, null, "Содержание заполняется администратором", "Пацієнти", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("832a6532-512f-44b0-bdab-fb913e0fda24"));

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
    }
}
