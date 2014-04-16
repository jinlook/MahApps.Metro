using System.Windows;

namespace MVVMApps.Metro.Controls
{
    /// <summary>
    /// A MetroTabControl (Pivot) that uses a TransitioningContentControl to animate the contents of a TabItem/MetroTabItem.
    /// </summary>
    public class MetroAnimatedTabControl : BaseMetroTabControl
    {
        /// <summary>
        /// Initializes a new instance of the MVVMApps.Metro.Controls.MetroAnimatedTabControl class.
        /// </summary>
        public MetroAnimatedTabControl()
        {
            DefaultStyleKey = typeof(MetroAnimatedTabControl);
        }
    }
}
