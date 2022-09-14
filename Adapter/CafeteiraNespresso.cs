using Adapter.Domain;

namespace Adapter
{
    public class CafeteiraNespresso : ICafeteiraNespresso
    {        
        public void AquecerNespresso()
        {
            Console.WriteLine("Aquecendo cafeteira Nespresso.");
        }

        public void CafeProntoNespresso(Cooffe cooffe)
        {
            Console.WriteLine($"O {cooffe.Nome} está pronto.");
        }

        public void LigarNespresso()
        {
            Console.WriteLine("Ligou cafeteira Nespresso.");
        }

        public void DesligarNespresso()
        {
            Console.WriteLine("Desligou cafeteira Nespresso.");
        }
    }
}
