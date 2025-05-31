using DevExpress.Mvvm;
using Pulse.PLMSuite.Modeller.Documents;

namespace Pulse.PLMSuite.ViewModels
{
    public class PartDocumentViewModel : ViewModelBase
    {
        public PartDocument Document { get; }

        public PartDocumentViewModel()
        {
            Document = new PartDocument();
        }
    }
}
