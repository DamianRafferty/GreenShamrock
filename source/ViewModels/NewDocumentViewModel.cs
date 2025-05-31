using System;
using DevExpress.Mvvm;

namespace Pulse.PLMSuite.ViewModels
{
    public class NewDocumentViewModel : ViewModelBase
    {
        private DocumentType _selectedType;

        public DocumentType SelectedType
        {
            get => _selectedType;
            set => SetProperty(ref _selectedType, value);
        }

        public DelegateCommand OKCommand { get; }
        public DelegateCommand CancelCommand { get; }

        public NewDocumentViewModel()
        {
            OKCommand = new DelegateCommand(OnOk);
            CancelCommand = new DelegateCommand(OnCancel);
        }

        public event Action<bool?>? CloseRequested;

        private void OnOk()
        {
            CloseRequested?.Invoke(true);
        }

        private void OnCancel()
        {
            CloseRequested?.Invoke(false);
        }
    }
}
