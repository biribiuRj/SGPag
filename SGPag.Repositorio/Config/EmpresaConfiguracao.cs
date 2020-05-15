using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGPag.Dominio.Entidades;

namespace SGPag.Repositorio.Config
{
    class EmpresaConfiguracao : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.HasKey(e => e.Id);
            builder
                    .Property(e => e.EmpresaCurto)
                    .IsRequired()
                    .HasMaxLength(50);
            builder
                    .Property(e => e.EmpresaLongo)
                    .IsRequired()
                    .HasMaxLength(50);
            builder
                    .Property(e => e.EmpresaAtivo)
                    .IsRequired()
                    .HasColumnType("int");
        }
    }
}
