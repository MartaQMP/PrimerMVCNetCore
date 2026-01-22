using Microsoft.AspNetCore.Mvc;
using PrimerMVCNetCore.Models;

namespace PrimerMVCNetCore.Controllers
{
    public class InformacionController : Controller
    {
        [HttpGet]
        public IActionResult Index(int variable1, string variable2)
        {
            return View();
        }

        public IActionResult ControladorVista()
        {
            //VAMOS A ENVIAR INFORMACION SIMPLE A NUESTRA VISTA
            ViewData["NOMBRE"] = "Alumno";
            ViewData["EDAD"] = 21;
            ViewBag.DiaSemana = "Jueves";
            return View();
        }

        public IActionResult ControladorVistaModel()
        {
            Persona persona = new Persona();
            persona.Nombre = "Marta";
            persona.Email = "marta@email.com";
            persona.Edad = 20;
            return View(persona);
        }

        [HttpGet]
        public IActionResult VistaControllerGet(string saludo, int? year) {
            //PARA COMPROBAR QUE HEMOS RECIBIDO LOS DATOS MEDIANTE UN ActionLink
            //DEVOLVEMOS UN MENSAJE A LA VISTA PARA DIBUJARLO

            if (year != null)
            {
                ViewData["MENSAJE"] = saludo + " en el año " + year;
            }
            else
            {
                ViewBag.Mensaje = "Aqui nadie saluda ya...";
            }
                return View();
        }

        [HttpGet]
        public IActionResult VistaControllerPost()
        {
            return View();
        }

       [HttpPost]
        public IActionResult VistaControllerPost(Persona persona, string aficiones)
        {
            ViewBag.Mensaje = "Nombre: " + persona.Nombre + ", email: " 
                + persona.Email + ", edad: " + persona.Edad + ", aficiones: " + aficiones;
            return View();
        }

    }


}
