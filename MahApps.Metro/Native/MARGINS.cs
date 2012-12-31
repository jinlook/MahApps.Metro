using System.Runtime.InteropServices;

namespace MVVMApps.Metro.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MARGINS
    {
        public int leftWidth;
        public int rightWidth;
        public int topHeight;
        public int bottomHeight;
    }
}