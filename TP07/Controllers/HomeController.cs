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
         
        return View();
    }
    public IActionResult Jugar()
        {
           
        
        palabra.nuevaPartida();
            
    
        ViewBag.PalabraOculta = palabra.encontrarPalabraOculta();
        ViewBag.LetrasUsadas = palabra.intentos;
        ViewBag.Gano = palabra.gano;
        ViewBag.Finalizo = palabra.finalizo;
        ViewBag.PalabraOriginal = palabra.palabraSecreta;
        
        
    
       
             return View("Jugar");
        }
    public IActionResult arriesgarPalabra(string palabraIngresada)
    {
        ViewBag.PalabraOculta = palabra.encontrarPalabraOculta();

      

        bool gano = palabra.ArriesgarPalabra(palabraIngresada);
        if (gano == true )
        {
            ViewBag.Gano = palabra.gano;
            ViewBag.LetrasUsadas = palabra.intentos;
            ViewBag.cantIntentos = palabra.intentos.Count;
            ViewBag.PalabraOriginal = palabra.palabraSecreta;

        }
        else
        {
            ViewBag.Gano = palabra.gano;
            ViewBag.LetrasUsadas = palabra.intentos;
            ViewBag.cantIntentos = palabra.intentos.Count;
            ViewBag.PalabraOriginal = palabra.palabraSecreta;
        }

        return View("Final");

    }
       public IActionResult arriesgarLetra(char letra)
    {
       

      
              palabra.inicializarLetra(letra);
            string oculto = palabra.encontrarPalabraOculta();
            bool gano = palabra.VerificarGanador(oculto);

            ViewBag.PalabraOculta= oculto;
            ViewBag.LetrasUsadas= palabra.intentos;
            ViewBag.CantIntentos= palabra.intentos.Count;
            ViewBag.Gano= palabra.gano;
            ViewBag.Finalizo= palabra.finalizo;
            ViewBag.PalabraOriginal= palabra.palabraSecreta;

     
            if (palabra.finalizo == true)
                return View("final");
            else
                return View("jugar");

    }

}
