using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP07.Models;

namespace TP07.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
         Juego juego = new Juego();   
        HttpContext.Session.SetString("juego",objeto.ObjectToString(juego));
           ViewBag.jugadores = juego.DevolverListaUsuarios();
         return View("Index");
     
    }
    [HttpPost]
    public IActionResult Comenzar(string username, int dificultad)
        {
           Juego juego = objeto.StringToObject<Juego>(HttpContext.Session.GetString("juego"));
            juego.InicializarJuego(username, dificultad);
           ViewBag.Username = username;               
           ViewBag.Palabra = juego.PalabraActual;
        
          HttpContext.Session.SetString("juego", objeto.ObjectToString(juego));

       
             return View("Jugar");
        }
   [HttpPost] 
   public IActionResult FinJuego(int intentos)
{
     Juego juego = objeto.StringToObject<Juego>(HttpContext.Session.GetString("juego"));
    juego.FinJuego(intentos);
    juego.jugadorActual = null;

    HttpContext.Session.SetString("juego", objeto.ObjectToString(juego));

    return RedirectToAction("Index");
}
    
}
