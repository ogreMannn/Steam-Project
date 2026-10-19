using AutoMapper;
using Steam_Project.Business.DTOs.Category;
using Steam_Project.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.Business.Helpers.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<GetCategoryDto, Category>().ReverseMap();
        }
    }
}
