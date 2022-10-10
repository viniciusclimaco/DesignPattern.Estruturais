using Bridge.Implementor;

namespace Bridge.ConcreteImplementor
{
    public class Ted : ITransferencia
    {
        public void GerarTransferencia(decimal valor)
        {
            Console.WriteLine($"Realizando transferência de {valor} via TED\n");
        }
    }
}
