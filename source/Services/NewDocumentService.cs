using System.Windows;
using Pulse.PLMSuite.Modeller.Views;
using Pulse.PLMSuite.ViewModels;

namespace Pulse.PLMSuite.Modeller.Services
{
    public class NewDocumentService : INewDocumentService
    {
        public DocumentType? ShowDialog()
        {
            var vm = new NewDocumentViewModel();
            var window = new NewDocumentWindow
            {
                DataContext = vm,
                Owner = Application.Current.MainWindow
            };
            vm.Close = r => window.DialogResult = r;
            var result = window.ShowDialog();
            return result == true ? vm.SelectedType : null;
        }
    }
}
