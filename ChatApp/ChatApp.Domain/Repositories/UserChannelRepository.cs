using ChatApp.Data.Entities;
using ChatApp.Domain.Enums;
using ChatApp.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Domain.Repositories
{
    public class UserChannelRepository : BaseRepository
    {
        public UserChannelRepository(ChatAppDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(UserChannel userChannel)
        {
            DbContext.UserChannels.Add(userChannel);
            return SaveChanges();
        }

        public ResponseResultType Delete(int userId, int channelId)
        {
            var userChannelToDelete = DbContext.UserChannels
                .FirstOrDefault(uc => uc.UserId == userId && uc.ChannelId == channelId);

            if (userChannelToDelete == null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.UserChannels.Remove(userChannelToDelete);
            return SaveChanges();
        }

        public ICollection<UserChannel> GetUserChannelsByUserId(int userId)
        {
            return DbContext.UserChannels
                .Where(uc => uc.UserId == userId)
                .Include(uc => uc.Channel)
                .ToList();
        }

        public ICollection<UserChannel> GetUserChannelsByChannelId(int channelId)
        {
            return DbContext.UserChannels
                .Where(uc => uc.ChannelId == channelId)
                .Include(uc => uc.User)
                .ToList();
        }

    }
}
