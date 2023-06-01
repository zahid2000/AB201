using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using WebAPIAB201.DAL.EFCore;
using WebAPIAB201.Entities;
using WebAPIAB201.Entities.Dtos.Books;

namespace WebAPIAB201.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {

        private readonly AppDbContext _context;

        public BooksController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet("GetBooks")]
        public async Task<IActionResult> GetBooks()
        {
            var result = await _context.Books.ToListAsync();
            if (result.Count==0) return NotFound();
            return StatusCode((int)HttpStatusCode.OK,result);
        }
        [HttpGet("GetBook/{id}")]
        public async Task<IActionResult> GetBook([FromRoute]int id)
        {
            var result = await _context.Books.Where(b=>b.Id==id).FirstOrDefaultAsync();
            if (result is null) return NotFound();
            return StatusCode((int)HttpStatusCode.OK, result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBookDto bookdto)
        {

            Book book = new Book
            {
                Title = bookdto.Title,
                Description = bookdto.Description,
                Author = bookdto.Author,
                Created = DateTime.UtcNow

            };
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute]int id,UpdateBookDto bookdto)
        {
            var result = await _context.Books.FindAsync(id);
            if (result is null) return NotFound();
            result.Title= bookdto.Title;
            result.Description= bookdto.Description;
            result.Author= bookdto.Author;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _context.Books.FindAsync(id);
            if (result is null) return BadRequest(new
            {
                StatusCode=201,
                Message="Tapilmadi"
            });
            _context.Books.Remove(result);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
