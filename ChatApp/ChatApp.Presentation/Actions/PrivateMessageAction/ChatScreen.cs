using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Factories;
using ChatApp.Domain.Repositories;

namespace ChatApp.Presentation.Actions.PrivateMessageAction
{
    public class ChatScreen
    {
        private User _currentUser;
        private User _selectedUser;

        public ChatScreen(User currentUser, User selectedUser)
        {
            _currentUser = currentUser;
            _selectedUser = selectedUser;
        }

        public void Show()
        {
            var privateMessageRepository = RepositoryFactory.Create<PrivateMessageRepository>();

            while (true)
            {
                var conversation = privateMessageRepository.GetConversation(_currentUser.UserId, _selectedUser.UserId);

                Console.Clear();
                Console.WriteLine($"\nChat s {_selectedUser.UserName}:\n");
                Console.WriteLine("Vrijeme\t\tPosiljatelj\tPoruka");
                Console.WriteLine(new string('-', 50));

                foreach (var message in conversation)
                {
                    string sender = message.SenderUserId == _currentUser.UserId ? "Vi" : _selectedUser.UserName;
                    Console.WriteLine($"{message.Timestamp:dd.MM.yyyy HH:mm}\t{sender}\t{message.Content}");
                }

                Console.Write("\nUnesite poruku (ili '/exit' za izlaz): ");
                var input = Console.ReadLine();

                if (input == "/exit")
                {
                    break;
                }
                else
                {
                    var newMessage = new PrivateMessage
                    {
                        Timestamp = DateTime.UtcNow,
                        SenderUserId = _currentUser.UserId,
                        ReceiverUserId = _selectedUser.UserId,
                        Content = input
                    };

                privateMessageRepository.Add(newMessage);
                }                
            }

        }
    }
}

