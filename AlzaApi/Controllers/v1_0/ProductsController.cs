using AlzaApi.Models.v1_0;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using AlzaApi.Data;

namespace AlzaApi.Controllers.v1_0
{
    /// <summary>
    /// v1/Products API
    /// </summary>
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AlzaContext _context;

        /// <summary>
        /// Inject dbContext through constructor
        /// </summary>
        /// <param name="context">dbContext</param>
        public ProductsController(AlzaContext context)
        {
            _context = context;
        }


        // GET: v1/Products
        /// <summary>
        /// Get all products 
        /// </summary>
        /// <returns>List of products</returns>
        [HttpGet]
        [MapToApiVersion("1.0")]

        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }


        // GET: v1/Products/5
        /// <summary>
        /// Get specific product by Id 
        /// </summary>
        /// <param name="id">Id of product</param>
        /// <returns>Product</returns>
        [HttpGet("{id}")]
        [MapToApiVersion("1.0")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }


        // PUT: v1/Products/5
        /// <summary>
        /// Update description of product
        /// </summary>
        /// <param name="id">Id of product</param>
        /// <param name="description">New description for product</param>
        /// <returns>Status code 200, if update is successful</returns>
        [HttpPut("{id}")]
        [MapToApiVersion("1.0")]
        public async Task<IActionResult> UpdateDescription(int id, [FromBody] string description)
        {
            var product = await _context.FindAsync<Product>(id);
            
            if (product == null)
            {
                return NotFound();
            }

            product.Description = description;
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
