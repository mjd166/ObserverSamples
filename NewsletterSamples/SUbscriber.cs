namespace NewsletterSamples
{
    public class SUbscriber : IObserver
    {
        private string name;
        public SUbscriber(string name)
        {
            this.name = name;
        }
        public void Update(string message)
        {
            Console.WriteLine($"{name} received : {message}");
        }
    }
}
