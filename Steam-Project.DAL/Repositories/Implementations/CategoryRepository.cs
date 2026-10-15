using Microsoft.EntityFrameworkCore;
using Steam_Project.Core.Entities;
using Steam_Project.DAL.Context;
using Steam_Project.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.DAL.Repositories.Implementations
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(SteamDbContext dbContext) : base(dbContext) { }
        
    }
}
