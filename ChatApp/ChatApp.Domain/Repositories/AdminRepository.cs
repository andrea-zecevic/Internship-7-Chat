using ChatApp.Data.Entities;
using ChatApp.Data.Entities.Models;

namespace ChatApp.Domain.Repositories
{
    public class AdminRepository : BaseRepository
    {
        public AdminRepository(ChatAppDbContext dbContext) : base(dbContext)
        {
        }

        public ICollection<Admin> GetAllAdmins()
        {
            return DbContext.Users
                .OfType<Admin>()
                .ToList();
        }

        public Admin? GetById(int id)
        {
            return DbContext.Users
                .OfType<Admin>()
                .FirstOrDefault(u => u.UserId == id) as Admin;
        }

    }
}
