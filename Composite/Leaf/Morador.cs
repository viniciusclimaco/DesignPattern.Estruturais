using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Leaf
{
    public class Morador : Component.Component
    {
        public Morador(string nome) : base(nome)
        {
        }

        public override void Exibir()
        {
            Console.WriteLine($"Morador: {Nome}");
        }
    }
}
