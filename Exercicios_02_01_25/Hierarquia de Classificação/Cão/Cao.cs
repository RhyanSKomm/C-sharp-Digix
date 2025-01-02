using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_01_02_25
{
    public class Cao : Canis_Familiaris
    {
        public override void obterDescricao()
        {
            System.Console.WriteLine("\nReino Animalia\nFilo Chordata\nClasse Mammalia\nOrdem Carnivora\nFamília Canidae\nGênero Canis\nEspécie Canis familiaris");
        }
    }
}