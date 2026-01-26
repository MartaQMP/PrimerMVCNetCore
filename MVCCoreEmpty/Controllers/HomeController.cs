using Microsoft.AspNetCore.Mvc;
using MVCCoreEmpty.Models;

namespace MVCCoreEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Vista1()
        {
            return View();
        }
        public IActionResult Vista2()
        {
            return View();
        }

        public IActionResult VistaPersona()
        {
            Persona persona = new Persona();
            persona.Nombre = "Marta";
            persona.Edad = 20;
            persona.Email = "marta@email.com";
            return View(persona);
        }
    }
}
