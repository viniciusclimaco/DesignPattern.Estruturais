using Bridge.Implementor;

namespace Bridge.Abstraction
{
    public abstract class Conta
    {
        protected ITransferencia _transferencia;
        public Conta(ITransferencia transferencia)
        {
            _transferencia = transferencia;
        }

        public virtual void TransferirDinheiro(decimal valor)
        {
            _transferencia.GerarTransferencia(valor);
        }
    }
}

