
using App.Domain.Entities;

namespace App.Infrastructure.Persistence.Seed
{
    public class ErpInitilizerData : IErpInitilizerData
    {
        public PermissionList[] setDefultPermissionList()
        {
            var list = new List<PermissionList>();
            list.AddRange(new[]
            {
                new PermissionList
                {
                    Id = -1,
                    arabicName = "مدير النظام",
                    latinName = "System Administrator",

                }
            });
            return list.ToArray();
        }

        public Users[] setDefultUsers()
        {
            var users = new List<Users>();
            users.AddRange(new[]
            {
                new Users
                {
                    Id = -1,
                    arabicName = "مدير النظام",
                    latinName = "administrator",
                    username = "admin",
                    password = "admin",
                    employeesId = -1,
                    permissionListId = -1,
                    isActive =  true,
                }
            });
            return users.ToArray();
        }

        public Employees[] setEmployees()
        {
            var employeeLists = new List<Employees>();
            employeeLists.AddRange(new[]
            {
                new Employees
                {
                    Id = -1,
                    arabicName = "مدير النظام",
                    latinName = "Administrator"
                }
            });
            return employeeLists.ToArray();
        }
    }
}
