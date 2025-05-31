using DevExpress.Mvvm;
using Pulse.PLMSuite.Modeller.Documents;

namespace Pulse.PLMSuite.ViewModels
{
    public class AssemblyDocumentViewModel : ViewModelBase
    {
        public AssemblyDocument Document { get; }

        public AssemblyDocumentViewModel()
        {
            Document = new AssemblyDocument();
        }
    }
}
