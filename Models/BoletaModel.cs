namespace CasaCambio.Models
{
    public class BoletaModel
    {
        public required string Nombre { get; set; }
        public required string Documento { get; set; }
        public decimal MontoRecibido { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        // 🔹 Constructor que asigna valores por defecto y evita el error
        public BoletaModel()
        {
            Nombre = "Nombre Predeterminado";
            Documento = "00000000";
        }
    }
}
