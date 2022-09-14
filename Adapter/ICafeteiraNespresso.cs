using Adapter.Domain;

namespace Adapter
{
    public interface ICafeteiraNespresso
    {
        public void AquecerNespresso();
        public void CafeProntoNespresso(Cooffe cooffe);
        public void LigarNespresso();
        public void DesligarNespresso();
        
    }
}
