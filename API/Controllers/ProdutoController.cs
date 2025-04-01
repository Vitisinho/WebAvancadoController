using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/produto")]
public class ProdutoController : ControllerBase
{
    //Exemplo de metodo dentro de uma classe
    [HttpGet]
    public string Metodo()
    {
        return "";
    }

    //Exemplo de um EndPoint dentro de um Contrller
    [HttpGet("helloworld")]
    public IActionResult HelloWorld()
    {
        return Ok("Hello World!");
    }
}
