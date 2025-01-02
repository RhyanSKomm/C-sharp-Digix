using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_01_02_25
{
    public class Moto : Veiculo
    {
        public int cilindradas = 125;

        public Moto(string placa, string modelo, double valorLocacao, float imposto, int cilindradas) : base(placa, modelo, valorLocacao, imposto)
        {
            this.cilindradas = cilindradas;
        }

        public override double CalcularValorDiaria(int cilindradas)
        {
            return valorLocacao + (valorLocacao * imposto) + (cilindradas * 0.5);
        }
    }
}