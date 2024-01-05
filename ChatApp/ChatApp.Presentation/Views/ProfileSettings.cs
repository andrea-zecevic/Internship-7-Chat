
using ChatApp.Data.Entities.Models;

namespace ChatApp.Presentation.Views
{
    public class ProfileSettings
    {
        private User _currentUser;

        public ProfileSettings(User currentUser)
        {
            _currentUser = currentUser;
        }
        public void Show()
        {
            // Implementacija prikaza postavki profila
        }
    }
}

