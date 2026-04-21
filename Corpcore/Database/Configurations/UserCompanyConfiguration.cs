using Corpcore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Corpcore.Database.Configurations
{
    public class UserCompanyConfiguration: IEntityTypeConfiguration<UserCompany>
    {
        public void Configure(EntityTypeBuilder<UserCompany> builder)
        {
            builder.HasKey(x => new { x.UserId, x.CompanyId });

            builder.Property(x => x.Role)
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.UserCompanies)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Company)
                .WithMany(x => x.CompanyUsers)
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
