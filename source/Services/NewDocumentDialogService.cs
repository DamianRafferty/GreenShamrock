using Pulse.PLMSuite;
using Pulse.PLMSuite.Modeller.Views;
using Pulse.PLMSuite.ViewModels;

namespace Pulse.PLMSuite.Services
{
    public class NewDocumentDialogService : INewDocumentDialogService
    {
        public DocumentType? ShowDialog()
        {
            var vm = new NewDocumentViewModel();
            var window = new NewDocumentWindow
            {
                DataContext = vm
            };

            bool? result = window.ShowDialog();
            if (result == true)
                return vm.SelectedType;

            return null;
        }
    }
}
