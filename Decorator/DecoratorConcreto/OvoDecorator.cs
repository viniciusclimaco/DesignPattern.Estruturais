using Decorator.Componente;
using Decorator.Decorator;

namespace Decorator.DecoratorConcreto
{
    public class OvoDecorator : SanduicheDecorator
    {
        public OvoDecorator(ISanduiche sanduiche) : base(sanduiche)
        { }

        public override string Adicionais()
        {            
            return String.Concat(base.Adicionais(), " com ovo");
        }
        public override decimal Valor()
        {            
            return decimal.Add(base.Valor(), 0.50M);
        }
    }
}
