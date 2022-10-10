using Bridge.Abstraction;
using Bridge.Implementor;

namespace Bridge.RefinedAbstraction
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(ITransferencia transferencia) : base(transferencia)
        {
        }

        public override void TransferirDinheiro(decimal valor)
        {
            Console.WriteLine("Gerando transferência por conta corrente");
            base.TransferirDinheiro(valor);
        }        
    }
}
