using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_01_02_25
{
    public class CasaTerrea : Casa
    {
        public CasaTerrea(float metragemTotal, string endereco, Engenheiro responsavel, UnidadeResidencial[] unidades, bool condominio) : base(metragemTotal, endereco, responsavel, unidades, condominio)
        {
            
        }
    }
}