using Decorator.Componente;
using Decorator.Decorator;

namespace Decorator.DecoratorConcreto
{
    public class AlfaceDecorator : SanduicheDecorator
    {
        public AlfaceDecorator(ISanduiche sanduiche) : base(sanduiche)
        { }

        public override string Adicionais()
        {            
            return String.Concat(base.Adicionais(), " com alface");
        }
        public override decimal Valor()
        {            
            return decimal.Add(base.Valor(), 1.50M);
        }
    }
}
