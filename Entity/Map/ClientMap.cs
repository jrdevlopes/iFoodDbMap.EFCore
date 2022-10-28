using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iFoodDbMap.EFCore.Entity.Map
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");

            builder.Property(c => c.Name)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(c => c.Cpf)
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(c => c.CellphoneNumber)
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(c => c.Email)
                .HasColumnType("varchar(30)")
                .IsRequired();

            builder.HasMany(c => c.Address)
                 .WithOne(cc => cc.Client)
                 .IsRequired();
        }
    }
}
