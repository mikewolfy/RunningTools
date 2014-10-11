using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunningTools.Models
{
    public class Shoe
    {
        public int ShoeId { get; set; }
        public string Name { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Run> Runs { get; set; }

    }
}