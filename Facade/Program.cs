using Facade.Domain;

Console.WriteLine("--- Pesquisar Crediário ---");
Console.WriteLine("Informe seu CPF: ");
string cpf = Console.ReadLine();

List<Emprestimo> emprestimos = new Facade.Facade().BuscarCredito(cpf);

Console.WriteLine($" ---- Resultado da Pesquisa ---- ");

foreach (var emprestimo in emprestimos)
{
    Console.WriteLine($"Financiadora: {emprestimo.Financiadora}");
    Console.WriteLine($"Valor Líquido: {emprestimo.ValorLiquido}");
    Console.WriteLine($"Número de Parcelas: {emprestimo.numParcelas}");
    Console.WriteLine($"Valor de cada Parcela: {emprestimo.Parcela}");
    Console.WriteLine($"Valor total Financiado: {emprestimo.ValorBruto}");
    Console.WriteLine($"Taxa: {emprestimo.Taxa}\n");    
}

Console.ReadKey();


