using System;
using System.Runtime.InteropServices;

namespace TimeEnhancer
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct NativeClass
    {
        public IntPtr VirtualTable;
    }
}
