namespace Composite.Component
{
    public abstract class Component
    {
        protected string Nome;
        public Component(string nome)
        {
            Nome = nome;
        }

        public abstract void Exibir();
    }
}
