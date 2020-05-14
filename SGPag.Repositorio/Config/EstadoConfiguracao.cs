using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGPag.Dominio.Entidades;

namespace SGPag.Repositorio.Config
{
    class EstadoConfiguracao : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasKey(e => e.Id);
            builder
                    .Property(e => e.UF)
                    .IsRequired()
                    .HasMaxLength(5);
            builder
                    .Property(e => e.NomeEstado)
                    .IsRequired()
                    .HasMaxLength(30);
            builder
                    .Property(e => e.CreatedAt)
                    .HasColumnType("datetime");
            builder
                    .Property(e => e.UpdatedAt)
                    .HasColumnType("datetime");

        }
    }
}

