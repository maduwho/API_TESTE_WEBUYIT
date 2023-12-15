﻿using API_WEBUYIT.Contracts.Entity;
using API_WEBUYIT.DTO;
using Microsoft.AspNetCore.Mvc;
using API_WEBUYIT.Entity;

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
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _productRepository.Get());
        }
        [HttpPut]
        public async Task<IActionResult> Update(ProductEntity product)
        {
            await _productRepository.Update(product);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _productRepository.Delete(id);
            return Ok();
        }

        [HttpGet("byidproduct/{id}", Name = "GetByIdProduct")]
        public async Task<IActionResult> GetByIdProduct(int id)
        {
            return Ok(await _productRepository.GetById(id));
        }

        [HttpGet("bynameproduct/{name}", Name = "GetByNameProduct")]
        public async Task<IActionResult> GetByNameProduct(string name)
        {
            return Ok(await _productRepository.GetByName(name));
        }
    }
}
