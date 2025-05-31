using DevExpress.Mvvm;
using Pulse.PLMSuite.Services;
using Pulse.PLMSuite;

namespace Pulse.PLMSuite.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IMessageService _messageService;
        private readonly INewDocumentDialogService _newDocumentDialogService;
        private DocumentType? _currentDocumentType;

        public DelegateCommand NewCommand { get; }

        public DocumentType? CurrentDocumentType
        {
            get => _currentDocumentType;
            set => SetProperty(ref _currentDocumentType, value);
        }

        public MainWindowViewModel(IMessageService messageService, INewDocumentDialogService newDocumentDialogService)
        {
            _messageService = messageService;
            _newDocumentDialogService = newDocumentDialogService;

            NewCommand = new DelegateCommand(OnNew);
        }

        private void OnNew()
        {
            var type = _newDocumentDialogService.ShowDialog();
            if (type.HasValue)
            {
                CurrentDocumentType = type.Value;
            }
        }
    }
}
