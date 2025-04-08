using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers;

[ApiController]
[Route("api/usuario")]

public class UsuarioController : ControllerBase
{
     private readonly IUsuarioRepository _usuarioRepository;
    public UsuarioController(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    [HttpPost("cadastrar")]
    public IActionResult Cadastrar([FromBody] Usuario usuario)
    {
        
        _usuarioRepository.Cadastrar(usuario);
        return Created("", usuario);
    }

    [HttpGet("listar")]
    public IActionResult Listar()
    {
        return Ok(_usuarioRepository.Listar());
    }
}
