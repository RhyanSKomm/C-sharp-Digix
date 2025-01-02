using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class Gerente : Funcionario, ICalculavel
    {
        public Gerente(string nome, int codigo, string endereco, string cpf, string telefone, double salarioBase): base(nome, codigo, endereco, cpf, telefone, salarioBase) { 

        }

        public double CalcularSalario()
        {
            return SalarioBase * 1.2;
        }
    }
}