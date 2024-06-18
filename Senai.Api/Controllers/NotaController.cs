using Microsoft.AspNetCore.Mvc;
using Senai.Domain.DTos;
using Senai.Service.Interfaces;

namespace Senai.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotaController : ControllerBase
    {
        private readonly INotaService _notaService;

        public NotaController(INotaService notaService)
        {
            _notaService = notaService;
        }

        [HttpPost]
        [Route ("BuscarMedias")]

        public IActionResult BuscarMedias([FromBody] MediaNotarPorAlunoESemestreDto filtro)
        {
            var medias = _notaService.MediaNotas(filtro);
            return Ok(medias);
        }
    }
}
