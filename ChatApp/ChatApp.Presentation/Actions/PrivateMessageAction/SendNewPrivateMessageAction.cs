using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Factories;
using ChatApp.Domain.Repositories;
using ChatApp.Presentation.Helpers;

namespace ChatApp.Presentation.Actions.PrivateMessageAction
{
    public class SendNewPrivateMessageAction
    {
        private User _currentUser;

        public SendNewPrivateMessageAction(User currentUser)
        {
            _currentUser = currentUser;
        }

        public void Execute()
        {
            var userRepository = RepositoryFactory.Create<UserRepository>();
            var privateMessageRepository = RepositoryFactory.Create<PrivateMessageRepository>();

            var users = userRepository.GetAll().Where(u => u.UserId != _currentUser.UserId).ToList();

            if (!users.Any())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNema dostupnih korisnika za slanje poruke.");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nOdaberite korisnika za slanje poruke:");
            Console.ResetColor();
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {users[i].UserName}");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nUnesite broj korisnika: ");
            Console.ResetColor();
            if (int.TryParse(Console.ReadLine(), out int userIndex) &&
                userIndex >= 1 && userIndex <= users.Count)
            {
                var receiverUser = users[userIndex - 1];

                Console.Write("Unesite poruku: ");
                var messageContent = Console.ReadLine();
                var myDateTimeUtc = DateTime.UtcNow;


                var message = new PrivateMessage
                {
                    SenderUserId = _currentUser.UserId,
                    ReceiverUserId = receiverUser.UserId,
                    Timestamp = myDateTimeUtc,
                    Content = messageContent
                };

                privateMessageRepository.Add(message);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPoruka je poslana.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNevažeći odabir.");
                Console.ResetColor();
            }

            NavigationHelper.ReturnToDashboard(_currentUser);
        }
    }
}
