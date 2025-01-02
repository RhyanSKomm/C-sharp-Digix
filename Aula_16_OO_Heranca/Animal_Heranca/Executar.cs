using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Heranca.Heranca_Animal
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Cobra cobra = new Cobra(true,false);
            cobra.alimento("Roedor");
            System.Console.WriteLine(cobra.setVenenosa(true));

            Javali javali = new Javali(true,false);
            System.Console.WriteLine(javali.GetVelocidadeMaxima());
            javali.setSelvagem(true);
        }
    }
}