using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class Vendedor : Funcionario, ICalculavel
    {
        public double MontanteVendas { get; set; }
        public double MetaVendas { get; set; }

        public Vendedor(string nome, int codigo, string endereco, string cpf, string telefone, double salarioBase, double metaVendas, double montanteVendas)
            : base(nome, codigo, endereco, cpf, telefone, salarioBase)
        {
            MetaVendas = metaVendas;
            MontanteVendas = montanteVendas;
        }

        public override double CalcularSalario()
        {
            return MontanteVendas > MetaVendas ? SalarioBase * 1.1 : SalarioBase;
        }
    }

}