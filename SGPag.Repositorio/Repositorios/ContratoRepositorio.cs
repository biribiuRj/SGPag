using SGPag.Dominio.Entidades;
using SGPag.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Text;
using SGPag.Repositorio.Contexto;

namespace SGPag.Repositorio.Repositorios
{
    public class ContratoRepositorio : BaseRepositorio<Contrato>, IContratoRepositorio
    {
        public ContratoRepositorio(SGPagContexto sGPagContexto) : base(sGPagContexto)
        {
        }
    }
}
