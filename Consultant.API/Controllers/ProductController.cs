using Microsoft.AspNetCore.Mvc;
using Consultant.Server.Model;

namespace Consultant.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly static ProductRepository _repository = new();

        [HttpGet("{id}")]
        public IActionResult GetProductById(Guid id)
        {
            var product = _repository.GetById(id);

            return Ok(product);
        }

        [HttpGet("all")]
        public IActionResult GetProducts()
        {
            var products = _repository.GetAll().Take(10);

            return Ok(products);
        }

        [HttpGet("find")]
        public IActionResult GetProducts(string keywords)
        {
            var products = _repository.GetByKeywords(keywords).Take(10);

            return Ok(products);
        }
    }
}
