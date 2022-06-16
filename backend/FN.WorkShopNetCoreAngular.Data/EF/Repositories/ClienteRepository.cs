using FN.WorkShopNetCoreAngular.Domain.Contracts.Repositories;
using FN.WorkShopNetCoreAngular.Domain.Entities;

namespace FN.WorkShopNetCoreAngular.Data.EF.Repositories;

public class ClienteRepository : Repository<Cliente>, IClienteRepository
{
    public ClienteRepository(WorkShopNetCoreAngularDbContext ctx) : base(ctx)
    {}
}