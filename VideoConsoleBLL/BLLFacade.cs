using System;
using System.Collections.Generic;
using System.Text;
using VideoConsoleBLL.Services;
using VideoConsoleDAL;

namespace VideoConsoleBLL
{
    public class BLLFacade
    {
        public iVideoService VideoService
        {
            get { return new VideoService(new DALFacade()); }
        }
    }
}
