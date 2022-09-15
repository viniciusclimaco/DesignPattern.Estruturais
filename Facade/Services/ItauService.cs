using Facade.Domain;

namespace Facade.Services
{
    public class ItauService
    {
        public Emprestimo GetEmprestimo()
        {
            //simulando que buscou os dados numa biblioteca, numa API etc
            var emprestimo = new Emprestimo();
            emprestimo.Id = Guid.NewGuid();
            emprestimo.Taxa = 1.0M;
            emprestimo.Financiadora = "ITAU";
            emprestimo.ValorLiquido = 100000M;
            emprestimo.ValorBruto = 119571.53M;
            emprestimo.Parcela = 3321.43M;
            emprestimo.numParcelas = 36;
            return emprestimo;
        }
    }
}
