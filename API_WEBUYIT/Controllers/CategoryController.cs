using API_WEBUYIT.Contracts.Entity;
using API_WEBUYIT.DTO;
using Microsoft.AspNetCore.Mvc;
using API_WEBUYIT.Entity;

namespace API_WEBUYIT.Controllers
{
    [ApiController]
    [Route("category")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _categoryRepository.Get());
        }
       
    }
}
