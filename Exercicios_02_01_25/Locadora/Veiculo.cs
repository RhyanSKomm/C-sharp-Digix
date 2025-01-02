using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_01_02_25
{
    public abstract class Veiculo
    {
        public string placa;
        public string modelo;
        public double valorLocacao;
        public float imposto;

        public Veiculo(string placa, string modelo, double valorLocacao, float imposto)
        {
            this.placa = placa;
            this.modelo = modelo;
            this.valorLocacao = valorLocacao;
            this.imposto = imposto;
        }

        public abstract double CalcularValorDiaria(int num);
    }
}