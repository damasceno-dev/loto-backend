using Loto.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace LotoBackend.API.Controllers;

[Route("[controller]")]
[ApiController]
public class ExtratosController : ControllerBase
{
    [HttpPost]
    [Route("/Extratos/registrar")]
    public IActionResult Registrar([FromBody] RequestRegistrarExtratoJson request)
    {
        return Created();
    }
}