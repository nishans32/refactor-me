using Carsales_test.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carsales_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("{id}")]
        public Product GetProducts(Guid id)
        {
            var product = new Product(id);
            if (product.IsNew)
                throw new Exception();

            return product;
        }
    }
}
