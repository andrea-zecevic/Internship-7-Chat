

using ChatApp.Data.Entities.Models;

namespace ChatApp.Presentation.Views
{
    public class PrivateMessages
    {
        private User _currentUser;

        public PrivateMessages(User currentUser)
        {
            _currentUser = currentUser;
        }
        public void Show()
        {
            // Implementacija prikaza privatnih poruka
        }
    }

}

