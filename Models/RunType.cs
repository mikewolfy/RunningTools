using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunningTools.Models
{
    public class RunType
    {
        public int RunTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Run> Runs { get; set; }
    }
}