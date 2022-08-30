using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Calculadora.Models;

namespace ExemploAspNetMvc.Controllers;

public class UserRequest
{
    public string Nome { get; set; }
    public string Email { get; set; }
}

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult PrimeiraAction()
    {
        return View();
    }

    public string TesteQueryString([FromQuery]string q, [FromQuery] string nome)
    {
        return $"Chegou aqui {q} e {nome}";
    }

    // public string TesteFormData([FromForm]string nome, [FromForm] string email)
    // {
    //     return $"Nome: {nome}, E-mail: {email}";
    // }

    public IActionResult Formulario()
    {
        return View();
    }

    public string TesteFormData([FromForm] UserRequest userRequest, [FromHeader]string x)
    {
        return $"Nome: {userRequest.Nome}, E-mail: {userRequest.Email}, X: {x}";
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
