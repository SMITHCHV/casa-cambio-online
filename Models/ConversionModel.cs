namespace CasaCambio.Models
{
    public class ConversionModel
    {
        public required string MonedaOrigen { get; set; }
        public required string MonedaDestino { get; set; }
        public decimal Cantidad { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal Resultado => Cantidad * TipoCambio;
    }
}
