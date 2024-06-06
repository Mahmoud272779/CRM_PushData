using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data;

namespace App.Infrastructure.Interfaces.Context
{
    public interface IApplicationSqlDbContextMaster
    {
        IDbConnection Connection { get; }
        DatabaseFacade Database { get; }
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
