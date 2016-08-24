using Microsoft.AspNetCore.SignalR;

namespace SignalRBugRepro.Hubs
{
    public class TestHub : Hub
    {
        public void SendMessage(string message)
        {
            Clients.All.SendMessage(message);
        }
    }
}
