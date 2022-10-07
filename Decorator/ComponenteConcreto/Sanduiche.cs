using Decorator.Componente;

namespace Decorator.ComponenteConcreto
{
    public class Sanduiche : ISanduiche
    {
        private string _nome { get; set; }
        public Sanduiche(string nome)
        {
            _nome = nome;
        }
        public string Adicionais()
        {
            return $"Preparando um sanduíche: {_nome}";             
        }
        public decimal Valor()
        {            
            return 5.00M;
        }
    }
}
