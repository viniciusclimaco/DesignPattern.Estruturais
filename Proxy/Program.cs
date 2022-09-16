Console.WriteLine(" --- Proxy Pattern --- ");
Console.WriteLine("Informe o nome de seu usuário: ");
var user = Console.ReadLine();
Console.WriteLine("Informe o valor para Saque: ");
var valor = Console.ReadLine();
Console.WriteLine();
var proxy = new Proxy.Proxy.Proxy(new Proxy.Domain.User(1, user));
proxy.Sacar(Convert.ToDecimal(valor));
Console.ReadKey();

