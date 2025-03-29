using Microsoft.AspNetCore.Mvc;
using CasaCambio.Models;

namespace CasaCambio.Controllers
{
    public class ConversionController : Controller
    {
        private static readonly Dictionary<string, decimal> TasasCambio = new()
        {
            { "BRL-PEN", 0.75M },
            { "BRL-USD", 0.20M },
            { "PEN-BRL", 1.33M },
            { "PEN-USD", 0.27M },
            { "USD-BRL", 5.00M },
            { "USD-PEN", 3.70M }
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(ConversionModel model)
        {
            string key = $"{model.MonedaOrigen}-{model.MonedaDestino}";
            model.TipoCambio = TasasCambio.ContainsKey(key) ? TasasCambio[key] : 1;
            return View("Resultado", model);
        }
    }
}
