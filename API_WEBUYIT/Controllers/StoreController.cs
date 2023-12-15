using API_WEBUYIT.Contracts.Entity;
using API_WEBUYIT.DTO;
using Microsoft.AspNetCore.Mvc;
using API_WEBUYIT.Entity;

namespace API_WEBUYIT.Controllers
{
    [ApiController]
    [Route("store")]
    public class StoreController : ControllerBase
    {
        private readonly IStoreRepository _storeRepository;

        public StoreController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _storeRepository.Get());
        }

    }
}
