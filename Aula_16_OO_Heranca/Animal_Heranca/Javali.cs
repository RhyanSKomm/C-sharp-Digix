using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Heranca.Heranca_Animal
{
    public class Javali : Animal
    {
        public bool selvagem;

        public Javali(bool vivo, bool selvagem) : base (vivo)
        {
            this.selvagem = selvagem;
        }

        public int GetVelocidadeMaxima()
        {
            return 100;
        }

        public bool setSelvagem(bool s)
        {
            if (s == true)
                System.Console.WriteLine("Javali selvagem");
            else
                System.Console.WriteLine("Javali não selvagem");
            return selvagem = s;
        }
    }
}