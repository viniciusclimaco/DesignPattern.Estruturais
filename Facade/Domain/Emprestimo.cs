namespace Facade.Domain
{
    public class Emprestimo
    {
        public Guid Id { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal Taxa { get; set; }
        public int numParcelas { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal Parcela { get; set; }
        public string Financiadora { get; set; }        
    }
}
