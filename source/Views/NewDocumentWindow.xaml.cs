using System.Windows;
using Pulse.PLMSuite;
using Pulse.PLMSuite.ViewModels;

namespace Pulse.PLMSuite.Modeller.Views
{
    public partial class NewDocumentWindow : Window
    {
        public NewDocumentWindow()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is NewDocumentViewModel vm)
            {
                vm.CloseRequested += Vm_CloseRequested;
                UpdateSelection(vm.SelectedType);
            }
        }

        private void Vm_CloseRequested(bool? result)
        {
            DialogResult = result;
        }

        private void OnPartChecked(object sender, RoutedEventArgs e)
        {
            SetType(DocumentType.Part);
        }

        private void OnAssemblyChecked(object sender, RoutedEventArgs e)
        {
            SetType(DocumentType.Assembly);
        }

        private void OnDrawingChecked(object sender, RoutedEventArgs e)
        {
            SetType(DocumentType.Drawing);
        }

        private void SetType(DocumentType type)
        {
            if (DataContext is NewDocumentViewModel vm)
            {
                vm.SelectedType = type;
            }
        }

        private void UpdateSelection(DocumentType type)
        {
            switch (type)
            {
                case DocumentType.Part:
                    partRadio.IsChecked = true;
                    break;
                case DocumentType.Assembly:
                    assemblyRadio.IsChecked = true;
                    break;
                case DocumentType.Drawing:
                    drawingRadio.IsChecked = true;
                    break;
            }
        }
    }
}
