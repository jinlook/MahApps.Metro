using System.Runtime.InteropServices;

namespace MVVMApps.Metro.Native
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class MONITORINFO
    {     
        public int cbSize = Marshal.SizeOf(typeof(MONITORINFO));
        public RECT rcMonitor = new RECT(); 
        public RECT rcWork = new RECT();           
        public int dwFlags = 0;
    }
}