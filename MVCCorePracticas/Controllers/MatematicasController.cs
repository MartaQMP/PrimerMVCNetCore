using Microsoft.AspNetCore.Mvc;
using MVCCorePracticas.Models;

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
        public IActionResult MatematicasCollatz(int numero)
        {
            List<int> model = new List<int>();
            model.Add(numero);
            while (numero != 1)
            {
                if (numero % 2 == 0) numero /= 2;
                else numero = (numero * 3) + 1;
                model.Add(numero);
            }
            
            return View(model);
        }
        /*GET Y POST TABLA MULTIPLICAR*/
        [HttpGet]
        public IActionResult TablaMultiplicar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicar(int numero)
        {
            string modelOperacion;
            int modelResultado;
            List<Tabla> tabla = new List<Tabla>();
            for (int i = 1; i <= 10; i++)
            {
                Models.Tabla fila = new Models.Tabla();
                modelOperacion = numero + " * " + i;
                modelResultado = numero * i;
                fila.Operacion = modelOperacion;
                fila.Resultado = modelResultado;
                tabla.Add(fila);
            }
          
            return View(tabla);
        }

    }
}
