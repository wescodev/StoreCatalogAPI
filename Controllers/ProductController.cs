using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreCatalogAPI.Data;
using StoreCatalogAPI.Models;

namespace StoreCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            var products =  await _context.Produtos.ToListAsync();
            if(products is null)
                return NotFound("No products found.");

            return Ok(products);
        }

        [HttpGet("{id:int}", Name = "GetProducts")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            var product = await _context.Produtos.FirstOrDefaultAsync(p => p.Id == id);
            if(product is null) 
                return NotFound($"Product with ID {id} not found.");

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Product product)
        {
            if(product is null)
                return BadRequest("Product data is null.");

            await _context.Produtos.AddAsync(product);
            await _context.SaveChangesAsync();

            return new CreatedAtRouteResult("GetProducts", new { id = product.Id}, product);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, Product product)
        {

            var productDb = await _context.Produtos.FirstOrDefaultAsync(p => p.Id == id);
            if (productDb is null)
                return NotFound($"Product with ID {id} not found.");

            productDb.Name = product.Name;
            productDb.Price = product.Price;
            productDb.CategoriaId = product.CategoriaId;

            _context.Produtos.Update(productDb);
            _context.SaveChanges();

            return NoContent();

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var productDb = await _context.Produtos.FirstOrDefaultAsync(p => p.Id == id);
            if(productDb is null)
                return NotFound("Product not found.");

            _context.Produtos.Remove(productDb);
            _context.SaveChanges();

            return NoContent();
        }

    }
}
