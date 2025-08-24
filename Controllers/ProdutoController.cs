using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreCatalogAPI.Data;

namespace StoreCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

      
    }
}
