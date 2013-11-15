﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace MVVMApps.Metro.Controls
{
    public class ComboBoxHelper : DependencyObject
    {
        public static readonly DependencyProperty EnableVirtualizationWithGroupingProperty = DependencyProperty.RegisterAttached("EnableVirtualizationWithGrouping", typeof(bool), typeof(ComboBox), new FrameworkPropertyMetadata(false));

        public static void SetEnableVirtualizationWithGrouping(DependencyObject obj, bool value)
        {
            if (obj is ComboBox)
            {
#if NET4_5
                ComboBox comboBox = obj as ComboBox;

                comboBox.SetValue(EnableVirtualizationWithGroupingProperty, value);
                comboBox.SetValue(VirtualizingPanel.IsVirtualizingProperty, value);
                comboBox.SetValue(VirtualizingPanel.IsVirtualizingWhenGroupingProperty, value);
#else
                obj.SetValue(EnableVirtualizationWithGroupingProperty, false);
#endif
            }
        }

        public static bool GetEnableVirtualizationWithGrouping(DependencyObject obj)
        {
            return (bool)obj.GetValue(EnableVirtualizationWithGroupingProperty);
        }
    }
}
