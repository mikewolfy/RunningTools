using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunningTools.Models
{
    public class Run
    {
        public int RunId { get; set; }
        public int Distance { get; set; }
        public DateTime Date { get; set; }
        public int Intensity { get; set; }
        public int ShoeId { get; set; }
        public int RunTypeId { get; set; }
    
        public virtual Shoe Shoe { get; set; }
        public virtual RunType RunType { get; set; }
     }
}