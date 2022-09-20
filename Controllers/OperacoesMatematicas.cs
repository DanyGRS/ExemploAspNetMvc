
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Calculadora.Models;

namespace Calculadora.Controllers;

public class OperacoesMatematicasController : Controller
{
    private readonly ILogger<OperacoesMatematicasController> _logger;

    public OperacoesMatematicasController(ILogger<OperacoesMatematicasController> logger)
    {
        _logger = logger;
    }

    public IActionResult Somar()
    {
        return View();
    }
    public IActionResult Subtrair()
    {
        return View();
    }
    public IActionResult Multiplicar()
    {
        return View();
    }
    public IActionResult Dividir()
    {
        return View();
    }

    public IActionResult ResultadoSomar([FromForm] double numberOne, [FromForm] double numberTwo)
    {
        ViewData["numberOne"] = numberOne;
        ViewData["numberTwo"] = numberTwo;
        ViewData["resultado"] = numberOne + numberTwo;

        return View();
    }

    public IActionResult ResultadoSubtrair([FromForm] double numberOne, [FromForm] double numberTwo)
    {
        ViewData["numberOne"] = numberOne;
        ViewData["numberTwo"] = numberTwo;
        ViewData["resultado"] = numberOne - numberTwo;

        return View();
    }
    public IActionResult ResultadoMultiplicar([FromForm] double numberOne, [FromForm] double numberTwo)
    {
        ViewData["numberOne"] = numberOne;
        ViewData["numberTwo"] = numberTwo;
        ViewData["resultado"] = numberOne * numberTwo;

        return View();
    }
    public IActionResult ResultadoDividir([FromForm] double numberOne, [FromForm] double numberTwo)
    {
        ViewData["numberOne"] = numberOne;
        ViewData["numberTwo"] = numberTwo;
        ViewData["resultado"] = numberOne / numberTwo;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}