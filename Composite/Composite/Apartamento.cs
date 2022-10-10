namespace Composite.Composite
{
    internal class Apartamento : Component.Component
    {
        private IList<Component.Component> itens = new List<Component.Component>();
        public Apartamento(string nome) : base(nome)
        {
        }

        public override void Exibir()
        {
            Console.WriteLine("");
            Console.WriteLine($"Apartamento: {Nome}");
            foreach (var item in itens)
            {
                //Recursividade
                item.Exibir();
            }
        }

        public void Adicionar(Component.Component component) {
            itens.Add(component);
        }

        public void Remover(Component.Component component)
        {
            itens.Remove(component);
        }
    }
}
