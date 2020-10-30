using AlzaApi.Models;
using AlzaApi.Models.v1_0;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlzaApi.Data;

namespace AlzaApi.Controllers.v2_0
{
    /// <summary>
    /// v2/Products API
    /// </summary>
    [ApiVersion("2.0")]
    [Route("v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ProductsController
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

        // GET: v2/Products
        /// <summary>
        /// Get paged products (default page size 10)
        /// </summary>
        /// <param name="request">Paging params (limit, offset)</param>
        /// <returns>List of products</returns>
        [HttpGet]
        [MapToApiVersion("2.0")]
        public async Task<ActionResult<IEnumerable<Product>>> GetPagedProducts([FromQuery] Paging request)
        {
            var products = await _context.Products
                .OrderBy(o => o.Id)
                // Cursor based pagination
                .Where(w=>w.Id > request.Offset)
                .Take(request.Limit).ToListAsync();

            return products;
        }
    }
}
