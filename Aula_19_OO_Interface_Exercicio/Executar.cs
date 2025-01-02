using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface_Exercicio
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro ("Rex");
            cachorro.Come();
        }
    }
}