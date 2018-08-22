using System;

namespace TimeEnhancer
{
    public interface ICallback
    {
        int Id { get; }

        bool Server { get; }

        void Run(IntPtr param);
    }
}
