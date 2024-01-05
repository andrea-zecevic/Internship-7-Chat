
namespace ChatApp.Data.Entities.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public DateTime Timestamp { get; set; }
        public int UserId { get; set; }
        public int ChannelId { get; set; }
        public string? Content { get; set; }


        public User User { get; set; } = null!;
        public Channel Channel { get; set; } = null!;
    }


}
