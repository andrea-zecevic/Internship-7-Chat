using ChatApp.Data.Entities;
using ChatApp.Domain.Enums;
using ChatApp.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Domain.Repositories
{
    public class PrivateMessageRepository : BaseRepository
    {
        public PrivateMessageRepository(ChatAppDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(PrivateMessage privateMessage)
        {
            DbContext.PrivateMessages.Add(privateMessage);
            return SaveChanges();
        }

        public ResponseResultType Delete(int id)
        {
            var privateMessageToDelete = DbContext.PrivateMessages.Find(id);
            if (privateMessageToDelete == null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.PrivateMessages.Remove(privateMessageToDelete);
            return SaveChanges();
        }

        public ICollection<PrivateMessage> GetByUserId(int userId)
        {
            return DbContext.PrivateMessages
                .Include(pm => pm.SenderUser)
                .Include(pm => pm.ReceiverUser)
                .Where(pm => pm.SenderUserId == userId || pm.ReceiverUserId == userId)
                .ToList();
        }

        public ICollection<PrivateMessage> GetConversation(int userId1, int userId2)
        {
            return DbContext.PrivateMessages
                .Where(pm => (pm.SenderUserId == userId1 && pm.ReceiverUserId == userId2) ||
                             (pm.SenderUserId == userId2 && pm.ReceiverUserId == userId1))
                .OrderBy(pm => pm.Timestamp)
                .ToList();
        }


    }
}
