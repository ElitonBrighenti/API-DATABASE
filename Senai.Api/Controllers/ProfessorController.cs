using Microsoft.AspNetCore.Mvc;
using Senai.Domain.DTos;
using Senai.Service.Interfaces;
using Senai.Service.Services;

namespace Senai.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorService _professorService;

        public ProfessorController(IProfessorService professorService)
        {
            _professorService = professorService;
        }
        [HttpPost]
        [Route("Adicionar")]

        public ActionResult Salvar(ProfessorDto model)
        { 
            var professor = _professorService.Salvar(model);

            return Ok(professor);
        }
        [HttpDelete]
        [Route("Deletar")]
        public ActionResult Deletar(long id)
        {
            var professor = _professorService.Remover(id);

            return Ok(professor);
        }

        [HttpPatch]
        [Route("Editar")]
        public IActionResult Editar(ProfessorDto model)
        {
            var escola = _professorService.Salvar(model);

            return Ok(escola);
        }

        [HttpGet]
        [Route("BuscarPorId")]
        public ActionResult BuscarPorId(long id)
        {
            var professor = _professorService.BuscarPorId(id);
            return Ok(professor);
        }
        [HttpGet]
        [Route("BuscarTodos")]
        public IActionResult BuscarTodos()
        {
            var todos = _professorService.BuscarTodos();
            return Ok(todos);
        }
    }
}
