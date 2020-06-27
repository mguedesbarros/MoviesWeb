using Microsoft.EntityFrameworkCore;
using MoviesWeb.Domain.Entities;
using MoviesWeb.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Infrastructure.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly MovieContext Context;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(MovieContext context) : base()
        {
            this.Context = context;
            this.DbSet = Context.Set<TEntity>();
        }

        public Guid Add(TEntity entity)
        {
            DbSet.Add(entity);

            return entity.Id;
        }

        public async Task<IList<TEntity>> GetAll()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }

        public Task<TEntity> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
