using Microsoft.EntityFrameworkCore;
using Steam_Project.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.DAL.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        public DbSet<TEntity> Table { get; }
        public Task<TEntity> GetById(int id);
        public IQueryable<TEntity> GetAll();
        public Task<TEntity> Create(TEntity entity);
        public void Delete(TEntity entity);

    }
}
