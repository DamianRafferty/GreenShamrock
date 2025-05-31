using DevExpress.Mvvm;
using Pulse.PLMSuite.Services;
using Pulse.PLMSuite.Modeller;
using Pulse.PLMSuite.Modeller.Services;

namespace Pulse.PLMSuite.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IMessageService _messageService;
        private readonly INewDocumentService _newDocumentService;

        private object _currentDocument;
        public object CurrentDocument
        {
            get => _currentDocument;
            set => SetProperty(ref _currentDocument, value, nameof(CurrentDocument));
        }

        public DelegateCommand NewCommand { get; }

        public MainWindowViewModel(IMessageService messageService, INewDocumentService newDocumentService)
        {
            _messageService = messageService;
            _newDocumentService = newDocumentService;

            NewCommand = new DelegateCommand(OnNew);
        }

        private void OnNew()
        {
            var type = _newDocumentService.ShowDialog();
            if (type == null)
                return;

            switch (type)
            {
                case DocumentType.Part:
                    CurrentDocument = new PartDocumentViewModel();
                    break;
                case DocumentType.Assembly:
                    CurrentDocument = new AssemblyDocumentViewModel();
                    break;
                case DocumentType.Drawing:
                    CurrentDocument = new DrawingDocumentViewModel();
                    break;
            }
        }
    }
}
