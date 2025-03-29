using Microsoft.AspNetCore.Mvc;
using CasaCambio.Models;

namespace CasaCambio.Controllers
{
    public class BoletaController : Controller
    {
        public IActionResult Generar(decimal monto)
        {
            var model = new BoletaModel { MontoRecibido = monto };
            return View(model);
        }
    }
}
