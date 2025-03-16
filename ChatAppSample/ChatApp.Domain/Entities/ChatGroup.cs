namespace ChatApp.Domain.Entities
{
    public class ChatGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }

    }

}
