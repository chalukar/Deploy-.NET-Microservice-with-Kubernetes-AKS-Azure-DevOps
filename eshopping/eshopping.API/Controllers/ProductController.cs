using eshopping.API.Models;
using eshopping.client.Data;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace eshopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly ProductContext _context;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger, ProductContext context)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _context
                .Products
                .Find(p => true)
                .ToListAsync();
        }
      
    }
}
