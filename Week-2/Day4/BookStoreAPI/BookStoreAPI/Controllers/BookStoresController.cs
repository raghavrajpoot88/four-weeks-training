using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStoreAPI.Model;

namespace BookStoreAPI.Controllers
{
    [Route("api/BookStores")]
    [ApiController]
    public class BookStoresController : ControllerBase
    {
        private readonly BookStoreContext _context;

        public BookStoresController(BookStoreContext context)
        {
            _context = context;
        }

        // GET: api/BookStores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookStore>>> GetbookStores()
        {
          if (_context.bookStores == null)
          {
              return NotFound();
          }
            return await _context.bookStores.ToListAsync();
        }

        // GET: api/BookStores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookStore>> GetBookStore(int id)
        {
          if (_context.bookStores == null)
          {
              return NotFound();
          }
            var bookStore = await _context.bookStores.FindAsync(id);

            if (bookStore == null)
            {
                return NotFound();
            }

            return bookStore;
        }

        // PUT: api/BookStores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookStore(int id, BookStore bookStore)
        {
            if (id != bookStore.ID)
            {
                return BadRequest();
            }

            _context.Entry(bookStore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookStoreExists(id))
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

        // POST: api/BookStores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookStore>> PostBookStore(BookStore bookStore)
        {
          if (_context.bookStores == null)
          {
              return Problem("Entity set 'BookStoreContext.bookStores'  is null.");
          }
            _context.bookStores.Add(bookStore);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookStore", new { id = bookStore.ID }, bookStore);
        }

        // DELETE: api/BookStores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookStore(int id)
        {
            if (_context.bookStores == null)
            {
                return NotFound();
            }
            var bookStore = await _context.bookStores.FindAsync(id);
            if (bookStore == null)
            {
                return NotFound();
            }

            _context.bookStores.Remove(bookStore);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookStoreExists(int id)
        {
            return (_context.bookStores?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
