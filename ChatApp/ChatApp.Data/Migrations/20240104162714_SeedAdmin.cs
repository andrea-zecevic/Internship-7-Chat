using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatApp.Data.Migrations
{
    public partial class SeedAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2024, 1, 4, 16, 27, 14, 80, DateTimeKind.Utc).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2024, 1, 4, 16, 27, 14, 80, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2024, 1, 4, 16, 27, 14, 80, DateTimeKind.Utc).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2024, 1, 4, 16, 27, 14, 80, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2024, 1, 4, 16, 27, 14, 80, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Password", "UserName", "UserType" },
                values: new object[] { 101, "admin@dump.com", "adminpassword", "Admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 101);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2024, 1, 4, 16, 8, 55, 475, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2024, 1, 4, 16, 8, 55, 475, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2024, 1, 4, 16, 8, 55, 475, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2024, 1, 4, 16, 8, 55, 475, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2024, 1, 4, 16, 8, 55, 475, DateTimeKind.Utc).AddTicks(6955));
        }
    }
}
