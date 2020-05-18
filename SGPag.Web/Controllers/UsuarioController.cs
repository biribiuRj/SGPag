using Microsoft.AspNetCore.Mvc;
using SGPag.Dominio.Contratos;
using SGPag.Dominio.Entidades;
using System;

namespace SGPag.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Get()
        {
            try
            {
                return Json(_usuarioRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                var usuarioRetorno = _usuarioRepositorio.Obter(usuario.Email, usuario.Senha);

                if (usuarioRetorno != null)
                {
                    return Ok(usuarioRetorno);
                }

                return BadRequest("Usuario ou Senha Inválidos");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                usuario.Validate();
                if (!usuario.EhValido)
                {
                    return BadRequest(usuario.ObterMensagensValidação());
                }
                if (usuario.Id > 0)
                {
                    _usuarioRepositorio.Atualizar(usuario);
                }
                _usuarioRepositorio.Adicionar(usuario);
                var mensagemSucesso = "Operação realizada com Sucesso!";
                return Ok(mensagemSucesso);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("Deletar")]
        public IActionResult Deletar([FromBody] Usuario usuario)
        {
            try
            {
                _usuarioRepositorio.Remover(usuario);
                return Json(_usuarioRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
