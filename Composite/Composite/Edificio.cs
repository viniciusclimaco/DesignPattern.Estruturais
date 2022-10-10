namespace Composite.Composite
{
    internal class Edificio : Component.Component
    {
        private IList<Component.Component> itens = new List<Component.Component>();
        public Edificio(string nome) : base(nome)
        {            
        }

        public override void Exibir()
        {
            Console.WriteLine($"Edificio: {Nome}");
            foreach (var item in itens)
            {
                //Recursividade
                item.Exibir();
            }
        }

        public void Adicionar(Component.Component component)
        {
            itens.Add(component);
        }

        public void Remover(Component.Component component)
        {
            itens.Remove(component);
        }
    }
}
