using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes.Exemplo
{
    public class Porta
    {
        public string Cor { get; set;}
        public float Largura { get; set;}
        public float Altura { get; set;}
        public double Peso { get; set;}

        public Porta(string cor, float largura, float altura, double peso)
        {
            Cor = cor;
            Largura = largura;
            Altura = altura;
            Peso = peso;
        }

        public virtual void Abrir()
        {
            System.Console.WriteLine("Porta aberta");
        }
        public virtual void Fechar()
        {
            System.Console.WriteLine("Porta fechada");
        }
    }
}