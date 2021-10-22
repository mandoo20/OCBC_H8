using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaymentApi.Data;
using PaymentApi.Models;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class PaymentDetailController : ControllerBase
    {
        private AppDbContext _context;

        public PaymentDetailController(AppDbContext context)
        {
            _context = context;
        }

       [HttpGet]
        public async Task<IActionResult> GetItem()
        {
            var items = await _context.Payments.ToListAsync();
            return Ok(items);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(ItemData data)
        {
            if (ModelState.IsValid)
            {
                await _context.Payments.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new { data.PaymentDetailId }, data);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _context.Payments.FirstOrDefaultAsync(x => x.PaymentDetailId == id);

            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, ItemData item)
        {
            if (id != item.PaymentDetailId)
                return BadRequest();

            var existItem = await _context.Payments.FirstOrDefaultAsync(x => x.PaymentDetailId == id);

            if (existItem == null)
                return NotFound();

            existItem.CardOwnerName = item.CardOwnerName;
            existItem.CardNumber = item.CardNumber;
            existItem.ExpirationDate = item.ExpirationDate;
            existItem.SecurityCode = item.SecurityCode;

            //Implement the changes on the database leveel
            await _context.SaveChangesAsync();

            return Ok("Update Success!!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existItem = await _context.Payments.FirstOrDefaultAsync(x => x.PaymentDetailId == id);

            if (existItem == null)
                return NotFound();

            _context.Payments.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok("Delete Success!!");
        }
    }
}