using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_01_02_25
{
    public class Utilitarios : Veiculo
    {
        
        public Utilitarios(string placa, string modelo, double valorLocacao, float imposto) : base(placa, modelo, valorLocacao, imposto)
        {
        }

        public override double CalcularValorDiaria(int num)
        {
            return valorLocacao + (valorLocacao * imposto);
        }
    }
}