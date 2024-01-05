using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatApp.Data.Migrations
{
    public partial class AddContentToPrivateMsg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "PrivateMessages",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 44, 14, 268, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 44, 14, 268, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 34, 14, 268, DateTimeKind.Utc).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "Timestamp",
                value: new DateTime(2023, 12, 31, 14, 44, 14, 268, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "Timestamp",
                value: new DateTime(2023, 12, 31, 14, 44, 14, 268, DateTimeKind.Utc).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 6,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 32, 14, 268, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 7,
                column: "Timestamp",
                value: new DateTime(2023, 12, 21, 14, 44, 14, 268, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 8,
                column: "Timestamp",
                value: new DateTime(2024, 1, 4, 14, 44, 14, 268, DateTimeKind.Utc).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 9,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 20, 14, 268, DateTimeKind.Utc).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 44, 14, 268, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 44, 14, 268, DateTimeKind.Utc).AddTicks(6997));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "PrivateMessages");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 3, 19, 964, DateTimeKind.Utc).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "Timestamp",
                value: new DateTime(2023, 12, 31, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "Timestamp",
                value: new DateTime(2023, 12, 31, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 6,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 1, 19, 964, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 7,
                column: "Timestamp",
                value: new DateTime(2023, 12, 21, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 8,
                column: "Timestamp",
                value: new DateTime(2024, 1, 4, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 9,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 13, 49, 19, 964, DateTimeKind.Utc).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6232));
        }
    }
}
