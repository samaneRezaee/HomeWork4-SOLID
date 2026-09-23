

using HomeWork4.Task7_Store_.Interfaces;

namespace HomeWork4.Task7_Store_.Implementations
{
    public class EmailNotification : INotificationService
    {
        public void Send(string message) => Console.WriteLine($"Email Service: {message}");
    }
}
