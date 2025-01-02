using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_01_02_25
{
    public class Mosca : Musca_domestica
    {
        public override void obterDescricao()
        {
            System.Console.WriteLine("\nReino Animalia\nFilo Arthropoda\nClasse Insecta\nOrdem Diptera\nFamília Muscidae\nGênero Musca\nEspécie Musca domestica");
        }
    }
}