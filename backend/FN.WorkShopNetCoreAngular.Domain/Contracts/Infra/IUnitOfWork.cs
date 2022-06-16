namespace FN.WorkShopNetCoreAngular.Domain.Contracts.Infra;

public interface IUnitOfWork
{
    void Commit();
    void RollBack();
    
    Task CommitAsync();
    Task RollBackAsync();
}