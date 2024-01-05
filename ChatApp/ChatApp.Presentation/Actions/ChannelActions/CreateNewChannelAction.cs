using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Factories;
using ChatApp.Domain.Repositories;
using ChatApp.Presentation.Helpers;

namespace ChatApp.Presentation.Actions.ChannelActions
{
    public class CreateNewChannelAction
    {
        private User _currentUser;

        public CreateNewChannelAction(User currentUser)
        {
            _currentUser = currentUser;
        }

        public void Execute()
        {
            Console.WriteLine("Unesite ime novog kanala:");
            var channelName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(channelName))
            {
                Console.WriteLine("Ime kanala ne može biti prazno.");
                return;
            }

            var channelRepository = RepositoryFactory.Create<ChannelRepository>();
            var userChannelRepository = RepositoryFactory.Create<UserChannelRepository>();

            var newChannel = new Channel { ChannelName = channelName };
            channelRepository.Add(newChannel);

            var newUserChannel = new UserChannel
            {
                UserId = _currentUser.UserId,
                ChannelId = newChannel.ChannelId
            };
            userChannelRepository.Add(newUserChannel);

            Console.WriteLine($"Kanal '{channelName}' je uspješno kreiran i vi ste dodani kao član.");

            NavigationHelper.ReturnToDashboard(_currentUser);

        }
    }
}
