using SGPag.Dominio.Entidades;
using SGPag.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Text;
using SGPag.Repositorio.Contexto;

namespace SGPag.Repositorio.Repositorios
{
    public class AreaRepositorio : BaseRepositorio<Area>, IAreaRepositorio
    {
        public AreaRepositorio(SGPagContexto sGPagContexto) : base(sGPagContexto)
        {
        }
    }
}
