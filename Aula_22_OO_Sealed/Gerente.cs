using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_22_OO_Sealed
{
    public sealed class Gerente : Funcionario
    {
        public override void Salario(int salario)
        {
            System.Console.WriteLine("Salarário de gerente: " + salario * 1.5);
        }

        public override void Trabalhar()
        {
            System.Console.WriteLine("Gerente trabalhando...");
        }   
    }
}