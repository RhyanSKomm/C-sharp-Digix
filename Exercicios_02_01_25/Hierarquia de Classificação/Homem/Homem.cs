using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_01_02_25
{
    public class Homem : Homo_sapiens
    {
        public override void obterDescricao()
        {
            System.Console.WriteLine("\nReino Animalia\nFilo Chordata\nClasse Mammalia\nOrdem Primata\nFamília Hominidae\nGênero Homo\nEspécie Homo sapiens");
        }
    }
}