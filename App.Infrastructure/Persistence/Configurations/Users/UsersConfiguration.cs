using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.Persistence.Configurations.Process
{
    public class UsersConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("Rules");
            builder.HasKey(e => e.Id);
            builder.HasOne(x => x.permissionList).WithMany(x => x.users).HasForeignKey(x => x.permissionListId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.employees).WithMany(x => x.users).HasForeignKey(x => x.employeesId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
