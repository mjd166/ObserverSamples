namespace ChatApp.Application.Common.Interfaces
{
    public interface IWebSocketService
    {
        void AddConnection(string connectionId, System.Net.WebSockets.WebSocket socket);
        Task SendMessageAsync(string connectionId, string message);
    }
}
