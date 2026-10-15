using Microsoft.EntityFrameworkCore;
using Steam_Project.Core.Entities.Common;
using Steam_Project.DAL.Context;
using Steam_Project.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IQueryable<TEntity> GetAll()
        {
            return Table;
        }

        public TEntity GetById(int id)
        {
            return Table.FirstOrDefault(x => x.Id == id);
        }
    }
}
