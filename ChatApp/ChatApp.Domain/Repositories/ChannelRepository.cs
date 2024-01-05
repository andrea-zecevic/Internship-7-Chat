using ChatApp.Data.Entities;
using ChatApp.Domain.Enums;
using ChatApp.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Domain.Repositories
{
    public class ChannelRepository : BaseRepository
    {
        public ChannelRepository(ChatAppDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(Channel channel)
        {
            DbContext.Channels.Add(channel);
            return SaveChanges();
        }

        public ResponseResultType Delete(int id)
        {
            var channelToDelete = DbContext.Channels.Find(id);
            if (channelToDelete == null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.Channels.Remove(channelToDelete);
            return SaveChanges();
        }

        public ResponseResultType Update(Channel channel, int id)
        {
            var channelToUpdate = DbContext.Channels.Find(id);
            if (channelToUpdate == null)
            {
                return ResponseResultType.NotFound;
            }

            channelToUpdate.ChannelName = channel.ChannelName;

            return SaveChanges();
        }

        public Channel? GetById(int id)
        {
            return DbContext.Channels
                .Include(c => c.ChannelUsers)
                .ThenInclude(uc => uc.User)
                .FirstOrDefault(c => c.ChannelId == id);
        }

        public ICollection<Channel> GetAll()
        {
            return DbContext.Channels
                .Include(c => c.ChannelUsers)
                .ThenInclude(uc => uc.User)
                .ToList();
        }




    }
}
