
﻿using MovieLibraryProject.Models;
﻿using System;
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

        // GET: api/Movies

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
        
     
        // GET: api/Movies/5

        public string Get(int id)
        {

            return "value";
        }


        
        // POST: api/Movies
        public void Post([FromBody]string value)
        {
        }


        // PUT: api/Movie/5

       

        public void Put(int id, [FromBody]string value)
        {
        }

       

        // DELETE: api/Movies/5
        public void Delete(int id)
        {
        }
    }
}
