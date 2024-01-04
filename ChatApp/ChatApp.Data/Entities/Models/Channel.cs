
namespace ChatApp.Data.Entities.Models
{
    public class Channel
    {
        public int ChannelId { get; set; }
        public string? ChannelName { get; set; }

        public ICollection<UserChannel> ChannelUsers { get; set; } = new List<UserChannel>();
        public ICollection<Message> Messages { get; set; } = new List<Message>();

        public Channel() { }
        public Channel(string name)
        {
            ChannelName = name;
        }
    }

}
