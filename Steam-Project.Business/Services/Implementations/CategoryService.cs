using Steam_Project.Business.DTOs.Category;
using Steam_Project.Business.Exceptions.Common;
using Steam_Project.Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.Business.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        public GetCategoryDto GetById(int id)
        {
            if (id <= 0)
            {
                throw new NegativeIdException();
            }
        }

    }
}
