using ChatApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace ChatApp.Data.Factories
{
    public static class DbContextFactory
    {
        public static ChatAppDbContext GetChatAppDbContext()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ChatApp"].ConnectionString;
            var options = new DbContextOptionsBuilder<ChatAppDbContext>()
                .UseNpgsql(connectionString)
                .Options;

            return new ChatAppDbContext(options);
        }
    }
}
