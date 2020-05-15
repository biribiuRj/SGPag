using SGPag.Dominio.Contratos;
using SGPag.Dominio.Entidades;
using SGPag.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGPag.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(SGPagContexto sGPagContexto) : base(sGPagContexto)
        {

        }
    }
}
