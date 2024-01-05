using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatApp.Data.Migrations
{
    public partial class AddContentSeedToPrivateMsg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 54, 53, 259, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 54, 53, 259, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 44, 53, 259, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "Timestamp",
                value: new DateTime(2023, 12, 31, 14, 54, 53, 259, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "Timestamp",
                value: new DateTime(2023, 12, 31, 14, 54, 53, 259, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 6,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 42, 53, 259, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 7,
                column: "Timestamp",
                value: new DateTime(2023, 12, 21, 14, 54, 53, 259, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 8,
                column: "Timestamp",
                value: new DateTime(2024, 1, 4, 14, 54, 53, 259, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 9,
                column: "Timestamp",
                value: new DateTime(2024, 1, 5, 14, 30, 53, 259, DateTimeKind.Utc).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 1,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { "Jel spramen cover za reel", new DateTime(2024, 1, 5, 14, 52, 53, 259, DateTimeKind.Utc).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 2,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { "Jesi ispravia sve domace", new DateTime(2024, 1, 5, 14, 54, 53, 259, DateTimeKind.Utc).AddTicks(6261) });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "PrivateMessageId", "Content", "ReceiverUserId", "SenderUserId", "Timestamp" },
                values: new object[,]
                {
                    { 3, "Javi se frani", 1, 6, new DateTime(2024, 1, 2, 14, 54, 53, 259, DateTimeKind.Utc).AddTicks(6262) },
                    { 4, "Jesi ispravia sve domace", 1, 4, new DateTime(2024, 1, 5, 14, 54, 53, 259, DateTimeKind.Utc).AddTicks(6263) },
                    { 5, "Javi se frani", 1, 3, new DateTime(2023, 12, 29, 14, 54, 53, 259, DateTimeKind.Utc).AddTicks(6264) },
                    { 6, "Koliko dana je od daysa", 5, 2, new DateTime(2024, 1, 5, 12, 54, 53, 259, DateTimeKind.Utc).AddTicks(6267) },
                    { 7, "ne znan", 1, 4, new DateTime(2024, 1, 5, 14, 51, 53, 259, DateTimeKind.Utc).AddTicks(6268) },
                    { 8, "aloooo", 2, 7, new DateTime(2024, 1, 5, 14, 53, 53, 259, DateTimeKind.Utc).AddTicks(6269) },
                    { 9, "slejaca", 3, 9, new DateTime(2023, 12, 25, 14, 54, 53, 259, DateTimeKind.Utc).AddTicks(6270) },
                    { 10, "ikona", 7, 10, new DateTime(2024, 1, 5, 13, 59, 53, 259, DateTimeKind.Utc).AddTicks(6273) },
                    { 11, "treiba namistit set", 4, 11, new DateTime(2024, 1, 5, 14, 45, 53, 259, DateTimeKind.Utc).AddTicks(6274) },
                    { 12, "imas li kljuc od ureda", 8, 4, new DateTime(2024, 1, 5, 14, 54, 53, 259, DateTimeKind.Utc).AddTicks(6275) },
                    { 13, "doc se sad voda tribas je skupit", 5, 9, new DateTime(2023, 12, 24, 14, 54, 53, 259, DateTimeKind.Utc).AddTicks(6276) },
                    { 14, "ocemo na rucak", 8, 1, new DateTime(2023, 12, 25, 14, 54, 53, 259, DateTimeKind.Utc).AddTicks(6277) },
                    { 15, "kad ces bit u uredu", 9, 3, new DateTime(2023, 12, 6, 14, 54, 53, 259, DateTimeKind.Utc).AddTicks(6278) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 15);

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
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { null, new DateTime(2024, 1, 5, 14, 44, 14, 268, DateTimeKind.Utc).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 2,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { null, new DateTime(2024, 1, 5, 14, 44, 14, 268, DateTimeKind.Utc).AddTicks(6997) });
        }
    }
}
