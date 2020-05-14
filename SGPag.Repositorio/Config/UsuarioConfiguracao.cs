using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGPag.Dominio.Entidades;

namespace SGPag.Repositorio.Config
{
    public class UsuarioConfiguracao : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            builder
                    .Property(u => u.Nome)
                    .IsRequired()
                    .HasMaxLength(50);
            builder
                    .Property(u => u.User)
                    .IsRequired()
                    .HasMaxLength(30);
            builder
                    .Property(u => u.Email)
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
