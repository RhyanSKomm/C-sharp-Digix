using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Heranca.Heranca_Animal
{
    public class Cobra : Animal
    {
        public bool venonosa;

        public Cobra(bool vivo, bool venenosa) : base (vivo)
        {
            this.venonosa = venenosa;
        }

        public void alimento(string a)
        {
            System.Console.WriteLine($"A cobra comeu um(a): {a}");
        }

        public bool setVenenosa(bool v)
        {
            if (v == true)
                System.Console.WriteLine("Cobra venenosa");
            else
                System.Console.WriteLine("Cobra não venenosa");
            return venonosa = v;
            
        }
    }
}