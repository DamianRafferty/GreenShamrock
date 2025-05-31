using DevExpress.Mvvm;
using Pulse.PLMSuite.Modeller;
using System;

namespace Pulse.PLMSuite.ViewModels
{
    public class NewDocumentViewModel : ViewModelBase
    {
        public DocumentType? SelectedType { get; private set; }

        public DelegateCommand<object> SelectCommand { get; }

        public Action<bool?> Close { get; set; }

        public NewDocumentViewModel()
        {
            SelectCommand = new DelegateCommand<object>(OnSelect);
        }

        private void OnSelect(object parameter)
        {
            if (parameter is DocumentType type)
            {
                SelectedType = type;
                Close?.Invoke(true);
            }
        }
    }
}
