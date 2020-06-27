using MoviesWeb.Application.Models;
using MoviesWeb.Domain.Entities;
using MoviesWeb.Domain.Interfaces.Repositories;
using MoviesWeb.Domain.Interfaces.Services;
using MoviesWeb.Infrastructure.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Domain.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity>
        where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            this._repository = repository;
        }

        public ResultEntity<TEntity> Add(TEntity entity)
        {
            _repository.Add(entity);

            return ResultEntity<TEntity>.Success(entity);
        }

        public Task<IList<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public ResultEntity<TEntity> Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public ResultEntity<TEntity> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
