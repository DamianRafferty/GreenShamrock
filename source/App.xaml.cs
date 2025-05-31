using System.Windows;
using DevExpress.Xpf.Core;

namespace Pulse.PLMSuite.Modeller
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ApplicationThemeHelper.ApplicationThemeName = Theme.Office2019WhiteName;
            base.OnStartup(e);
        }
    }
}
