using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Move.Data;
using Move.Models;

namespace Move.Controllers
{
    [ApiController]
    [Route("api/movie")]
    public class MovieController : ControllerBase
    {
        private readonly DataContext _context;
        
        public MovieController(DataContext context) => _context = context;
        
        
        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            try
            {
                _context.Movie.Add(movie);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            
            return Created("", movie);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_context.Movie.ToList());
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
    }
}