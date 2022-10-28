using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iFoodDbMap.EFCore.Entity.Map
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("client_address");

            builder.Property(a => a.Number)
                .HasColumnType("integer")
                .IsRequired();

            builder.Property(a => a.Street)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(a => a.City)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(a => a.State)
                .HasColumnType("varchar(30)")
                .IsRequired();

            builder.Property(a => a.Complement)
                .HasColumnType("varchar(30)");

            builder.Property(a => a.Alias)
                .HasColumnType("varchar(20)");

            builder.HasOne(a => a.Client)
                .WithMany(aa => aa.Address)
                .IsRequired();
        }
    }
}
