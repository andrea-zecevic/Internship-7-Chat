using ChatApp.Data.Entities.Models;

namespace ChatApp.Presentation.Actions.ChannelActions
{
    public class ShowMyChannelsAction
    {
        private User _currentUser;

        public ShowMyChannelsAction(User currentUser)
        {
            _currentUser = currentUser;
        }

        public void Execute()
        {
            // Logika za prikaz kanala u koje je korisnik ušao
        }
    }
}

