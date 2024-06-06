using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Persistence.Seed
{
    public class OnModelCreatingService
    {
        private readonly IErpInitilizerData _initilizerData;
        public OnModelCreatingService(IErpInitilizerData erpInitilizerData)
        {
            _initilizerData = erpInitilizerData;
        }
        public void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>().HasData(_initilizerData.setEmployees());
            modelBuilder.Entity<PermissionList>().HasData(_initilizerData.setDefultPermissionList());
            modelBuilder.Entity<Users>().HasData(_initilizerData.setDefultUsers());
        }
    }
}
