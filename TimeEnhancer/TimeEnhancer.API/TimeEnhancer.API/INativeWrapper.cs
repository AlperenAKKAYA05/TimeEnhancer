using System;

namespace TimeEnhancer
{
    public interface INativeWrapper
    {
        void SetupFunctions(IntPtr objectAddress);
    }
}
