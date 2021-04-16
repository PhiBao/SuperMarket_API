using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Supermarket.Core.Models;
using SuperMarket.Services;

namespace SuperMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _mapper = mapper;
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            return Ok(await _productService.GetProducts());
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<Product>> GetById(int productId)
        {
            var product = await _productService.GetProductById(productId);

            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Model is invalid!");
            }
            return Ok(await _productService.AddProduct(product));
        }

        [HttpPut("{productId}")]
        public async Task<ActionResult> Put(int productId, [FromBody] ProductUpdateDto productUpdateDto)
        {
            var product = await _productService.GetProductById(productId);

            if (product == null)
            {
                return NotFound();
            }

            _mapper.Map(productUpdateDto, product);

            await _productService.UpdateProduct(product);

            return NoContent();
        }

        [HttpDelete("{productId}")]
        public async Task<ActionResult> DeleteProduct(int productId)
        {
            await _productService.DeleteProduct(productId);

            return NoContent();
        }

    }

}