using Decorator.Componente;
using Decorator.Decorator;

namespace Decorator.DecoratorConcreto
{
    public class PresuntoDecorator : SanduicheDecorator
    {
        public PresuntoDecorator(ISanduiche sanduiche) : base(sanduiche)
        { }

        public override string Adicionais()
        {            
            return String.Concat(base.Adicionais(), " com presunto");
        }
        public override decimal Valor()
        {            
            return decimal.Add(base.Valor(), 2.00M);
        }
    }
}
