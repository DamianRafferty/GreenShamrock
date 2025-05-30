using System.Windows;

namespace Pulse.PLMSuite.Services
{
    public class MessageService : IMessageService
    {
        public void Show(string message, string caption)
        {
            MessageBox.Show(message, caption);
        }
    }
}
