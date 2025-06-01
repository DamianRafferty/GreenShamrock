using devDept.Eyeshot.Control;
using System.Windows.Forms;

namespace Pulse.PLMSuite.Modeller.Controls
{
    /// <summary>
    /// Customized Eyeshot Drawing control with additional behavior.
    /// </summary>
    public class Viewport2D : Drawing
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
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.Control && e.KeyCode == Keys.R)
            {
                ResetView();
                e.Handled = true;
            }
        }
    }
}
