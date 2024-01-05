using ChatApp.Data.Entities.Models;

namespace ChatApp.Presentation.Views
{
    public class Logout
    {
        private User _currentUser;

        public Logout(User currentUser)
        {
            _currentUser = currentUser;
        }
        public void Execute()
        {
            // Logika za odjavu
        }
    }
}

