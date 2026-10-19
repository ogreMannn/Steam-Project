using AutoMapper;
using Steam_Project.Business.DTOs.Category;
using Steam_Project.Business.Exceptions.Common;
using Steam_Project.Business.Services.Interfaces;
using Steam_Project.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.Business.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        readonly ICategoryRepository _rep;
        readonly IMapper _mapper;

        public CategoryService(ICategoryRepository rep, IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        public GetCategoryDto GetById(int id)
        {
            if (id <= 0)
            {
                throw new NegativeIdException();
            }

            GetCategoryDto dto = _mapper.Map<GetCategoryDto>(_rep.GetById(id));
            return dto;
        }

    }
}
