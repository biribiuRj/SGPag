using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGPag.Dominio.Entidades;

namespace SGPag.Repositorio.Config
{
    class FornecedorConfiguracao : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(f => f.Id);
        }
    }
}
