using Microsoft.AspNetCore.SignalR;

namespace SignalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string username, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", username, message);
        }

        public async Task SendNotifcation(string message)
        {
            await Clients.All.SendAsync("ReceiveNotification", message);
        }

        public async Task SendMessageToUser(string userId, string message)
        {
            await Clients.User(userId).SendAsync("ReceiveMsg", userId, message);
        }
    }
}
