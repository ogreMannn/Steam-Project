using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Steam_Project.Business.DTOs.Category;
using Steam_Project.Business.Exceptions.CategoryExceptions;
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

            catch (CategoryNullException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(categoryService.GetAll());
            }

            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }


        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDto dto)
        {
            try
            {
                return Ok(await categoryService.CreateAsync(dto));
            }
            catch(CategoryNameExistException ex)
            {

                return StatusCode(StatusCodes.Status409Conflict, ex.Message);
            }

            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}