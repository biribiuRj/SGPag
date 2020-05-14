using Microsoft.EntityFrameworkCore;
using SGPag.Dominio.Entidades;
using SGPag.Repositorio.Config;

namespace SGPag.Repositorio.Contexto
{
    public class SGPagContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public SGPagContexto(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AreaConfiguracao());
            modelBuilder.ApplyConfiguration(new EmpresaConfiguracao());
            modelBuilder.ApplyConfiguration(new EstadoConfiguracao());
            modelBuilder.ApplyConfiguration(new FornecedorConfiguracao());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguracao());

            base.OnModelCreating(modelBuilder);
        }
    }
}
