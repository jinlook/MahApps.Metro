using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using MVVMApps.Metro.Native;

namespace MVVMApps.Metro.Controls
{
    public class WindowCommands : ItemsControl
    {
        static WindowCommands()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowCommands), new FrameworkPropertyMetadata(typeof(WindowCommands)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }
    }
}
