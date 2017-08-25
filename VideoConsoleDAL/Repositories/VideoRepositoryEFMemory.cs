using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoConsoleDAL.Context;
using VideoConsoleProgram;

namespace VideoConsoleDAL.Repositories
{
    class VideoRepositoryEFMemory : iVideoRepository
    {
        InMemoryContext context;

        public VideoRepositoryEFMemory(InMemoryContext context)
        {
            this.context = context;
        }

        public Video Create(Video vid)
        {
            
            this.context.Videos.Add(vid);
            return vid;
        }

        public Video Delete(int Id)
        {
            var vid = Get(Id);
            this.context.Videos.Remove(vid);
            return vid;
        }

        public Video Get(int Id)
        {
            return this.context.Videos.FirstOrDefault(x => x.Id == Id);
        }

        public List<Video> GetAll()
        {
            return this.context.Videos.ToList();
        }
    }
}
