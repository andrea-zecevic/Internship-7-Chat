using ChatApp.Data.Entities;
using ChatApp.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using ChatApp.Data.Entities.Models;

namespace ChatApp.Domain.Repositories
{
    public class UserRepository : BaseRepository
    {
        public UserRepository(ChatAppDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(User user)
        {
            DbContext.Users.Add(user);
            return SaveChanges();
        }

        public ResponseResultType Delete(int id)
        {
            var userToDelete = DbContext.Users.Find(id);
            if (userToDelete is null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.Users.Remove(userToDelete);
            return SaveChanges();
        }

        public ResponseResultType Update(User user, int id)
        {
            var userToUpdate = DbContext.Users.Find(id);
            if (userToUpdate is null)
            {
                return ResponseResultType.NotFound;
            }

            userToUpdate.UserName = user.UserName;
            userToUpdate.Email = user.Email;
            userToUpdate.Password = user.Password;
            

            return SaveChanges();
        }

        public User? GetById(int id) => DbContext.Users
            .Include(u => u.UserChannels)
            .ThenInclude(uc => uc.Channel)
            .FirstOrDefault(u => u.UserId == id);

        public ICollection<User> GetAll() => DbContext.Users.ToList();

        public User? GetByEmail(string email)
        {
            return DbContext.Users
                .Include(u => u.UserChannels)
                .ThenInclude(uc => uc.Channel)
                .FirstOrDefault(u => u.Email == email);
        }
    }
}
