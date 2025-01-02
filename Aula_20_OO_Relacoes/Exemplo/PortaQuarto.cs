using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_20_OO_Relacoes.Exemplo;

namespace Aula_20_OO_Relacoes.Exemplo
{
    public class PortaQuarto : Porta
    {
        public PortaQuarto (string cor, float largura, float altura, double peso) : base (cor,largura, altura,peso)
        {
        }

        public override void Abrir()
        {
            System.Console.WriteLine("Porta do quarto aberta");
        }

        public override void Fechar()
        {
            System.Console.WriteLine("Porta do quarto fechada");
        }
    }
}