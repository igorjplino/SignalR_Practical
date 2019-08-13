using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalR.Practical
{
    public class MessageHub : Hub
    {
        public Task SendMessageToAll(string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}