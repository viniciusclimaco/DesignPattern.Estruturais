using Facade.Domain;

namespace Facade.Services
{
    public class CrefisaService
    {
        public Emprestimo GetEmprestimo()
        {
            //simulando que buscou os dados numa biblioteca, numa API etc
            var emprestimo = new Emprestimo();
            emprestimo.Id = Guid.NewGuid();
            emprestimo.Taxa = 1.75M;
            emprestimo.Financiadora = "BMG";
            emprestimo.ValorLiquido = 100000M;
            emprestimo.ValorBruto = 135630.25M;
            emprestimo.Parcela = 33767.51M;
            emprestimo.numParcelas = 36;
            return emprestimo;
        }
    }
}
