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
    public class ShoeController : ApiController
    {
        RunContext _context = new RunContext();

        IEnumerable<Shoe> _shoes;

        ShoeController()
        { 
            _shoes = new List<Shoe>()
                {
                    new Shoe(){
                        ShoeId=1,
                        Name="Test"
                    }
                };  
        }


        // GET api/shoe
        public IEnumerable<Shoe> Get()
        {
            IEnumerable<Shoe> shoes = _context.Shoes.ToList();
            if (shoes.Count() > 0)
                return shoes;
            else
                return _shoes;
        }

        // GET api/shoe/5
        public Shoe Get(int id)
        {
            return _shoes.FirstOrDefault(s => s.ShoeId == id);
        }

        // POST api/shoe
        public void Post([FromBody]Shoe value)
        {
            _context.Shoes.Add(value);
            _context.SaveChanges();
        }

        // PUT api/shoe/5
        public void Put(int id, [FromBody]Shoe value)
        {
        }

        // DELETE api/shoe/5
        public void Delete(int id)
        {

        }
    }
}
