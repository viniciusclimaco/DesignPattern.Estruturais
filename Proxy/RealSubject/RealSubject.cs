namespace Proxy.RealSubject
{
    public class RealSubject : Subject.Subject
    {
        public override void Sacar(decimal valor)
        {
            Console.WriteLine($"Saque realizado no valor: {valor}");
        }
    }
}


