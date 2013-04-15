﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Interactivity;
using MVVMApps.Metro.Controls;

namespace MVVMApps.Metro.Behaviours
{
    public class GlowWindowBehavior : Behavior<Window>
    {
        private GlowWindow left, right, top, bottom;
        protected override void OnAttached()
        {
            base.OnAttached();

            this.AssociatedObject.Loaded += (sender, e) =>
            {
                left = new GlowWindow(this.AssociatedObject, GlowDirection.Left);
                right = new GlowWindow(this.AssociatedObject, GlowDirection.Right);
                top = new GlowWindow(this.AssociatedObject, GlowDirection.Top);
                bottom = new GlowWindow(this.AssociatedObject, GlowDirection.Bottom);

                Show();

                left.Update();
                right.Update();
                top.Update();
                bottom.Update();
            };

            this.AssociatedObject.Closed += (sender, args) =>
            {
                left.Close();
                right.Close();
                top.Close();
                bottom.Close();
            };
        }

        public void Hide()
        {
            left.Hide();
            right.Hide();
            bottom.Hide();
            top.Hide();
        }

        public void Show()
        {
            left.Show();
            right.Show();
            top.Show();
            bottom.Show();
        }
    }
}
