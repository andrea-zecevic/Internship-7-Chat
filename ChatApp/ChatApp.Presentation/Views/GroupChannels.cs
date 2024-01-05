using ChatApp.Data.Entities.Models;
using ChatApp.Presentation.Actions.ChannelActions;

namespace ChatApp.Presentation.Views
{
    public class GroupChannels
    {

        private User _currentUser;

        public GroupChannels(User currentUser)
        {
            _currentUser = currentUser;
        }
        public void Show()
        {
            var options = new List<(string, Action)>
            {
                ("Kreiraj novi kanal", () => new CreateNewChannelAction(_currentUser).Execute()),
                ("Ulazak u kanal", () => new JoinChannelAction(_currentUser).Execute()),
                ("Prikaži moje kanale", () => new ShowMyChannelsAction(_currentUser).Execute()),
                ("IZLAZ", () =>  new DashboardMenu(_currentUser).Show())
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Grupni Kanali ---");

                for (int i = 0; i < options.Count; i++)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{i + 1}. {options[i].Item1}");
                    Console.ResetColor();
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