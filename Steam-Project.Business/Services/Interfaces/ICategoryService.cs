using Steam_Project.Business.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.Business.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<GetCategoryDto> Create(CreateCategoryDto categoryDto);
        Task<GetCategoryDto> GetById(int id);
        List<GetAllCategoriesDTo> GetAll();
    }
}
