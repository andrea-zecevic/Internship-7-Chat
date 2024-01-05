using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Factories;
using ChatApp.Domain.Repositories;
using ChatApp.Presentation.Helpers;

namespace ChatApp.Presentation.Actions.ChannelActions
{
    public class JoinChannelAction
    {
        private User _currentUser;

        public JoinChannelAction(User currentUser)
        {
            _currentUser = currentUser;
        }

        public void Execute()
        {
            var channelRepository = RepositoryFactory.Create<ChannelRepository>();
            var userChannelRepository = RepositoryFactory.Create<UserChannelRepository>();

            var allChannels = channelRepository.GetAll();


            var notJoinedChannels = allChannels.Where(channel =>
                !channel.ChannelUsers.Any(uc => uc.UserId == _currentUser.UserId)).ToList();

            if (!notJoinedChannels.Any())
            {
                Console.WriteLine("Nema dostupnih kanala za pristup.");
                return;
            }

            Console.WriteLine("Dostupni kanali za pristup:");
            for (int i = 0; i < notJoinedChannels.Count; i++)
            {
                var channel = notJoinedChannels[i];
                Console.WriteLine($"{i + 1}. {channel.ChannelName} - Članovi: {channel.ChannelUsers.Count}");
            }

            Console.Write("\nOdaberite broj kanala kojem želite pristupiti: ");
            if (int.TryParse(Console.ReadLine(), out int channelIndex) &&
                channelIndex >= 1 && channelIndex <= notJoinedChannels.Count)
            {
                var selectedChannel = notJoinedChannels[channelIndex - 1];


                var newUserChannel = new UserChannel
                {
                    UserId = _currentUser.UserId,
                    ChannelId = selectedChannel.ChannelId
                };
                userChannelRepository.Add(newUserChannel);

                Console.WriteLine($"Uspješno ste pridruženi kanalu '{selectedChannel.ChannelName}'.");
            }
            else
            {
                Console.WriteLine("Nevažeći odabir.");
            }

            NavigationHelper.ReturnToDashboard(_currentUser);
        }
    }


}

