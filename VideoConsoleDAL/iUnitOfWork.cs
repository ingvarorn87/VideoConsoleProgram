using System;
using System.Collections.Generic;
using System.Text;

namespace VideoConsoleDAL
{
    public interface IIUnitOfWork :IDisposable
    {
        iVideoRepository VideoRepository { get; }

        int Complete();
    }
}
