using Bridge.Implementor;

namespace Bridge.ConcreteImplementor
{
    public class Pix : ITransferencia
    {
        public void GerarTransferencia(decimal valor)
        {
            Console.WriteLine($"Realizando transferência de {valor} via PIX\n");
        }
    }
}
