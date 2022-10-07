using Decorator.Componente;

namespace Decorator.Decorator
{
    public abstract class SanduicheDecorator : ISanduiche
    {
        private readonly ISanduiche _sanduiche;
        public SanduicheDecorator(ISanduiche sanduiche)
        {
            _sanduiche = sanduiche;
        }

        public virtual string Adicionais()
        {
            return _sanduiche.Adicionais();
            
        }

        public virtual decimal Valor()
        {
            return _sanduiche.Valor();
        }
    }
}
