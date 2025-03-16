namespace ChatApp.Application.Common.Interfaces
{
    public interface IObserver
    {
        void Update(string message, int groupId);
    }
}
