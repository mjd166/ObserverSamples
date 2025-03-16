using ChatApp.Application.Common.Interfaces;

namespace ChatApp.Application.Services
{
    public class UserConnection : IObserver
    {
        private readonly string _connectionId;
        private readonly IWebSocketService webSocketService;

        public UserConnection(IWebSocketService webSocketService, string connectionId)
        {
            this.webSocketService = webSocketService;
            _connectionId = connectionId;
        }

        public void Update(string message, int groupId)
        {
            webSocketService.SendMessageAsync(_connectionId, $"New message on Group : {groupId} Message : {message}");
        }
    }
}
