using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes.Exemplo
{
    public class PortaSala : Porta
    {
        public PortaSala (string cor, float largura, float altura, double peso) : base (cor,largura, altura,peso)
        {
        }

        public override void Abrir()
        {
            System.Console.WriteLine("Porta da Sala aberta");
        }

        public override void Fechar()
        {
            System.Console.WriteLine("Porta da Sala fechada");
        }
    }
}