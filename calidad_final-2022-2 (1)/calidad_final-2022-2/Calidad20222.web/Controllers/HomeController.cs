using System.Diagnostics;
using Calidad20222.web.Helper;
using Microsoft.AspNetCore.Mvc;
using Calidad20222.web.Models;
using Calidad20222.web.Services;

namespace Calidad20222.web.Controllers;

public class HomeController : Controller
{

    public HomeController()
    {
        
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(new List<Carta>());
    }
    
    [HttpPost]
    public IActionResult Generar(String C1, String C2, String C3, String C4, String C5, String P1, String P2, String P3, String P4, String P5)
    {
        List<Carta> lista = new List<Carta>()
        {
            new Carta
            {
                Numero = int.Parse(C1),
                Palo = P1
            },
            new Carta
            {
                Numero = int.Parse(C2),
                Palo = P2
            },
            new Carta
            {
                Numero = int.Parse(C3),
                Palo = P3
            },
            new Carta
            {
                Numero = int.Parse(C4),
                Palo = P4
            },
            new Carta
            {
                Numero = int.Parse(C5),
                Palo = P5
            }
        };
        var service = new PokerService();
        //var cartas = GeneradorMano.Generar();
        ViewBag.Jugada = service.GetJugada(lista);
        return View("Index", lista);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}