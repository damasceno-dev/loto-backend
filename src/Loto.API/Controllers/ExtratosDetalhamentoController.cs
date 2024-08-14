using Loto.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace LotoBackend.API.Controllers;

[Route("[controller]")]
[ApiController]
public class ExtratosDetalhamentoController : ControllerBase
{
    [HttpPost]
    [Route("{extratoId}/registrar")]
    public IActionResult Registrar([FromBody] RequestRegistrarExtratoDetalhamentoJson request)
    {
        return Created();
    }
}