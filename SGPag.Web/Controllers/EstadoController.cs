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
    public class EstadoController : Controller
    {
        private readonly IEstadoRepositorio _estadoRepositorio;

        public EstadoController(IEstadoRepositorio estadoRepositorio)
        {
            _estadoRepositorio = estadoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_estadoRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody]Estado estado)
        {
            try
            {
                _estadoRepositorio.Adicionar(estado);
                return Created("api/area", estado);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}