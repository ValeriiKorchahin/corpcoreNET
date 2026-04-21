using Corpcore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Corpcore.Database.Configurations
{
    public class OrganizationConfiguration: IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(x => x.Name)
                .IsUnique();

            builder.HasMany(x => x.Users)
                .WithOne(x => x.Organization)
                .HasForeignKey(x => x.OrganizationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.Companies)
                .WithOne(x => x.Organization)
                .HasForeignKey(x => x.OrganizationId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
