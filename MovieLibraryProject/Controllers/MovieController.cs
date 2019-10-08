using MovieLibraryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieLibraryProject.Controllers
{
    public class MovieController : ApiController
    {
        ApplicationDbContext context;
       // public List<Movie> movies = new List<Movie>();

        public MovieController()
        {
            context = new ApplicationDbContext();
        }
       
        
            // GET: api/Movie
             IEnumerable<Movie> Get()
            {
            var movies = context.Movies.ToList();
                return movies;
            }
        
      
        

        // GET: api/Movie/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Movie
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Movie/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Movie/5
        public void Delete(int id)
        {
        }
    }
}
