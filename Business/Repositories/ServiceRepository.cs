using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities.Absctract;
using DataAccess.Repositories;

namespace Business.Repositories
{
    public class ServiceRepository<TEntity> : IServiceRepository<TEntity>
        where TEntity:class,IBaseEntity,new()
    {
        private readonly IRepository<TEntity> _repository;
        public ServiceRepository(IRepository<TEntity> repository )
        {
            _repository = repository;
        }

        //[CacheAspect]
        public virtual async Task<TEntity> Get(int id)
        {
            var entity = await _repository.Get(id);
            return entity;
        }
        public virtual async Task <List<TEntity>> GetAll()
        {
            var entity = await _repository.GetAll();
            return entity;
        }

        //[RemoveCacheAspect]
        //[SecuredOperation("Admin,Department")]
        public virtual async Task<int> Insert(TEntity entity)
        {
            await _repository.Insert(entity);
            return entity.Id;
        }

        //[RemoveCacheAspect]
        public virtual async Task Update(int id, TEntity entity)
        {
            entity.UpdatedAt = DateTime.Now;
            await _repository.Update(entity);
        }

        //[RemoveCacheAspect]
        public virtual async Task Delete(int id)
        {
            var entity = await _repository.Get(id);
            await _repository.Delete(entity);
        }
    }
}