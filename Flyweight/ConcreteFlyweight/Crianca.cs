using Flyweight.Flyweight;

namespace Flyweight.ConcreteFlyweight
{
    public class Crianca : IPessoa
    {
        //extrínseco        
        public string Nome { get; set; }        

        //intrínseco
        string local = "Grécia";
        string idade = "Abaixo de 18 anos";

        public Crianca(string nome)
        {
            Nome = nome;
        }

        public void Exibir()
        {
            Console.WriteLine($"Criança de nome: {Nome}, com idade {idade} e morador da {local}");
        }
    }
}
