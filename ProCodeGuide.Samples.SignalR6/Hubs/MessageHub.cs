using Microsoft.AspNetCore.SignalR;

namespace ProCodeGuide.Samples.SignalR6.Hubs
{
    public class MessageHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            if (string.IsNullOrEmpty(user))
                await Clients.All.SendAsync("ReceiveMessageHandler", message);
            else
                await Clients.User(user).SendAsync("ReceiveMessageHandler", message);
        }
    }
}
