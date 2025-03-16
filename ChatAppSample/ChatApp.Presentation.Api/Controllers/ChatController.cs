using ChatApp.Application.Services;
using ChatApp.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly WebSocketService webSocketService;
        private static readonly Dictionary<int, ChatGroupService> chatGroups = new();
        public ChatController(WebSocketService webSocketService)
        {
            this.webSocketService = webSocketService;
        }

        [HttpPost("send")]
        public IActionResult SendMessage(int groupId,string message)
        {
            if(chatGroups.ContainsKey(groupId))
            {
                chatGroups[groupId].Notify(message,groupId);
                return Ok("Messge sent!");
            }
            return NotFound("the group not found.");
        }

        [HttpPost("join")]
        public IActionResult JoinGroup(int groupId,string _ConnectionId)
        {
            if(!chatGroups.ContainsKey(groupId)) 
                chatGroups[groupId] = new ChatGroupService();

            var userConneciton = new UserConnection(webSocketService, _ConnectionId);
            chatGroups[groupId].Attach(userConneciton);

            return Ok("successfully joined");
        }

    }
}
