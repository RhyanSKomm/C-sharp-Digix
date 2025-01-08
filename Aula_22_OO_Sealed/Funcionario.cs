using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_22_OO_Sealed
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public virtual void Salario(int salario)
        {
            System.Console.WriteLine("Salarário vase: " + salario);
        }

        public virtual void Trabalhar()
        
        {
            System.Console.WriteLine("Trabalhando...");
        }
    }
}