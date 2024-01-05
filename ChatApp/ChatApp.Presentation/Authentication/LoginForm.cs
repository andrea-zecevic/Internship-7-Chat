using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Factories;
using ChatApp.Domain.Repositories;
using ChatApp.Presentation.Views;

namespace ChatApp.Presentation.Authentication
{
    public class LoginForm
    {
        private static DateTime _lastFailedLoginTime;
        public void Show()
        {
            Console.WriteLine("\n--- Login ---");

            if (IsLoginTimeoutActive())
            {
                Console.WriteLine("Molimo pričekajte prije ponovnog pokušaja prijave.");
                return;
            }

            Console.Write("Unesite e-mail: ");
            var email = Console.ReadLine();

            Console.Write("Unesite lozinku: ");
            var password = Console.ReadLine();

            var user = AuthenticateUser(email, password);

            if (user == null)
            {
                _lastFailedLoginTime = DateTime.Now;
                Console.WriteLine("Netočna kombinacija e-maila i lozinke. Pokušajte ponovno.");
            }
            else
            {
                var dashboardMenu = new DashboardMenu(user);
                dashboardMenu.Show();
            }
        }

        private static bool IsLoginTimeoutActive()
        {
            if (_lastFailedLoginTime == DateTime.MinValue) return false;

            var timeSinceLastFail = DateTime.Now - _lastFailedLoginTime;
            return timeSinceLastFail.TotalSeconds < 30;
        }

        private static User AuthenticateUser(string email, string password)
        {
            var userRepository = RepositoryFactory.Create<UserRepository>();
            var user = userRepository.GetByEmail(email);

            if (user != null && user.Password == password)
            {
                return user;
            }

            return null;
        }

    }

}
