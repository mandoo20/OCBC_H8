using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using MovieAPI.Models;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private MovieContext _context;

        public MovieController(MovieContext context)
        {
            this._context = context;
        }

        //GET: api/User

        [HttpGet]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            //return new string[1]
            return _context.GetAllMovie();
        }

        //GET: api/user/{id}
        [HttpGet("{id}",Name = "Get")]
        public  ActionResult<IEnumerable<MovieItem>> GetEmployeeItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.GetMovie(id);
        }
    }
}