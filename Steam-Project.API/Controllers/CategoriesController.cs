using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Steam_Project.Business.Services.Interfaces;

namespace Steam_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        public ICategoryService categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(categoryService.GetById(id));
            }

            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
