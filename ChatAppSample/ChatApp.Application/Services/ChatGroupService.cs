using ChatApp.Application.Common.Interfaces;

namespace ChatApp.Application.Services
{
    public class ChatGroupService : ISubject
    {
        private readonly List<IObserver> observers = new();

        public void Attach(IObserver observer) => observers.Add(observer);

        public void Detach(IObserver observer) => observers.Remove(observer);

        public void Notify(string message,int groupId)
        {
            foreach (var item in observers)
            {
                item.Update(message,groupId );
            }
        }
    }
}
