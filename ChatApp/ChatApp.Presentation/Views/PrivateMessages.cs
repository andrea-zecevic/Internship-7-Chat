using ChatApp.Data.Entities.Models;
using ChatApp.Presentation.Actions.PrivateMessageAction;

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
            var options = new List<(string, Action)>
            {
                ("Nova poruka", () => new SendNewPrivateMessageAction(_currentUser).Execute()),
                ("Prikaži sve moje razgovore", () => new ShowMyConversationsAction(_currentUser).Execute())
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Privatne Poruke ---");

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

