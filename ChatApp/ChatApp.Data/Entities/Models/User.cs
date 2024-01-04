
namespace ChatApp.Data.Entities.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }    
        public string? Email { get; set; }
        public string? Password { get; set; }


        public ICollection<UserChannel> UserChannels { get; set; } = new List<UserChannel>();
        public ICollection<Message> Messages { get; set; } = new List<Message>();
        public ICollection<PrivateMessage> SentPrivateMessages { get; set; } = new List<PrivateMessage>();
        public ICollection<PrivateMessage> ReceivedPrivateMessages { get; set; } = new List<PrivateMessage>();

        public User(string userName, string? email = null, string? password = null)
        {
            UserName = userName;
            Email = email;
            Password = password;
        }

    }

}
