using Microsoft.EntityFrameworkCore;
using Steam_Project.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.DAL.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        public DbSet<TEntity> Table { get; }
        public TEntity GetById(int id);
        public IQueryable<TEntity> GetAll();
    }
}
