using Adapter.Domain;

namespace Adapter
{
    public interface ICafeteiraTresCoracoes
    {
        public void AquecerTresCoracoes();
        public void CafeProntoTresCoracoes(Cooffe cooffe);
        public void LigarTresCoracoes();
        public void DesligarTresCoracoes();
    }
}
