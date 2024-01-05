using ChatApp.Data.Entities;
using ChatApp.Domain.Enums;
using ChatApp.Data.Entities.Models;

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

    }
}
