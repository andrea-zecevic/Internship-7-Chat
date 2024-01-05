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
                Console.WriteLine("Nema dostupnih korisnika za slanje poruke.");
                return;
            }

            Console.WriteLine("Odaberite korisnika za slanje poruke:");
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {users[i].UserName}");
            }

            Console.Write("\nOdaberite broj korisnika: ");
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

                Console.WriteLine("Poruka je poslana.");
            }
            else
            {
                Console.WriteLine("Nevazeci odabir.");
            }

            NavigationHelper.ReturnToDashboard(_currentUser);
        }
    }
}
