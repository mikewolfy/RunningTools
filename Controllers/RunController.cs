using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RunningTools.Models;
using RunningTools.Data;

namespace RunningTools.Controllers
{
    public class RunController : ApiController
    {
        RunContext _context = new RunContext();

        IEnumerable<Run> _runs;

        RunController()
        { 
            _runs = new List<Run>()
                {
                    new Run(){
                         Date = DateTime.Parse("2014-10-10"),
                         Intensity = 8,
                         Distance = 20
                    },
                    new Run(){
                         Date = DateTime.Parse("2014-10-12"),
                         Intensity = 6,
                         Distance = 8
                    }
                };  
        }


        // GET api/run
        public IEnumerable<Run> Get()
        {
            IEnumerable<Run> runs = _context.Runs.ToList();
            if (runs.Count() > 0)
                return runs;
            else
                return _runs;
        }

        // GET api/run/5
        public Run Get(int id)
        {
            return _runs.FirstOrDefault(s => s.RunId == id);
        }

        // POST api/run
        public void Post([FromBody]Run value)
        {
            _context.Runs.Add(value);
            _context.SaveChanges();
        }

        // PUT api/run/5
        public void Put(int id, [FromBody]Run value)
        {
        }

        // DELETE api/run/5
        public void Delete(int id)
        {

        }
    }
}
