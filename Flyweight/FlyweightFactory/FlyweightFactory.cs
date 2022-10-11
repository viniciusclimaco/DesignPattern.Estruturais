using Flyweight.ConcreteFlyweight;
using Flyweight.Flyweight;
using System.Collections;

namespace Flyweight.FlyweightFactory
{
    public class FlyweightFactory
    {
        private static Dictionary<string, IPessoa> listaPessoas = new Dictionary<string, IPessoa>();
        private static IList armas = new ArrayList{ "Faca", "Espada", "Escudo" };

        public static IPessoa GetPessoa(string tipo)
        {
            IPessoa personagem;
            tipo = tipo.ToUpper();

            if (listaPessoas.ContainsKey(tipo))
            {
                Console.WriteLine($"-->> Objeto pré-existente do tipo : {tipo}");
                if (tipo == "CRIANCA")
                {
                    Crianca crianca = listaPessoas[tipo] as Crianca;
                    crianca.Nome = new RandomNameGeneratorLibrary.PersonNameGenerator().GenerateRandomFirstName();
                }
                else
                {
                    Guerreiro guerreiro = listaPessoas[tipo] as Guerreiro;
                    guerreiro.Arma = armas[getRandomArma()].ToString();
                }
                return listaPessoas[tipo];
            }
            else
            {
                Console.WriteLine($"-->> Novo Objeto do tipo : {tipo}");
                if (tipo == "CRIANCA")
                {
                    personagem = new Crianca(new RandomNameGeneratorLibrary.PersonNameGenerator().GenerateRandomFirstName());
                    listaPessoas.Add("CRIANCA", personagem);
                }
                else
                {                    
                    personagem = new Guerreiro(armas[getRandomArma()].ToString());
                    listaPessoas.Add("GUERREIRO", personagem);
                }                
            }
            return personagem;
        }

        private static int getRandomArma()
        {
            Random rnd = new Random();
            return rnd.Next(0, 3);
        }
    }
}
