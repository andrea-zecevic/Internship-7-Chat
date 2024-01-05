using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Factories;
using ChatApp.Domain.Repositories;
using System.Text.RegularExpressions;

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
            Console.WriteLine("\n--- Postavke Profila ---");
            Console.WriteLine("1. Promijeni E-mail");
            Console.WriteLine("2. Promijeni Lozinku");
            Console.WriteLine("3. Povratak na Dashboard");

            Console.Write("\nOdaberite opciju: ");
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ChangeEmail();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    ChangePassword();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    new DashboardMenu(_currentUser).Show();
                    break;
                default:
                    Console.WriteLine("\nNeispravan unos.");
                    break;
            }
        }

        private void ChangeEmail()
        {
            Console.Write("\nUnesite novi e-mail: ");
            var newEmail = Console.ReadLine();

            if (!IsValidEmail(newEmail))
            {
                Console.WriteLine("E-mail nije u ispravnom formatu.");
                return;
            }

            var userRepository = RepositoryFactory.Create<UserRepository>();
            _currentUser.Email = newEmail;
            userRepository.Update(_currentUser, _currentUser.UserId);

            Console.WriteLine("E-mail uspješno promijenjen.");
        }

        private void ChangePassword()
        {
            Console.Write("\nUnesite novu lozinku: ");
            var newPassword = Console.ReadLine();

            var userRepository = RepositoryFactory.Create<UserRepository>();
            _currentUser.Password = newPassword;
            userRepository.Update(_currentUser, _currentUser.UserId);

            Console.WriteLine("Lozinka uspješno promijenjena.");
        }


        private static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
