using Microsoft.AspNetCore.SignalR;

namespace SignalRServer.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        //private readonly IHubContext<ChatHub> _hub;

        //public Task SendNotificationAsync(string message)
        //{
        //    return _hub.Clients.All.SendAsync("ReceiveMessage", message);
        //}
    }
}
