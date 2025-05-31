using DevExpress.Mvvm;
using Pulse.PLMSuite.Services;

namespace Pulse.PLMSuite.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IMessageService _messageService;

        public DelegateCommand NewCommand { get; }

        public MainWindowViewModel(IMessageService messageService)
        {
            _messageService = messageService;

            NewCommand = new DelegateCommand(OnNew);
        }

        private void OnNew()
        {
            // TODO: Implement new action logic
            _messageService.Show("New command executed", "Info");
        }
    }
}
