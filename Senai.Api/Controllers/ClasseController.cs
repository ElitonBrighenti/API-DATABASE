using Microsoft.AspNetCore.Mvc;
using Senai.Domain.DTos;
using Senai.Service.Interfaces;

namespace Senai.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClasseController : ControllerBase
    {
        private readonly IClasseService _classeService;

        public ClasseController(IClasseService classeService)
        {
            _classeService = classeService;
        }

        [HttpPost]
        [Route("Adicionar")]
        public ActionResult Salvar(ClasseDto model)
        {
            var aluno = _classeService.Salvar(model);
            return Ok(aluno);
        }

    }
}
