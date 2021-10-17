using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieAPI.Data;
using MovieAPI.Models;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private ApiDbContext _context;

        public MovieController(ApiDbContext context)
        {
            _context = context;
        }

       [HttpGet]
        public async Task<IActionResult> GetItem()
        {
            var items = await _context.movie.ToListAsync();
            return Ok(items);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(MovieData data)
        {
            if (ModelState.IsValid)
            {
                await _context.movie.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new { data.id }, data);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _context.movie.FirstOrDefaultAsync(x => x.id == id);

            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, MovieData item)
        {
            if (id != item.id)
                return BadRequest();

            var existItem = await _context.movie.FirstOrDefaultAsync(x => x.id == id);

            if (existItem == null)
                return NotFound();

            existItem.nama = item.nama;
            existItem.genre = item.genre;
            existItem.duration = item.duration;
            existItem.releaseDate = item.releaseDate;

            //Implement the changes on the database leveel
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existItem = await _context.movie.FirstOrDefaultAsync(x => x.id == id);

            if (existItem == null)
                return NotFound();

            _context.movie.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok(existItem);
        }
    }
}