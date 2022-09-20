using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Calculadora.Models;

namespace Calculadora.Controllers;

public class CalculadoraController : Controller
{
    private readonly ILogger<CalculadoraController> _logger;

    public CalculadoraController(ILogger<CalculadoraController> logger)
    {
        _logger = logger;
    }

    public IActionResult Calculadora()
    {
        return View();
    }

    public IActionResult Resultado([FromForm] double numero1, [FromForm] double numero2, [FromForm] int operacao)
    {

        ViewData["numero1"] = numero1;
        ViewData["numero2"] = numero2;

        switch (operacao)
        {
            case 1:
                ViewData["resultado"] = numero1 + numero2;
                ViewData["action"] = "+";
                break;
            case 2:
                ViewData["resultado"] = numero1 - numero2;
                ViewData["action"] = "-";
                break;
            case 3:
                ViewData["resultado"] = numero1 / numero2;
                ViewData["action"] = "/";
                break;
            case 4:
                ViewData["resultado"] = numero1 * numero2;
                ViewData["action"] = "*";
                break;
            default:
                break;
        }

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}