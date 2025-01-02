using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_01_02_25
{
    public class Caminhao : Veiculo
    {
        public int numEixos;

        public Caminhao(string placa, string modelo, double valorLocacao, float imposto, int numEixos) : base(placa, modelo, valorLocacao, imposto)
        {
            this.numEixos = numEixos;
        }

        public override double CalcularValorDiaria(int numEixos)
        {
            return valorLocacao + (valorLocacao * imposto) + (numEixos * 100);
        }
    }
}