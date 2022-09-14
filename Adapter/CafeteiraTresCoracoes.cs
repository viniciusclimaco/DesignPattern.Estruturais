using Adapter.Domain;

namespace Adapter
{
    public class CafeteiraTresCoracoes : ICafeteiraTresCoracoes
    {   
        public void AquecerTresCoracoes()
        {
            Console.WriteLine("Aquecendo cafeteira 3 corações.");            
        }

        public void CafeProntoTresCoracoes(Cooffe cooffe)
        {
            Console.WriteLine($"O {cooffe.Nome} está pronto.");
        }

        public void LigarTresCoracoes()
        {
            Console.WriteLine("Ligou cafeteira 3 corações.");
        }

        public void DesligarTresCoracoes()
        {
            Console.WriteLine("Desligou cafeteira 3 corações.");
        }
    }
}
