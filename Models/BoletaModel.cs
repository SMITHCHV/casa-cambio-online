namespace CasaCambio.Models
{
    public class BoletaModel
    {
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public decimal MontoRecibido { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}

