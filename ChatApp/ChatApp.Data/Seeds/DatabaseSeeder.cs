using ChatApp.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ChatApp.Data.Seeds
{
    public static class DatabaseSeeder
    {
        public static void Seed(ModelBuilder builder)
        {

            builder.Entity<User>()
                .HasData(new List<User>
                {
                    new User ("Mirna", "mirna@dump.com", "password1") { UserId = 1 },
                    new User ("Magla", "magla@dump.com", "passw") { UserId = 2 },
                    new User ("Roca", "roca@dump.com", "password") { UserId = 3 },
                    new User ("Frane", "frane@dump.com", "password123") { UserId = 4 },
                    new User ("Damjana", "damjana@dump.com", "word") { UserId = 5 },
                    new User ("Bartol", "bartlo@dump.com", "pawoooo") { UserId = 6 },
                    new User ("MarijaS", "marijaS@dump.com", "pass22331") { UserId = 7 },
                    new User ("Mate", "mate@dump.com", "password1") { UserId = 8 },
                    new User ("Andrea", "andrea@dump.com", "pass123") { UserId = 9 },
                    new User ("Paula", "paula@dump.com", "password1") { UserId = 10 },
                    new User ("Gabi", "gabi@dump.com", "password1") { UserId = 11 },
                    new User ("Jan", "jan@dump.com", "password1") { UserId = 12 },
                    new User ("Lovre", "lovre@dump.com", "password1") { UserId = 13 },
                    new User ("Ivo", "ivo@dump.com", "password1") { UserId = 14 },
                    new User ("Duje", "duje@dump.com", "password1") { UserId = 15 },
                    new User ("MarijaG", "marijaS@dump.com", "password1") { UserId = 16 },
                    new User ("Mihaela", "mihaela@dump.com", "password1") { UserId = 17 },
                    new User ("Mia", "mia@dump.com", "pa99999") { UserId = 18 }
                });

            builder.Entity<Admin>()
                .HasData(new List<Admin>
                {
                    new Admin("Admin", "admin@dump.com", "adminpassword") { UserId = 101 },
                });

            builder.Entity<Channel>()
                .HasData(new List<Channel>
                {
                    new Channel { ChannelId = 1, ChannelName = "general" },
                    new Channel { ChannelId = 2, ChannelName = "random" },
                    new Channel { ChannelId = 3, ChannelName = "social-media" },
                    new Channel { ChannelId = 4, ChannelName = "design" },
                    new Channel { ChannelId = 5, ChannelName = "days-2024" },
                    new Channel { ChannelId = 6, ChannelName = "multimedia" },
                    new Channel { ChannelId = 7, ChannelName = "dev" },
                    new Channel { ChannelId = 8, ChannelName = "marketing" },
                    new Channel { ChannelId = 9, ChannelName = "ured" },
                    new Channel { ChannelId = 10, ChannelName = "youtube" },
                    new Channel { ChannelId = 11, ChannelName = "meetings" }
                });


            builder.Entity<UserChannel>()
                .HasData(new List<UserChannel>
                {
                        new UserChannel { UserId = 1, ChannelId = 1 },
                        new UserChannel { UserId = 1, ChannelId = 2 },
                        new UserChannel { UserId = 1, ChannelId = 3 },
        
                        new UserChannel { UserId = 2, ChannelId = 1 },
                        new UserChannel { UserId = 2, ChannelId = 4 },
        
                        new UserChannel { UserId = 3, ChannelId = 1 },
                        new UserChannel { UserId = 3, ChannelId = 11 },

                        new UserChannel { UserId = 4, ChannelId = 2 },
                        new UserChannel { UserId = 4, ChannelId = 6 },
                        new UserChannel { UserId = 4, ChannelId = 11 },

                        new UserChannel { UserId = 5, ChannelId = 2 },
                        new UserChannel { UserId = 5, ChannelId = 5 },
                        new UserChannel { UserId = 5, ChannelId = 7 },
                });


            builder.Entity<Message>()
                .HasData(new List<Message>
                {
                    new Message { MessageId = 1, Timestamp = DateTime.UtcNow, UserId = 1, ChannelId = 1, Content = "Kako si?" },
                    new Message { MessageId = 2, Timestamp = DateTime.UtcNow, UserId = 2, ChannelId = 3, Content = "Di je printer" },
                    new Message { MessageId = 3, Timestamp = DateTime.UtcNow.AddMinutes(-10), UserId = 3, ChannelId = 3, Content = "Uzea san sirup"},
                    new Message { MessageId = 4, Timestamp = DateTime.UtcNow.AddDays(-5), UserId = 2, ChannelId = 3, Content = "Slej" },
                    new Message { MessageId = 5, Timestamp = DateTime.UtcNow.AddDays(-5), UserId = 4, ChannelId = 7, Content = "Idemoooo" },
                    new Message { MessageId = 6, Timestamp = DateTime.UtcNow.AddMinutes(-12), UserId = 8, ChannelId = 5, Content = "hksdndnsk" },
                    new Message { MessageId = 7, Timestamp = DateTime.UtcNow.AddDays(-15), UserId = 5, ChannelId = 4, Content = "kad je sastanak" },
                    new Message { MessageId = 8, Timestamp = DateTime.UtcNow.AddDays(-1), UserId = 7, ChannelId = 1, Content = "di su brosure" },
                    new Message { MessageId = 9, Timestamp = DateTime.UtcNow.AddMinutes(-24), UserId = 6, ChannelId = 2, Content = "a100 ce bit mal" },
                });


            builder.Entity<PrivateMessage>()
                .HasData(new List<PrivateMessage>
                {
                    new PrivateMessage { PrivateMessageId = 1, Timestamp = DateTime.UtcNow, SenderUserId = 5, ReceiverUserId = 6 },
                    new PrivateMessage { PrivateMessageId = 2, Timestamp = DateTime.UtcNow, SenderUserId = 4, ReceiverUserId = 8 }
                });
        }
    }
}
