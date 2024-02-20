using dataservice.Data;
using dataservice.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace dataservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiKey]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetProduct")]
        public IEnumerable<Product> Get()
        {
            return Product.Products()
            .ToArray();
        }

        //[HttpGet(Name = "ProductbyId/{id}")]
        //public Product ProductbyId(int Id)
        //{
        //    return Product.Products().Where(v => v.ProductId == Id).FirstOrDefault();

        //}
    }
}
