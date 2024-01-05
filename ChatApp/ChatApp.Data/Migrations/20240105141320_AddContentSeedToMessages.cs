using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatApp.Data.Migrations
{
    public partial class AddContentSeedToMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { "Kako si?", new DateTime(2024, 1, 5, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { "Di je printer", new DateTime(2024, 1, 5, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { "Uzea san sirup", new DateTime(2024, 1, 5, 14, 3, 19, 964, DateTimeKind.Utc).AddTicks(6172) });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "ChannelId", "Content", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { 4, 3, "Slej", new DateTime(2023, 12, 31, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6180), 2 },
                    { 5, 7, "Idemoooo", new DateTime(2023, 12, 31, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6181), 4 },
                    { 6, 5, "hksdndnsk", new DateTime(2024, 1, 5, 14, 1, 19, 964, DateTimeKind.Utc).AddTicks(6184), 8 },
                    { 7, 4, "kad je sastanak", new DateTime(2023, 12, 21, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6186), 5 },
                    { 8, 1, "di su brosure", new DateTime(2024, 1, 4, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6187), 7 },
                    { 9, 2, "a100 ce bit mal", new DateTime(2024, 1, 5, 13, 49, 19, 964, DateTimeKind.Utc).AddTicks(6188), 6 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { null, new DateTime(2024, 1, 5, 14, 1, 30, 318, DateTimeKind.Utc).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { null, new DateTime(2024, 1, 5, 14, 1, 30, 318, DateTimeKind.Utc).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { null, new DateTime(2024, 1, 5, 14, 1, 30, 318, DateTimeKind.Utc).AddTicks(4130) });

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
    }
}
