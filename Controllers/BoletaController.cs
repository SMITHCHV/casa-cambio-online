using Microsoft.AspNetCore.Mvc;
using CasaCambio.Models;

namespace CasaCambio.Controllers
{
    public class BoletaController : Controller
    {
        public IActionResult Generar(decimal monto)
        {
            var model = new BoletaModel
            {
                Nombre = "Usuario Ejemplo",  
                Documento = "12345678",  
                MontoRecibido = monto
            };

            return View(model);
        }
    }
}
