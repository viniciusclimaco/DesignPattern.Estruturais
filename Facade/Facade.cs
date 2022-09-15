using Facade.Domain;
using Facade.Services;

namespace Facade
{
    public class Facade
    {
        BMGService bmgService;
        ItauService itauService;
        CrefisaService crefisaService;

        public Facade()
        {
            bmgService = new BMGService();
            itauService = new ItauService();
            crefisaService = new CrefisaService();
        }

        public List<Emprestimo> BuscarCredito(string cpf)
        {
            var emprestimos = new List<Emprestimo>();
            
            var bmgEmprestimo = bmgService.GetEmprestimo();
            var itauEmprestimo = itauService.GetEmprestimo();            
            var crefisaEmprestimo = crefisaService.GetEmprestimo();

            emprestimos.Add(bmgEmprestimo);
            emprestimos.Add(itauEmprestimo);
            emprestimos.Add(crefisaEmprestimo);
            return emprestimos;
        }
    }
}
