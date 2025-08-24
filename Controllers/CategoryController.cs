using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreCatalogAPI.Data;
using StoreCatalogAPI.Models;

namespace StoreCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetAll()
        {
            var categories = await _context.Categorias.ToListAsync();
            if(categories is null)
                return NotFound("No categoriees Found.");

            return Ok(categories);
        }

        [HttpGet("{id:int}", Name = "GetCategory")]
        public async Task<ActionResult<Category>> GetBydId(int id)
        {
            var category = await _context.Categorias.FirstOrDefaultAsync(c => c.Id == id);
            if (category is null)
                return NotFound($"Category with ID {id} not found.");

            return Ok(category);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Category category)
        {
            if(category is null) 
                return BadRequest("Category data is null.");

          await _context.Categorias.AddAsync(category);
          await _context.SaveChangesAsync();

            return new CreatedAtRouteResult("GetCategory", new { id = category.Id }, category);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, Category category)
        {
            var categoryDb = await _context.Categorias.FirstOrDefaultAsync(c => c.Id == id);
            if (categoryDb is null)
                return NotFound($"Category with ID {id} not found.");

            categoryDb.Name = category.Name;

            _context.Categorias.Update(categoryDb);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var categoryDb = await _context.Categorias.FirstOrDefaultAsync(c => c.Id == id);
            if(categoryDb is null)
                return NotFound($"Category with ID {id} not found.");

            _context.Categorias.Remove(categoryDb);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
