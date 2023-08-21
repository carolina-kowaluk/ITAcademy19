using Microsoft.AspNetCore.Mvc;
using DemoAloMundoRest.DTOs;

namespace DemoAloMundoRest.Controllers;

//https://meuservidor/alomundo
//regras de convençao de nomes

[ApiController]
//[Route("alomundo")] //um tipo de rota -> tem vários
[Route("[controller]")]

public class AloMundoController : ControllerBase
{
    private readonly ILogger<AloMundoController> _logger;

    public AloMundoController(ILogger<AloMundoController> logger) //ponto de injeção de dependência
    {
        _logger = logger;
    }

    //GET.../alomundo
    //https://localhost:7200/alomundo
    [HttpGet]
    public string Get()     
    {
        _logger.LogInformation("GET /alomundo");
        return "Alô Mundo!";
    }

    //GET.../alomundo/carol -> variável nome
    [HttpGet("{nome}")]
    public string Get(string nome) //este método tem um parametro
    {
        _logger.LogInformation("GET /alomundo/{nome}");
        return $"Alô {nome}!";
    }

    //GET.../alomundo/query?nome=carol -> nome na URL
    [HttpGet("query")]
    public string GetQuery(string nome)
    {
        _logger.LogInformation("GET /alomundo/query?nome=valor");
        return $"Alô {nome}!";
    }

    //POST.../alomundo -> nome não vem da URL
    [HttpPost]
    public string Post([FromBody] string nome) //-> nome vem do corpo da requisição
    {
        _logger.LogInformation("POST /alomundo");
        return $"Alô {nome}!";
    }

    //POST.../alomundo/pessoa
    [HttpPost("pessoa")]
    public string Post(Pessoa umaPessoa)
    {
        _logger.LogInformation("POST /alomundo/pessoa");
        _logger.LogInformation($"umaPessoa.nome = {umaPessoa.Nome}");
        _logger.LogInformation($"umaPessoa.idade = {umaPessoa.Idade}");
        return $"Alô {umaPessoa.Nome}!";
    }

}