using Flyweight.Flyweight;

string tipoPessoa = string.Empty;
IPessoa pessoa;

while (true)
{
    Console.WriteLine();

    Console.Write("Que tipo de personagem deseja criar: ");
    tipoPessoa = Console.ReadLine();

    pessoa = Flyweight.FlyweightFactory.FlyweightFactory.GetPessoa(tipoPessoa);
    pessoa.Exibir();

    Console.WriteLine();
}



