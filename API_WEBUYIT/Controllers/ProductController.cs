using API_WEBUYIT.Contracts.Entity;
using API_WEBUYIT.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API_WEBUYIT.Controllers
{
    [ApiController]
    [Route("product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductDTO product)
        {
            await _productRepository.Add(product);
            return Ok();
        }
    }
}
