using Proxy.Domain;

namespace Proxy.Proxy
{
    public class Proxy : Subject.Subject
    {
        List<User> users;
        User loggedUser;
        Subject.Subject subject;
        public Proxy(User user)
        {
            users = new List<User>() { new User() { Name = "Climaco", Id = 1 }, { new User() { Id = 2, Name = "Miguel" }}};
            loggedUser = user;
        }

        public override void Sacar(decimal valor)
        {
            if (users.Exists(c => c.Name == loggedUser.Name))
            {
                if (subject == null)
                    subject = new RealSubject.RealSubject();
                subject.Sacar(valor);
            }
            else            
                Console.WriteLine("Usuário não permitido.");
        }
    }
}

