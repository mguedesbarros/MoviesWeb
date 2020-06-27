using MoviesWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        ResultEntity<TEntity> Add(TEntity entity);
        ResultEntity<TEntity> Remove(Guid id);
        ResultEntity<TEntity> Update(TEntity entity);
        Task<TEntity> GetById(Guid id);
        Task<IList<TEntity>> GetAll();
    }
}
