using FN.WorkShopNetCoreAngular.Domain.Entities;

namespace FN.WorkShopNetCoreAngular.Domain.Contracts.Repositories;

public interface IRepository<TEntity> where TEntity : Entity
{
    Entity Get(object key);
    IEnumerable<Entity> Get();
    
    Task<Entity> GetAsync(object key);
    Task<IEnumerable<Entity>> GetAsync();

    void Add(TEntity entity);
    void Edit(TEntity entity);
    void Delete(TEntity entity);
}