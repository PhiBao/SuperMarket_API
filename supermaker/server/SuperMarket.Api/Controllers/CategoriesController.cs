using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Supermarket.Core.Models;
using SuperMarket.Services;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }

        // GET api/Categories/id
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return Ok(await _categoryService.GetCategories());
        }

        // GET api/Categories/id
        [HttpGet("{id}", Name = "GetCategoryById")]
        public async Task<ActionResult<Category>> GetCategoryById(int id)
        {
            var category = await _categoryService.GetCategoryById(id);

            if (category != null)
            {
                return Ok(category);
            }

            return NotFound();
        }

        // POST api/Categories
        [HttpPost]
        public async Task<ActionResult<Category>> AddCategory(Category Category)
        {
            var category = await _categoryService.AddCategory(Category);

            return CreatedAtRoute(nameof(GetCategoryById), new { id = category.Id }, category);
        }

        [HttpPut("{categoryId}")]
        public async Task<ActionResult> Put(int categoryId, CategoryUpdateDto categoryUpdateDto)
        {
            var category = await _categoryService.GetCategoryById(categoryId);

            if (category == null)
            {
                return NotFound();
            }

            _mapper.Map(categoryUpdateDto, category);

            await _categoryService.UpdateCategory(category);

            return NoContent();
        }

        [HttpDelete("{categoryId}")]
        public async Task<ActionResult> Delete(int categoryId)
        {
            await _categoryService.DeleteCategory(categoryId);

            return NoContent();
        }

    }
}