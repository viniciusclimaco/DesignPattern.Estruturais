using Adapter.Domain;

namespace Adapter
{
    public class CafeteiraNespressoAdapter : ICafeteiraTresCoracoes
    {
        private CafeteiraNespresso _cafeteiraNespresso;
        public CafeteiraNespressoAdapter()
        {
            _cafeteiraNespresso = new CafeteiraNespresso();
        }

        public void AquecerTresCoracoes()
        {
            _cafeteiraNespresso.AquecerNespresso();
        }

        public void CafeProntoTresCoracoes(Cooffe cooffe)
        {
            _cafeteiraNespresso.CafeProntoNespresso(cooffe);
        }

        public void DesligarTresCoracoes()
        {
            _cafeteiraNespresso.DesligarNespresso();
        }

        public void LigarTresCoracoes()
        {
            _cafeteiraNespresso.LigarNespresso();
        }
    }
}
