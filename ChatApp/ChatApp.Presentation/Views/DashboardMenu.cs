using ChatApp.Data.Entities.Models;

namespace ChatApp.Presentation.Views
{
    public class DashboardMenu
    {
        private User _currentUser;

        public DashboardMenu(User currentUser)
        {
            _currentUser = currentUser;
        }

        public void Show()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Dashboard ---");

                var options = new List<(string, Action)>
                {
                    ("Grupni kanali", () => new GroupChannels().Show()),
                    ("Privatne poruke", () => new PrivateMessages().Show()),
                    ("Postavke profila", () => new ProfileSettings().Show()),
                    ("Odjava iz profila", () => new Logout().Execute())
                };


                if (_currentUser is Admin)
                {
                    options.Insert(2, ("User management", () => new UserManagement().Show()));
                }

                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {options[i].Item1}");
                }

                Console.Write("\nOdaberite opciju: ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= options.Count)
                {
                    options[choice - 1].Item2();
                }
                else
                {
                    Console.WriteLine("Nevažeći odabir. Pokušajte ponovno.");
                    Console.ReadKey();
                }
            }
        }

    }
}
