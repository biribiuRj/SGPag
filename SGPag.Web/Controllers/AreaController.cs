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
    public class AreaController : Controller
    {
        private readonly IAreaRepositorio _areaRepositorio;

        public AreaController(IAreaRepositorio areaRepositorio)
        {
            _areaRepositorio = areaRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_areaRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody]Area area)
        {
            try
            {

                if (area.Id > 0)
                {
                    _areaRepositorio.Atualizar(area);
                }
                _areaRepositorio.Adicionar(area);

                return Created("api/area",area);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}