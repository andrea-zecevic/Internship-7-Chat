using ChatApp.Data.Entities.Models;
using ChatApp.Data.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ChatApp.Data.Entities
{
    public class ChatAppDbContext : DbContext
    {
        public ChatAppDbContext(DbContextOptions<ChatAppDbContext> options) : base(options)
        {
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Channel>? Channels { get; set; }
        public DbSet<UserChannel>? UserChannels { get; set; }
        public DbSet<Message>? Messages { get; set; }
        public DbSet<PrivateMessage>? PrivateMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UserChannel>()
                .HasKey(uc => new { uc.UserId, uc.ChannelId });

            modelBuilder.Entity<UserChannel>()
                .HasOne(uc => uc.User)
                .WithMany(u => u.UserChannels)
                .HasForeignKey(uc => uc.UserId);

            modelBuilder.Entity<UserChannel>()
                .HasOne(uc => uc.Channel)
                .WithMany(c => c.ChannelUsers)
                .HasForeignKey(uc => uc.ChannelId);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.User)
                .WithMany(u => u.Messages)
                .HasForeignKey(m => m.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Channel)
                .WithMany(c => c.Messages)
                .HasForeignKey(m => m.ChannelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PrivateMessage>()
                .HasOne(pm => pm.SenderUser)
                .WithMany(u => u.SentPrivateMessages)
                .HasForeignKey(pm => pm.SenderUserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PrivateMessage>()
                .HasOne(pm => pm.ReceiverUser)
                .WithMany(u => u.ReceivedPrivateMessages)
                .HasForeignKey(pm => pm.ReceiverUserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasDiscriminator<string>("UserType")
                .HasValue<User>("Regular")
                .HasValue<Admin>("Admin");


            base.OnModelCreating(modelBuilder);
            DatabaseSeeder.Seed(modelBuilder);
        }
    }

    public class ChatAppDbContextFactory : IDesignTimeDbContextFactory<ChatAppDbContext>
    {
        public ChatAppDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddXmlFile("App.config")
                .Build();

            config.Providers
                .First()
                .TryGet("connectionStrings:add:ChatApp:connectionString", out var connectionString);

            var options = new DbContextOptionsBuilder<ChatAppDbContext>()
                .UseNpgsql(connectionString)
                .Options;

            return new ChatAppDbContext(options);
        }
    }
}
