using DevExpress.Mvvm;
using Pulse.PLMSuite.Services;
using Pulse.PLMSuite.Modeller;
using Pulse.PLMSuite.Modeller.Services;
using System.Collections.ObjectModel;

namespace Pulse.PLMSuite.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IMessageService _messageService;
        private readonly INewDocumentService _newDocumentService;

        private object _selectedDocument;
        public ObservableCollection<object> Documents { get; }
        public object SelectedDocument
        {
            get => _selectedDocument;
            set => SetProperty(ref _selectedDocument, value, nameof(SelectedDocument));
        }

        public DelegateCommand NewCommand { get; }

        public MainWindowViewModel(IMessageService messageService, INewDocumentService newDocumentService)
        {
            _messageService = messageService;
            _newDocumentService = newDocumentService;

            Documents = new ObservableCollection<object>();
            NewCommand = new DelegateCommand(OnNew);
        }

        private void OnNew()
        {
            var type = _newDocumentService.ShowDialog();
            if (type == null)
                return;

            object document = null;
            switch (type)
            {
                case DocumentType.Part:
                    document = new PartDocumentViewModel();
                    break;
                case DocumentType.Assembly:
                    document = new AssemblyDocumentViewModel();
                    break;
                case DocumentType.Drawing:
                    document = new DrawingDocumentViewModel();
                    break;
            }

            if (document != null)
            {
                Documents.Add(document);
                SelectedDocument = document;
            }
        }
    }
}
