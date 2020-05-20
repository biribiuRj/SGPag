using SGPag.Dominio.Contratos;
using SGPag.Dominio.Entidades;
using SGPag.Repositorio.Contexto;

namespace SGPag.Repositorio.Repositorios
{
    public class EstadoRepositorio : BaseRepositorio<Estado>, IEstadoRepositorio
    {
        public EstadoRepositorio(SGPagContexto sGPagContexto) : base(sGPagContexto)
        {
        }
    }
}
