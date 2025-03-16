
using ChatApp.Application.Common.Interfaces;
using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;

namespace ChatApp.Infrastructure.Services
{
    public class WebSocketService : IWebSocketService
    {
        private readonly ConcurrentDictionary<string, WebSocket> _connections= new ConcurrentDictionary<string, WebSocket> ();

        public void AddConnection(string connectionId, WebSocket socket)
        {
            _connections[connectionId] = socket;
        }

        public async Task SendMessageAsync(string connectionId, string message)
        {
            if(_connections.ContainsKey(connectionId))
            {
                var buffer= Encoding.UTF8.GetBytes(message);
                await _connections[connectionId].SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);

            }
        }
    }
}
