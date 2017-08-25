using System;
using System.Collections.Generic;
using System.Text;
using VideoConsoleProgram;

namespace VideoConsoleDAL
{
    public interface iVideoRepository
    {
        Video Create(Video vid);

        List<Video> GetAll();
        Video Get(int Id);

        Video Delete(int Id);
    }
}
