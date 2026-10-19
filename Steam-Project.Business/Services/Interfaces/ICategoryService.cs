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

        GetCategoryDto GetById(int id);
    }
}
