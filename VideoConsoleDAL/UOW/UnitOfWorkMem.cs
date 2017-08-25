using System;
using System.Collections.Generic;
using System.Text;
using VideoConsoleDAL.Context;
using VideoConsoleDAL.Repositories;

namespace VideoConsoleDAL.UOW
{
    public class UnitOfWorkMem : IIUnitOfWork
    {

        public iVideoRepository VideoRepository { get; internal set; }
        private InMemoryContext context;


        public UnitOfWorkMem()
        {
            context = new InMemoryContext();
            VideoRepository = new VideoRepositoryEFMemory(context);
        }


        public int Complete()
        {
            return context.SaveChanges();
            
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
