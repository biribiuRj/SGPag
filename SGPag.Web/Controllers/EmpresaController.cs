using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGPag.Dominio.Contratos;
using SGPag.Dominio.Entidades;

namespace SGPag.Web.Controllers
{
    [Route("api/[Controller]")]
    public class EmpresaController : Controller
    {
        private readonly IEmpresaRepositorio _empresaRepositorio;

        public EmpresaController(IEmpresaRepositorio empresaRepositorio)
        {
            _empresaRepositorio = empresaRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_empresaRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody]Empresa empresa)
        {
            try
            {
                _empresaRepositorio.Adicionar(empresa);
                return Created("api/area", empresa);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}