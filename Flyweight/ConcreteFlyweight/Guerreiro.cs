using Flyweight.Flyweight;

namespace Flyweight.ConcreteFlyweight
{
    public class Guerreiro : IPessoa
    {
        //extrínseco
        public string Arma { get; set; }        

        //intrínseco
        string exercito = "Esparta";
        string idade = "Acima de 18 anos";
        string sexo = "Masculino";

        public Guerreiro(string arma)
        {
            Arma = arma;
        }

        public void Exibir()
        {
            Console.WriteLine($"Guerreiro com idade {idade} e o sexo {sexo} do exército de {exercito} portanto uma {Arma}");
        }
    }
}
