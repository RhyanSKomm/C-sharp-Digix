using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Heranca
{
    public class Secretaria : Funcionario
    {
        public string Ramal;

        public Secretaria(string nome, string cpf, double salario,string ramal) : base(nome,cpf,salario)
        {
            this.Ramal = ramal;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.05;
        }

        public override void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"CPF: {CPF}");
            System.Console.WriteLine($"Salario: {Salario}");
            System.Console.WriteLine($"Setor: {Ramal}");
        }

        public void AtenderTelefone()
        {
            System.Console.WriteLine("Atendendo telefone");
        }
    }
}