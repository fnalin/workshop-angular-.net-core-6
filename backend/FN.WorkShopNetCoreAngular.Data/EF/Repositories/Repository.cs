using FN.WorkShopNetCoreAngular.Domain.Contracts.Repositories;
using FN.WorkShopNetCoreAngular.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FN.WorkShopNetCoreAngular.Data.EF.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
{
    private readonly DbSet<TEntity> _db;

    public Repository(WorkShopNetCoreAngularDbContext ctx)
    {
        _db = ctx.Set<TEntity>();
    }
    
    public Entity? Get(object key)
    {
        return _db.Find(key);
    }

    public IEnumerable<Entity> Get()
    {
        return _db.AsNoTracking().ToList();
    }

    public async Task<Entity?> GetAsync(object key)
    {
        return await _db.FindAsync(key);
    }

    public async Task<IEnumerable<Entity>> GetAsync()
    {
        return await _db.AsNoTracking().ToListAsync();
    }

    
    public void Add(TEntity entity)
    {
        _db.Add(entity);
    }

    public void Edit(TEntity entity)
    {
        _db.Update(entity);
    }

    public void Delete(TEntity entity)
    {
        _db.Remove(entity);
    }
}