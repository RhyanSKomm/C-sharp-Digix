using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_OO_Encapsulamento
{
    public class ExecutarBanco
    {
        static void Main(string[] args)
        {
            Banco titular1 = new Banco(00001,"Rhyan");

            titular1.Depositar(1000);

            titular1.Sacar(200);

        }
    }
}