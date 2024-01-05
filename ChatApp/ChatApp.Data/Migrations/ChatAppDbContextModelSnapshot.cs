﻿// <auto-generated />
using System;
using ChatApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ChatApp.Data.Migrations
{
    [DbContext(typeof(ChatAppDbContext))]
    partial class ChatAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ChatApp.Data.Entities.Models.Channel", b =>
                {
                    b.Property<int>("ChannelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ChannelId"));

                    b.Property<string>("ChannelName")
                        .HasColumnType("text");

                    b.HasKey("ChannelId");

                    b.ToTable("Channels");

                    b.HasData(
                        new
                        {
                            ChannelId = 1,
                            ChannelName = "general"
                        },
                        new
                        {
                            ChannelId = 2,
                            ChannelName = "random"
                        },
                        new
                        {
                            ChannelId = 3,
                            ChannelName = "social-media"
                        },
                        new
                        {
                            ChannelId = 4,
                            ChannelName = "design"
                        },
                        new
                        {
                            ChannelId = 5,
                            ChannelName = "days-2024"
                        },
                        new
                        {
                            ChannelId = 6,
                            ChannelName = "multimedia"
                        },
                        new
                        {
                            ChannelId = 7,
                            ChannelName = "dev"
                        },
                        new
                        {
                            ChannelId = 8,
                            ChannelName = "marketing"
                        },
                        new
                        {
                            ChannelId = 9,
                            ChannelName = "ured"
                        },
                        new
                        {
                            ChannelId = 10,
                            ChannelName = "youtube"
                        },
                        new
                        {
                            ChannelId = 11,
                            ChannelName = "meetings"
                        });
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MessageId"));

                    b.Property<int>("ChannelId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("MessageId");

                    b.HasIndex("ChannelId");

                    b.HasIndex("UserId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            MessageId = 1,
                            ChannelId = 1,
                            Content = "Kako si?",
                            Timestamp = new DateTime(2024, 1, 5, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6161),
                            UserId = 1
                        },
                        new
                        {
                            MessageId = 2,
                            ChannelId = 3,
                            Content = "Di je printer",
                            Timestamp = new DateTime(2024, 1, 5, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6171),
                            UserId = 2
                        },
                        new
                        {
                            MessageId = 3,
                            ChannelId = 3,
                            Content = "Uzea san sirup",
                            Timestamp = new DateTime(2024, 1, 5, 14, 3, 19, 964, DateTimeKind.Utc).AddTicks(6172),
                            UserId = 3
                        },
                        new
                        {
                            MessageId = 4,
                            ChannelId = 3,
                            Content = "Slej",
                            Timestamp = new DateTime(2023, 12, 31, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6180),
                            UserId = 2
                        },
                        new
                        {
                            MessageId = 5,
                            ChannelId = 7,
                            Content = "Idemoooo",
                            Timestamp = new DateTime(2023, 12, 31, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6181),
                            UserId = 4
                        },
                        new
                        {
                            MessageId = 6,
                            ChannelId = 5,
                            Content = "hksdndnsk",
                            Timestamp = new DateTime(2024, 1, 5, 14, 1, 19, 964, DateTimeKind.Utc).AddTicks(6184),
                            UserId = 8
                        },
                        new
                        {
                            MessageId = 7,
                            ChannelId = 4,
                            Content = "kad je sastanak",
                            Timestamp = new DateTime(2023, 12, 21, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6186),
                            UserId = 5
                        },
                        new
                        {
                            MessageId = 8,
                            ChannelId = 1,
                            Content = "di su brosure",
                            Timestamp = new DateTime(2024, 1, 4, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6187),
                            UserId = 7
                        },
                        new
                        {
                            MessageId = 9,
                            ChannelId = 2,
                            Content = "a100 ce bit mal",
                            Timestamp = new DateTime(2024, 1, 5, 13, 49, 19, 964, DateTimeKind.Utc).AddTicks(6188),
                            UserId = 6
                        });
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.PrivateMessage", b =>
                {
                    b.Property<int>("PrivateMessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PrivateMessageId"));

                    b.Property<int>("ReceiverUserId")
                        .HasColumnType("integer");

                    b.Property<int>("SenderUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("PrivateMessageId");

                    b.HasIndex("ReceiverUserId");

                    b.HasIndex("SenderUserId");

                    b.ToTable("PrivateMessages");

                    b.HasData(
                        new
                        {
                            PrivateMessageId = 1,
                            ReceiverUserId = 6,
                            SenderUserId = 5,
                            Timestamp = new DateTime(2024, 1, 5, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6222)
                        },
                        new
                        {
                            PrivateMessageId = 2,
                            ReceiverUserId = 8,
                            SenderUserId = 4,
                            Timestamp = new DateTime(2024, 1, 5, 14, 13, 19, 964, DateTimeKind.Utc).AddTicks(6232)
                        });
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("UserType").HasValue("Regular");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "mirna@dump.com",
                            Password = "password1",
                            UserName = "Mirna"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "magla@dump.com",
                            Password = "passw",
                            UserName = "Magla"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "roca@dump.com",
                            Password = "password",
                            UserName = "Roca"
                        },
                        new
                        {
                            UserId = 4,
                            Email = "frane@dump.com",
                            Password = "password123",
                            UserName = "Frane"
                        },
                        new
                        {
                            UserId = 5,
                            Email = "damjana@dump.com",
                            Password = "word",
                            UserName = "Damjana"
                        },
                        new
                        {
                            UserId = 6,
                            Email = "bartlo@dump.com",
                            Password = "pawoooo",
                            UserName = "Bartol"
                        },
                        new
                        {
                            UserId = 7,
                            Email = "marijaS@dump.com",
                            Password = "pass22331",
                            UserName = "MarijaS"
                        },
                        new
                        {
                            UserId = 8,
                            Email = "mate@dump.com",
                            Password = "password1",
                            UserName = "Mate"
                        },
                        new
                        {
                            UserId = 9,
                            Email = "andrea@dump.com",
                            Password = "pass123",
                            UserName = "Andrea"
                        },
                        new
                        {
                            UserId = 10,
                            Email = "paula@dump.com",
                            Password = "password1",
                            UserName = "Paula"
                        },
                        new
                        {
                            UserId = 11,
                            Email = "gabi@dump.com",
                            Password = "password1",
                            UserName = "Gabi"
                        },
                        new
                        {
                            UserId = 12,
                            Email = "jan@dump.com",
                            Password = "password1",
                            UserName = "Jan"
                        },
                        new
                        {
                            UserId = 13,
                            Email = "lovre@dump.com",
                            Password = "password1",
                            UserName = "Lovre"
                        },
                        new
                        {
                            UserId = 14,
                            Email = "ivo@dump.com",
                            Password = "password1",
                            UserName = "Ivo"
                        },
                        new
                        {
                            UserId = 15,
                            Email = "duje@dump.com",
                            Password = "password1",
                            UserName = "Duje"
                        },
                        new
                        {
                            UserId = 16,
                            Email = "marijaS@dump.com",
                            Password = "password1",
                            UserName = "MarijaG"
                        },
                        new
                        {
                            UserId = 17,
                            Email = "mihaela@dump.com",
                            Password = "password1",
                            UserName = "Mihaela"
                        },
                        new
                        {
                            UserId = 18,
                            Email = "mia@dump.com",
                            Password = "pa99999",
                            UserName = "Mia"
                        });
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.UserChannel", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("ChannelId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "ChannelId");

                    b.HasIndex("ChannelId");

                    b.ToTable("UserChannels");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            ChannelId = 1
                        },
                        new
                        {
                            UserId = 1,
                            ChannelId = 2
                        },
                        new
                        {
                            UserId = 1,
                            ChannelId = 3
                        },
                        new
                        {
                            UserId = 2,
                            ChannelId = 1
                        },
                        new
                        {
                            UserId = 2,
                            ChannelId = 4
                        },
                        new
                        {
                            UserId = 3,
                            ChannelId = 1
                        },
                        new
                        {
                            UserId = 3,
                            ChannelId = 11
                        },
                        new
                        {
                            UserId = 4,
                            ChannelId = 2
                        },
                        new
                        {
                            UserId = 4,
                            ChannelId = 6
                        },
                        new
                        {
                            UserId = 4,
                            ChannelId = 11
                        },
                        new
                        {
                            UserId = 5,
                            ChannelId = 2
                        },
                        new
                        {
                            UserId = 5,
                            ChannelId = 5
                        },
                        new
                        {
                            UserId = 5,
                            ChannelId = 7
                        });
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.Admin", b =>
                {
                    b.HasBaseType("ChatApp.Data.Entities.Models.User");

                    b.HasDiscriminator().HasValue("Admin");

                    b.HasData(
                        new
                        {
                            UserId = 101,
                            Email = "admin@dump.com",
                            Password = "adminpassword",
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.Message", b =>
                {
                    b.HasOne("ChatApp.Data.Entities.Models.Channel", "Channel")
                        .WithMany("Messages")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChatApp.Data.Entities.Models.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Channel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.PrivateMessage", b =>
                {
                    b.HasOne("ChatApp.Data.Entities.Models.User", "ReceiverUser")
                        .WithMany("ReceivedPrivateMessages")
                        .HasForeignKey("ReceiverUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChatApp.Data.Entities.Models.User", "SenderUser")
                        .WithMany("SentPrivateMessages")
                        .HasForeignKey("SenderUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReceiverUser");

                    b.Navigation("SenderUser");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.UserChannel", b =>
                {
                    b.HasOne("ChatApp.Data.Entities.Models.Channel", "Channel")
                        .WithMany("ChannelUsers")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChatApp.Data.Entities.Models.User", "User")
                        .WithMany("UserChannels")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Channel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.Channel", b =>
                {
                    b.Navigation("ChannelUsers");

                    b.Navigation("Messages");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Models.User", b =>
                {
                    b.Navigation("Messages");

                    b.Navigation("ReceivedPrivateMessages");

                    b.Navigation("SentPrivateMessages");

                    b.Navigation("UserChannels");
                });
#pragma warning restore 612, 618
        }
    }
}
