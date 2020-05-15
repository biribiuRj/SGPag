using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGPag.Dominio.Entidades;

namespace SGPag.Repositorio.Config
{
    class AreaConfiguracao : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder.HasKey(a => a.Id);
            builder
                    .Property(a => a.AreaCurto)
                    .IsRequired()
                    .HasMaxLength(50);
            builder
                    .Property(a => a.AreaLongo)
                    .IsRequired()
                    .HasMaxLength(50);
            builder
                    .Property(a => a.AreaAtivo)
                    .IsRequired()
                    .HasColumnType("int");
        }
    }
}
