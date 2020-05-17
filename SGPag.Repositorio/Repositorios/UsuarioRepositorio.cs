using SGPag.Dominio.Contratos;
using SGPag.Dominio.Entidades;
using SGPag.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGPag.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(SGPagContexto sGPagContexto) : base(sGPagContexto)
        {
        }

        public Usuario Obter(string email, string senha)
        {
            return SGPagContexto.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public Usuario Obter(string email)
        {
            return SGPagContexto.Usuarios.FirstOrDefault(u => u.Email == email);
        }
    }
}
