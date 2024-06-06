using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.Persistence.Configurations.Process
{
    public class RulesConfiguration : IEntityTypeConfiguration<Rules>
    {
        public void Configure(EntityTypeBuilder<Rules> builder)
        {
            builder.ToTable("Rules");
            builder.HasKey(e => e.Id);
            builder.HasOne(x => x.permissionList).WithMany(x => x.rules).HasForeignKey(x => x.permissionListId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
