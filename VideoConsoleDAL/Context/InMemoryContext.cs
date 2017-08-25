using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VideoConsoleProgram;

namespace VideoConsoleDAL.Context
{
    class InMemoryContext : DbContext 
    {
        static DbContextOptions<InMemoryContext> options =
             new DbContextOptionsBuilder<InMemoryContext>()
             .UseInMemoryDatabase("TheDB")
             .Options;

        public InMemoryContext() : base(options) //declare a superclass with base
        {

        }

        public DbSet<Video> Videos { get; set; }
    }
}
