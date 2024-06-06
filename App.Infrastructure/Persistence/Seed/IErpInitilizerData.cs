
using App.Domain.Entities;

namespace App.Infrastructure.Persistence.Seed
{
    public interface IErpInitilizerData
    {
        Employees[] setEmployees();
        PermissionList[] setDefultPermissionList();
        Users[] setDefultUsers();
    }
}