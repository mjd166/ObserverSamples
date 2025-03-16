namespace NewsletterSamples
{
    /// <summary>
    /// Subject interface
    /// </summary>
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string message);
    }


    /// <summary>
    /// news publisher has list of observers and publish them the news
    /// </summary>
    public class Newspublisher : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers) 
                observer.Update(message);
        }
    }
}
