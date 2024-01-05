using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Factories;
using ChatApp.Domain.Repositories;

namespace ChatApp.Presentation.Actions.ChannelActions
{
    public class ShowMyChannelsAction
    {
        private User _currentUser;

        public ShowMyChannelsAction(User currentUser)
        {
            _currentUser = currentUser;
        }

        public void Execute()
        {
            var userChannelRepository = RepositoryFactory.Create<UserChannelRepository>();
            var messageRepository = RepositoryFactory.Create<MessageRepository>();

            var userChannels = userChannelRepository.GetUserChannelsByUserId(_currentUser.UserId);

            if (!userChannels.Any())
            {
                Console.WriteLine("Niste član nijednog kanala.");
                return;
            }

            Console.WriteLine("Kanali:");
            var userChannelsList = userChannels.ToList();
            for (int i = 0; i < userChannelsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {userChannelsList[i].Channel.ChannelName}");
            }


            Console.Write("\nOdaberite broj kanala: ");
            if (int.TryParse(Console.ReadLine(), out int channelIndex) &&
                channelIndex >= 1 && channelIndex <= userChannels.Count)
            {
                var selectedChannel = userChannelsList[channelIndex - 1].Channel;
                DisplayChannelMessages(selectedChannel, messageRepository);
            }
            else
            {
                Console.WriteLine("Nevažeći odabir.");
            }
        }

        private void DisplayChannelMessages(Channel channel, MessageRepository messageRepository)
        {
            var messages = messageRepository.GetMessagesByChannelId(channel.ChannelId);

            Console.WriteLine($"--- Poruke u kanalu {channel.ChannelName} ---");
            foreach (var message in messages)
            {
                Console.WriteLine($"[{message.Timestamp}] {message.User.UserName}: {message.Content}");
            }

            Console.WriteLine("\nUnesite poruku (ili '/exit' za povratak): ");
            var input = Console.ReadLine();
            if (input == "/exit")
            {
                return;
            }

            var newMessage = new Message
            {
                UserId = _currentUser.UserId,
                ChannelId = channel.ChannelId,
                Content = input,
                Timestamp = DateTime.UtcNow
            };

            messageRepository.Add(newMessage);

            DisplayChannelMessages(channel, messageRepository);
        }
    }
}
