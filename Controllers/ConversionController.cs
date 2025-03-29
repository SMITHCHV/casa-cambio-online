using Microsoft.AspNetCore.Mvc;

namespace CasaCambio.Controllers
{
    public class ConversionController : Controller
    {
        private readonly Dictionary<string, decimal> tasasCambio = new()
        {
            { "BRL_PEN", 0.634m },
            { "PEN_BRL", 1.578m },
            { "PEN_USD", 0.274m },
            { "USD_PEN", 3.652m },
            { "USD_BRL", 5.762m },
            { "BRL_USD", 0.174m }
        };

        [HttpPost]
        public IActionResult RealizarCambio(string monedaOrigen, string monedaDestino, decimal monto)
        {
            if (monedaOrigen == monedaDestino)
            {
                ViewBag.Mensaje = "Las monedas de origen y destino deben ser diferentes.";
                return View("Resultado");
            }

            string clave = monedaOrigen + "_" + monedaDestino;
            decimal montoConvertido = tasasCambio.ContainsKey(clave) ? monto * tasasCambio[clave] : 0;

            ViewBag.MonedaOrigen = monedaOrigen;
            ViewBag.MonedaDestino = monedaDestino;
            ViewBag.MontoIngresado = monto;
            ViewBag.MontoConvertido = montoConvertido;

            return View("Resultado");
        }
    }
}
