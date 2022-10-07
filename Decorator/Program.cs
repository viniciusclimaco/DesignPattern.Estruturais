using Decorator.Componente;
using Decorator.ComponenteConcreto;
using Decorator.DecoratorConcreto;

ISanduiche xtudo = new Sanduiche("XTudo");
Console.WriteLine(xtudo.Adicionais());
Console.WriteLine($"Valor total R$ {xtudo.Valor()}");

Console.WriteLine("--- Decorator Pattern ---");

ISanduiche ovo = new OvoDecorator(xtudo);
ISanduiche queijo = new QueijoDecorator(ovo);
ISanduiche presunto = new PresuntoDecorator(queijo);
ISanduiche alface = new AlfaceDecorator(presunto);

Console.WriteLine(alface.Adicionais());
Console.WriteLine($"Valor Total R$ : {alface.Valor()}\n");

Console.ReadKey();