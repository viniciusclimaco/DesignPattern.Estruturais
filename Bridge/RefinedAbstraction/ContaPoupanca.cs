using Bridge.Abstraction;
using Bridge.Implementor;

namespace Bridge.RefinedAbstraction
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(ITransferencia transferencia) : base(transferencia)
        {
        }

        public override void TransferirDinheiro(decimal valor)
        {
            Console.WriteLine("Gerando transferência por conta poupança");
            base.TransferirDinheiro(valor);
        }
    }
}


