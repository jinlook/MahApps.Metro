using System.Windows.Interactivity;
using MVVMApps.Metro.Controls;

namespace MVVMApps.Metro.Behaviours
{
    public class WindowsSettingBehaviour : Behavior<MetroWindow>
    {
        protected override void OnAttached()
        {
            WindowSettings.SetSave(AssociatedObject, AssociatedObject.SaveWindowPosition);
        }
    }
}