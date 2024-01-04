
using ChatApp.Data.Entities.Models;

namespace ChatApp.Data.Entities.Models
{
    public class UserChannel
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int ChannelId { get; set; }
        public Channel Channel { get; set; } = null!;
    }

}

