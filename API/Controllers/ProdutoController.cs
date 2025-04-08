using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/produto")]
public class ProdutoController : ControllerBase
{
    private readonly IProdutoReposity _produtoRepository;
    public ProdutoController(IProdutoReposity produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    [HttpPost("cadastrar")]
    public IActionResult Cadastrar([FromBody] Produto produto)
    {
        
        _produtoRepository.Cadastrar(produto);
        return Created("", produto);
    }

    [HttpGet("listar")]
    public IActionResult Listar()
    {
        return Ok(_produtoRepository.Listar());
    }
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
