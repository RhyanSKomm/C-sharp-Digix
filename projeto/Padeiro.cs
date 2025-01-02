using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class Padeiro : Funcionario, ICalculavel
    {
        public int HorasNoturnas {get; set;}

        public Vendedor(string nome, int codigo, string endereco, string cpf, string telefone, double salarioBase, int horasNoturnas) : base (nome, codigo, endereco, cpf, telefone, salarioBase)
        {
            Nome = nome;
            Codigo = codigo;
            Endereco = endereco;
            CPF = cpf;
            Telefone = telefone;
            SalarioBase = salarioBase;
            HorasNoturnas = horasNoturnas;
        }

        public double CalcularSalario()
        {
            return SalarioBase + ((SalarioBase*0.25)*HorasNoturnas);
        }
    }
}