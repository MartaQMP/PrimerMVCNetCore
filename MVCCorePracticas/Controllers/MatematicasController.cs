using Microsoft.AspNetCore.Mvc;

namespace MVCCorePracticas.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*GET SOLO*/
        [HttpGet]
        public IActionResult MatematicasGet(int num1, int num2)
        {
            ViewBag.Suma = num1 + num2;
            return View();
        }

        /*GET Y POST (FORMULARIO)*/
        [HttpGet]
        public IActionResult MatematicasPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MatematicasPost(int? num1, int? num2)
        {
            if (num1 != null || num2 != null)
            {
                ViewBag.Suma = num1 + num2;
            }
            return View();
        }

        /*GET Y POST CONJETURA COLLATZ*/
        [HttpGet]
        public IActionResult MatematicasCollatz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MatematicasCollatz(int? numero)
        {
            if (numero != null)
            {
                string numeros = "Numeros: " + numero + ", ";
                while (numero != 1)
                {
                    if (numero % 2 == 0)
                    {
                        numero /= 2;
                        numeros += numero + ", ";
                    }
                    else
                    {
                        numero = (numero * 3) + 1;
                        numeros += numero + ", ";
                    }
                }
                ViewBag.Collatz = numeros.Trim(',');
            }
            return View();
        }

    }
}
