using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using RunningTools.Models;

namespace RunningTools.Data
{
    public class RunContext: DbContext
    {
        public RunContext(): base("SchoolContext")
        {
        
        }

        public DbSet<Run> Runs { get; set; }
        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<RunType> RunTypes { get; set; }
    }
}