namespace ChatApp.Application.Common.Interfaces
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string message,int groupId);

    }
}
