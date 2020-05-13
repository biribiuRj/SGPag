using Microsoft.EntityFrameworkCore;
using SGPag.Dominio.Entidades;

namespace SGPag.Repositorio.Contexto
{
    class SGPagContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
