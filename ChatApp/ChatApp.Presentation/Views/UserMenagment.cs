using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Factories;
using ChatApp.Domain.Repositories;

namespace ChatApp.Presentation.Views
{
    public class UserManagement
    {
        private User _currentUser;

        public UserManagement(User currentUser)
        {
            _currentUser = currentUser;
        }

        public void Show()
        {
            if (!(_currentUser is Admin))
            {
                Console.WriteLine("Nemate pristup ovom dijelu aplikacije.");
                return;
            }

            var userRepository = RepositoryFactory.Create<UserRepository>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- User Management ---\n");

                var users = userRepository.GetAll().ToList();
                if (users.Count == 0)
                {
                    Console.WriteLine("Nema registriranih korisnika.");
                    break;
                }

                for (int i = 0; i < users.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {users[i].UserName} - Email: {users[i].Email}");
                }

                Console.WriteLine("\nOdaberite korisnika za upravljanje:");
                Console.WriteLine("Unesite '0' za povratak na Dashboard.");
                Console.Write("Vaš odabir: ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= users.Count)
                {
                    ManageUser(users.ElementAt(choice - 1));
                }
                else if (choice == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nevažeći odabir.");
                }
            }
        }

        private void ManageUser(User user)
        {
            Console.Clear();
            Console.WriteLine($"--- Upravljanje korisnikom: {user.UserName} ---");
            Console.WriteLine("1. Izbriši profil");
            Console.WriteLine("2. Promijeni email");
            Console.WriteLine("3. Promoviraj u admina");
            Console.Write("\nVaš odabir: ");

            var choice = Console.ReadLine();
            var userRepository = RepositoryFactory.Create<UserRepository>();

            switch (choice)
            {
                case "1":
                    userRepository.Delete(user.UserId);
                    Console.WriteLine("Korisnik je uspješno izbrisan.");
                    break;
                case "2":
                    Console.Write("Unesite novi email: ");
                    var newEmail = Console.ReadLine();
                    user.Email = newEmail;
                    userRepository.Update(user, user.UserId);
                    Console.WriteLine("Email je promijenjen.");
                    break;
                case "3":
                    if (!(user is Admin))
                    {
                        var adminUser = new Admin(user.UserName, user.Email, user.Password);
                        userRepository.Update(adminUser, adminUser.UserId);
                        Console.WriteLine("Korisnik je promoviran u admina.");
                    }
                    else
                    {
                        Console.WriteLine("Korisnik je već admin.");
                    }
                    break;
                default:
                    Console.WriteLine("Nevažeći odabir.");
                    break;
            }

            Console.WriteLine("\nPritisnite bilo koju tipku za povratak.");
            Console.ReadKey();
        }
    }
}
