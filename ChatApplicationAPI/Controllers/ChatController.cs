using System;
using Microsoft.AspNetCore.Mvc;

namespace ChatApplicationAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private static List<ChatMessage> chatHistory = new List<ChatMessage>();

        [HttpGet("getchathistory")]
        public IActionResult GetChatHistory()
        {
            return Ok(chatHistory);
        }

        [HttpPost]
        [Route("savechatmessage")]
        public IActionResult SaveChatMessage([FromBody]ChatMessage message)
        {
            message.Id = chatHistory.Count + 1;
            message.SentOn = DateTime.Now;
            chatHistory.Add(message);
            return Ok();
        }
    }
}

