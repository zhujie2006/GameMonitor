using System;
using System.Runtime.InteropServices;

namespace GamePlayMonitor.Utils
{
    public class DynamicPinvoke
    {
        [DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
        public static extern IntPtr LoadLibrary(string libFileName);

        [DllImport("kernel32.dll", EntryPoint = "FreeLibrary")]
        public static extern int FreeLibrary(IntPtr ptrLib);
    }
}
