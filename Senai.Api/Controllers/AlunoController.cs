using Microsoft.AspNetCore.Mvc;
using Senai.Domain.DTos;
using Senai.Service.Interfaces;
using Senai.Service.Services;

namespace Senai.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpPost]
        [Route("Adicionar")]
        public ActionResult Salvar(AlunoDto model)
        {
            var aluno = _alunoService.Salvar(model);

            return Ok(aluno);
        }
       
        [HttpDelete]
        [Route("Deletar")]
        public ActionResult Remover(long id)
        {
            var escola = _alunoService.Remover(id);

            return Ok(escola);
        }

        [HttpPatch]
        [Route("Editar")]
        public IActionResult Editar(AlunoDto model)
        {
            var aluno = _alunoService.Salvar(model);

            return Ok(aluno);
        }

        [HttpGet]
        [Route("BuscarPorId")]
        public ActionResult BuscarPorId(long id)
        {
            var aluno = _alunoService.BuscarPorId(id);
            return Ok(aluno);
        }
        [HttpGet]
        [Route("BuscarTodos")]
        public IActionResult BuscarTodos()
        {
            var todos = _alunoService.BuscarTodos();
            return Ok(todos);
        }
    }
}
