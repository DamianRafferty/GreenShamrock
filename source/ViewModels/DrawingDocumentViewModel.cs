using DevExpress.Mvvm;
using Pulse.PLMSuite.Modeller.Documents;

namespace Pulse.PLMSuite.ViewModels
{
    public class DrawingDocumentViewModel : ViewModelBase
    {
        public DrawingDocument Document { get; }

        public DrawingDocumentViewModel()
        {
            Document = new DrawingDocument();
        }
    }
}
