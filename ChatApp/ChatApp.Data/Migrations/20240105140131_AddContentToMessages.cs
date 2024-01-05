using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatApp.Data.Migrations
{
    public partial class AddContentToMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Messages",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 1, 30, 318, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 1, 30, 318, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 1, 30, 318, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 1, 30, 318, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 1, 30, 318, DateTimeKind.Utc).AddTicks(4157));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Messages");

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
        }
    }
}
