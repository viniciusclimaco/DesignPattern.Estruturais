using Decorator.Componente;
using Decorator.Decorator;

namespace Decorator.DecoratorConcreto
{
    public class QueijoDecorator : SanduicheDecorator
    {
        public QueijoDecorator(ISanduiche sanduiche) : base(sanduiche)
        { }

        public override string Adicionais()
        {            
            return String.Concat(base.Adicionais(), " com queijo");
        }
        public override decimal Valor()
        {            
            return decimal.Add(base.Valor(), 1.00M);
        }
    }
}
