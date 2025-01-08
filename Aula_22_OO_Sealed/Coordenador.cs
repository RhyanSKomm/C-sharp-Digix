using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_22_OO_Sealed
{
    public class Coordenador : Funcionario
    {
        public override void Salario(int salario)
        {
            System.Console.WriteLine("Salarário de coordenador: " + salario * 1.3);
        }

        public override void Trabalhar()
        {
            System.Console.WriteLine("Coordenador trabalhando...");
        }
    }
}