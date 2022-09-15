using Facade.Domain;

namespace Facade.Services
{
    public class BMGService
    {
        public Emprestimo GetEmprestimo()
        {
            //simulando que buscou os dados numa biblioteca, numa API etc
            var emprestimo = new Emprestimo();
            emprestimo.Id = Guid.NewGuid();
            emprestimo.Taxa = 1.5M;
            emprestimo.Financiadora = "BMG";
            emprestimo.ValorLiquido = 100000M;
            emprestimo.ValorBruto = 130148.63M;
            emprestimo.Parcela = 3615.24M;
            emprestimo.numParcelas = 36;
            return emprestimo;
        }
    }
}
