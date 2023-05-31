using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderManagementApi.Model;
using rderManagementApi.Model;

namespace OrderManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderInfoesController : ControllerBase
    {
        private readonly DbOrderManagementContext _context;

        public OrderInfoesController(DbOrderManagementContext context)
        {
            _context = context;
        }

        // GET: api/OrderInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderInfo>>> GetOrderInfos()
        {
          if (_context.OrderInfos == null)
          {
              return NotFound();
          }
            return await _context.OrderInfos.ToListAsync();
        }

        // GET: api/OrderInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderInfo>> GetOrderInfo(int id)
        {
          if (_context.OrderInfos == null)
          {
              return NotFound();
          }
            var orderInfo = await _context.OrderInfos.FindAsync(id);

            if (orderInfo == null)
            {
                return NotFound();
            }

            return orderInfo;
        }

        // PUT: api/OrderInfoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderInfo(int id, OrderInfo orderInfo)
        {
            if (id != orderInfo.Id)
            {
                return BadRequest();
            }

            _context.Entry(orderInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrderInfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderInfo>> PostOrderInfo(OrderInfo orderInfo)
        {
          if (_context.OrderInfos == null)
          {
              return Problem("Entity set 'DbOrderManagementContext.OrderInfos'  is null.");
          }
            _context.OrderInfos.Add(orderInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderInfo", new { id = orderInfo.Id }, orderInfo);
        }

        // DELETE: api/OrderInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderInfo(int id)
        {
            if (_context.OrderInfos == null)
            {
                return NotFound();
            }
            var orderInfo = await _context.OrderInfos.FindAsync(id);
            if (orderInfo == null)
            {
                return NotFound();
            }

            _context.OrderInfos.Remove(orderInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderInfoExists(int id)
        {
            return (_context.OrderInfos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
