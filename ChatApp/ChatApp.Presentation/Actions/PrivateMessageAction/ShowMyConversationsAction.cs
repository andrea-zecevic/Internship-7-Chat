using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Factories;
using ChatApp.Domain.Repositories;
using ChatApp.Presentation.Helpers;

namespace ChatApp.Presentation.Actions.PrivateMessageAction
{
    public class ShowMyConversationsAction
    {
        private User _currentUser;

        public ShowMyConversationsAction(User currentUser)
        {
            _currentUser = currentUser;
        }

        public void Execute()
        {
            var privateMessageRepository = RepositoryFactory.Create<PrivateMessageRepository>();

            var myMessages = privateMessageRepository.GetByUserId(_currentUser.UserId);

            var contactedUsers = myMessages
                .Select(msg => msg.SenderUserId == _currentUser.UserId ? msg.ReceiverUser : msg.SenderUser)
                .Distinct()
                .OrderByDescending(user => myMessages.Where(msg => msg.SenderUserId == user.UserId || msg.ReceiverUserId == user.UserId)
                                                      .Max(msg => msg.Timestamp))
                .ToList();

            for (int i = 0; i < contactedUsers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {contactedUsers[i].UserName}");
            }

            Console.Write("\nOdaberite korisnika za prikaz poruka: ");
            if (int.TryParse(Console.ReadLine(), out int userIndex) &&
                userIndex >= 1 && userIndex <= contactedUsers.Count)
            {
                var selectedUser = contactedUsers[userIndex - 1];
                new ChatScreen(_currentUser, selectedUser).Show();
            }
            else
            {
                Console.WriteLine("Nevazeci odabir.");
                NavigationHelper.ReturnToDashboard(_currentUser);
            }

            NavigationHelper.ReturnToDashboard(_currentUser);
        }


    }
}
