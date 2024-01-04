
namespace ChatApp.Data.Entities.Models
{
    public class PrivateMessage
    {
        public int PrivateMessageId { get; set; }
        public DateTime Timestamp { get; set; }
        public int SenderUserId { get; set; }
        public int ReceiverUserId { get; set; }

        public User SenderUser { get; set; } = null!;
        public User ReceiverUser { get; set; } = null!;
    }

}
