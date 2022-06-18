using FN.WorkShopNetCoreAngular.Domain.Contracts.Infra;

namespace FN.WorkShopNetCoreAngular.Data.EF;

public class UnitOfWork : IUnitOfWork
{
    private readonly WorkShopNetCoreAngularDbContext _ctx;

    public UnitOfWork(WorkShopNetCoreAngularDbContext ctx)
    {
        _ctx = ctx;
    }
    public void Commit()
    {
        _ctx.SaveChanges();
    }

    public void RollBack()
    {
        throw new NotImplementedException();
    }

    public async Task CommitAsync()
    {
        await _ctx.SaveChangesAsync();
    }

    public Task RollBackAsync()
    {
        throw new NotImplementedException();
    }
}