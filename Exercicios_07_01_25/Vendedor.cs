using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_07_01_25
{
    public class Vendedor : Empregado
    {
        protected double dComissao;

        public Vendedor(double salario, int licencas, string nome, Cargo cargo, double comissao) : base(salario, licencas, nome, cargo)
        {
            this.dComissao = comissao;
        }

        public double GetSalario()
        {
            return dSalario + dComissao;
        }
    }
}