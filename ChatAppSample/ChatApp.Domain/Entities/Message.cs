namespace ChatApp.Domain.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int ChatGroupId { get; set; }
        public ChatGroup ChatGroup { get; set; }

    }

}
