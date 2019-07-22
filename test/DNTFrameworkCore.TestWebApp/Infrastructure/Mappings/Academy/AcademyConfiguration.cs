using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DNTFrameworkCore.TestWebApp.Infrastructure.Mappings.Academy
{
    public class AcademyConfiguration : IEntityTypeConfiguration<Domain.Academy.Academy>
    {
        public void Configure(EntityTypeBuilder<Domain.Academy.Academy> builder)
        {
            builder.Property(b => b.AcademyName).IsRequired().HasMaxLength(Domain.Academy.Academy.MaxTitleLength);
            builder.Property(b => b.Address).IsRequired();
            builder.Property(b => b.Description).IsRequired();
            builder.Property(b => b.Phone).IsRequired();
            builder.Property(b => b.UserId).IsRequired();
            builder.Property(b => b.NormalizedTitle).IsRequired().HasMaxLength(Domain.Academy.Academy.MaxTitleLength);
            builder.HasIndex(b => b.NormalizedTitle).HasName("Academy_NormalizedTitle").IsUnique();
        }
    }
}

