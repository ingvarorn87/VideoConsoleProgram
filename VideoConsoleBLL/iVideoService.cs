using System;
using System.Collections.Generic;
using System.Text;
using VideoConsoleProgram;

namespace VideoConsoleBLL
{
    public interface iVideoService
    {
        Video Create(Video vid);

        List<Video> GetAll();
        Video Get(int Id);

        Video Update(Video vid);

        Video Delete(int Id);

    }
}
