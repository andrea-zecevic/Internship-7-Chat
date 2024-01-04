using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatApp.Data.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "ChannelId", "ChannelName" },
                values: new object[,]
                {
                    { 1, "general" },
                    { 2, "random" },
                    { 3, "social-media" },
                    { 4, "design" },
                    { 5, "days-2024" },
                    { 6, "multimedia" },
                    { 7, "dev" },
                    { 8, "marketing" },
                    { 9, "ured" },
                    { 10, "youtube" },
                    { 11, "meetings" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Password", "UserName", "UserType" },
                values: new object[,]
                {
                    { 1, "mirna@dump.com", "password1", "Mirna", "Regular" },
                    { 2, "magla@dump.com", "passw", "Magla", "Regular" },
                    { 3, "roca@dump.com", "password", "Roca", "Regular" },
                    { 4, "frane@dump.com", "password123", "Frane", "Regular" },
                    { 5, "damjana@dump.com", "word", "Damjana", "Regular" },
                    { 6, "bartlo@dump.com", "pawoooo", "Bartol", "Regular" },
                    { 7, "marijaS@dump.com", "pass22331", "MarijaS", "Regular" },
                    { 8, "mate@dump.com", "password1", "Mate", "Regular" },
                    { 9, "andrea@dump.com", "pass123", "Andrea", "Regular" },
                    { 10, "paula@dump.com", "password1", "Paula", "Regular" },
                    { 11, "gabi@dump.com", "password1", "Gabi", "Regular" },
                    { 12, "jan@dump.com", "password1", "Jan", "Regular" },
                    { 13, "lovre@dump.com", "password1", "Lovre", "Regular" },
                    { 14, "ivo@dump.com", "password1", "Ivo", "Regular" },
                    { 15, "duje@dump.com", "password1", "Duje", "Regular" },
                    { 16, "marijaS@dump.com", "password1", "MarijaG", "Regular" },
                    { 17, "mihaela@dump.com", "password1", "Mihaela", "Regular" },
                    { 18, "mia@dump.com", "pa99999", "Mia", "Regular" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "ChannelId", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 4, 16, 8, 55, 475, DateTimeKind.Utc).AddTicks(6927), 1 },
                    { 2, 3, new DateTime(2024, 1, 4, 16, 8, 55, 475, DateTimeKind.Utc).AddTicks(6931), 2 },
                    { 3, 3, new DateTime(2024, 1, 4, 16, 8, 55, 475, DateTimeKind.Utc).AddTicks(6932), 3 }
                });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "PrivateMessageId", "ReceiverUserId", "SenderUserId", "Timestamp" },
                values: new object[,]
                {
                    { 1, 6, 5, new DateTime(2024, 1, 4, 16, 8, 55, 475, DateTimeKind.Utc).AddTicks(6951) },
                    { 2, 8, 4, new DateTime(2024, 1, 4, 16, 8, 55, 475, DateTimeKind.Utc).AddTicks(6955) }
                });

            migrationBuilder.InsertData(
                table: "UserChannels",
                columns: new[] { "ChannelId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 4, 2 },
                    { 1, 3 },
                    { 11, 3 },
                    { 2, 4 },
                    { 6, 4 },
                    { 11, 4 },
                    { 2, 5 },
                    { 5, 5 },
                    { 7, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "ChannelId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "ChannelId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "ChannelId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "PrivateMessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserChannels",
                keyColumns: new[] { "ChannelId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "UserChannels",
                keyColumns: new[] { "ChannelId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "UserChannels",
                keyColumns: new[] { "ChannelId", "UserId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "UserChannels",
                keyColumns: new[] { "ChannelId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "UserChannels",
                keyColumns: new[] { "ChannelId", "UserId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "UserChannels",
                keyColumns: new[] { "ChannelId", "UserId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "UserChannels",
                keyColumns: new[] { "ChannelId", "UserId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "UserChannels",
                keyColumns: new[] { "ChannelId", "UserId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "UserChannels",
                keyColumns: new[] { "ChannelId", "UserId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "UserChannels",
                keyColumns: new[] { "ChannelId", "UserId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "UserChannels",
                keyColumns: new[] { "ChannelId", "UserId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "UserChannels",
                keyColumns: new[] { "ChannelId", "UserId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "UserChannels",
                keyColumns: new[] { "ChannelId", "UserId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "ChannelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "ChannelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "ChannelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "ChannelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "ChannelId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "ChannelId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "ChannelId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "ChannelId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);
        }
    }
}
