using System;
using System.Collections.Generic;
using System.Text;
using VideoConsoleDAL.Repositories;
using VideoConsoleDAL.UOW;

namespace VideoConsoleDAL
{
    public class DALFacade
    {
        public iVideoRepository VideoRepository
        {
            // get { return new VideoRepositoryFakeDB(); }
            get
            {
                return new VideoRepositoryEFMemory(
                    new Context.InMemoryContext());
            }
        }
        public IIUnitOfWork UnitOfWork
        {

            get
            {
                return new UnitOfWorkMem();
                    
            }
        }
    }
}
