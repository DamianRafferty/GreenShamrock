using devDept.Eyeshot.Control;
using System.Windows.Input;

namespace Pulse.PLMSuite.Modeller.Controls
{
    /// <summary>
    /// Customized Eyeshot Design control with additional behavior.
    /// </summary>
    public class Viewport3d : Design
    {
        /// <summary>
        /// Resets the active view by performing a ZoomFit.
        /// </summary>
        public void ResetView()
        {
            ZoomFit();
        }

        /// <summary>
        /// Overrides the preview key handling to provide a Ctrl+R shortcut
        /// for resetting the view.
        /// </summary>
        /// <param name="e">Key event data.</param>
        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            base.OnPreviewKeyDown(e);

            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.R)
            {
                ResetView();
                e.Handled = true;
            }
        }
    }
}
