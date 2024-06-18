using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Domain.DTos;
using Senai.Service.Interfaces;

namespace Senai.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolaController : ControllerBase
    {
        private readonly IEscolaService _escolaService;

        public EscolaController(IEscolaService escolaService)
        {
            _escolaService = escolaService;
        }
        [HttpPost]
        [Route("Adicionar")]
        public ActionResult Salvar(EscolaDto model)
        {
            var escola = _escolaService.Salvar(model);

            return Ok(escola);
        }

        [HttpDelete]
        [Route("Deletar")]
        public ActionResult Remover(long id)
        {
            var escola = _escolaService.Remover(id);

            return Ok(escola);
        }

        [HttpPatch]
        [Route("Editar")]
        public IActionResult Editar(EscolaDto model)
        {
            var escola = _escolaService.Salvar(model);

            return Ok(escola);
        }

        [HttpGet]
        [Route("BuscarPorId")]
        public ActionResult BuscarPorId(long id) 
        {
            var escola = _escolaService.BuscarPorId(id);
            return Ok(escola);
        }
        [HttpGet]
        [Route("BuscarTodos")]
        public IActionResult BuscarTodos()
        {
            var todos = _escolaService.BuscarTodos();
            return Ok(todos);
        }

    }
}
