using System.Windows;
using System.Windows.Controls;

namespace MVVMApps.Metro.Controls
{
    public class WindowCommands : ItemsControl
    {
        static WindowCommands()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowCommands), new FrameworkPropertyMetadata(typeof(WindowCommands)));
        }
    }
}
