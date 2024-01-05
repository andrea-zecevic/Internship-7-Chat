using ChatApp.Data.Entities;
using ChatApp.Domain.Enums;
using ChatApp.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Domain.Repositories
{
    public class MessageRepository : BaseRepository
    {
        public MessageRepository(ChatAppDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(Message message)
        {
            DbContext.Messages.Add(message);
            return SaveChanges();
        }

        public ResponseResultType Delete(int id)
        {
            var messageToDelete = DbContext.Messages.Find(id);
            if (messageToDelete == null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.Messages.Remove(messageToDelete);
            return SaveChanges();
        }
        public ICollection<Message> GetMessagesByChannelId(int channelId)
        {
            return DbContext.Messages
                .Where(m => m.ChannelId == channelId)
                .Include(m => m.User)
                .ToList();
        }

    }
}
