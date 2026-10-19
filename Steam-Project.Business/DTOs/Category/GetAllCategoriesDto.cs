using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.Business.DTOs.Category
{
    public record GetAllCategoriesDTo
    {
        public IQueryable<GetCategoryDto> Categories { get; set; }
    }
}
