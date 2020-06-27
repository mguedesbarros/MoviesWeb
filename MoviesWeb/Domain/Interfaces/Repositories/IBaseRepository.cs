using MoviesWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Guid Add(TEntity entity);
        void Remove(Guid id);
        void Update(TEntity entity);
        Task<TEntity> GetById(Guid id);
        Task<IList<TEntity>> GetAll();
    }
}
