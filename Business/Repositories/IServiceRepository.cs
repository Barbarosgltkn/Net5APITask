using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities.Absctract;


namespace Business.Repositories
{
    public interface IServiceRepository<TEntity>
    where TEntity : class, IBaseEntity, new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> Get(int id);


        Task <List<TEntity>> GetAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<int> Insert(TEntity entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        /// 
        Task Update(int id, TEntity entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Delete(int id);

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="listOfId"></param>
        ///// <returns></returns>
        //Task DeleteRangeAsync(List<int> listOfId);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //Task RemoveCacheAsync();
    }
}