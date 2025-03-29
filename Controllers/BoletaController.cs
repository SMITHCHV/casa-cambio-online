using Microsoft.AspNetCore.Mvc;
using CasaCambio.Models;

namespace CasaCambio.Controllers
{
    public class BoletaController : Controller
    {
        public IActionResult Generar(string nombre, string documento, decimal monto)
        {
            var model = new BoletaModel
            {
                Nombre = nombre,
                Documento = documento,
                MontoRecibido = monto
            };

            return View(model);
        }
    }
}
