//using AlzaApi.Data;
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
    [ApiVersion("2.0")]
    [Route("v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ProductsController
    {
        private readonly AlzaContext _context;

        public ProductsController(AlzaContext context)
        {
            _context = context;
        }


        // GET: api/Products
        [HttpGet]
        [MapToApiVersion("2.0")]
        public async Task<ActionResult<IEnumerable<Product>>> GetPagingProducts([FromQuery] Paging request)
        {
            var products = await _context.Products.ToListAsync();

            // for clients that may want to page through the entire products set
            //Response.Headers["x-total-products"] = products.Count().ToString();

            var pagedProducts = products
              .Skip(request.Offset)
              .Take(request.Limit).ToList();

            return pagedProducts;
        }
    }
}
