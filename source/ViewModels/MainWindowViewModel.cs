using DevExpress.Mvvm;
using System.Windows;

namespace Pulse.PLMSuite.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public DelegateCommand NewCommand { get; }

        public MainWindowViewModel()
        {
            NewCommand = new DelegateCommand(OnNew);
        }

        private void OnNew()
        {
            // TODO: Implement new action logic
            MessageBox.Show("New command executed", "Info");
        }
    }
}
