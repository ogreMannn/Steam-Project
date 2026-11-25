using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Steam_Project.Core.Entities.Common;
using Steam_Project.DAL.Context;
using Steam_Project.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.DAL.Repositories.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        readonly SteamDbContext _context;

        public Repository(SteamDbContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public async Task<TEntity> Create(TEntity entity)
        {
            await Table.AddAsync(entity);
            return entity;
        }
        public void Delete(TEntity entity)
        {
            Table.Remove(entity);
        }


        public IQueryable<TEntity> GetAll()
        {
            return Table;
        }

        public async Task<TEntity> GetById(int id)
        {
            return await Table.FirstOrDefaultAsync(x => x.Id == id);
        }


         
    }
}
