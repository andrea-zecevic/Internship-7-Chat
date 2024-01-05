using ChatApp.Data.Entities.Models;

namespace ChatApp.Presentation.Views
{
    public class Logout
    {
        private User? _currentUser;

        public Logout(User currentUser)
        {
            _currentUser = currentUser;
        }
        public void Execute()
        {
            Console.WriteLine("Odjavljujete se iz aplikacije...");
            _currentUser = null;

            Program.ShowMainMenu();
        }

    }
}

