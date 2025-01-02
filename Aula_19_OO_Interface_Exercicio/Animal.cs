using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface_Exercicio
{
    public class Animal
    {
        protected int Pernas = 0;

        public Animal(int pernas)
        {
            Pernas = pernas;
        }

        public virtual void Caminha()
        {
            System.Console.WriteLine("Caminhano");
        }

        public virtual void Come()
        {
            System.Console.WriteLine("Comeno");
        }
    }
}