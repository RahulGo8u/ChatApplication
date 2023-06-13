using System;
namespace ChatApplicationAPI
{
	public class ChatMessage
	{
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Content { get; set; }
        public DateTime SentOn { get; set; }
    }
}

