using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_01_02_25
{
    public class CasaSobrado : Casa
    {
        private int numAndares;

        public CasaSobrado(float metragemTotal, string endereco, Engenheiro responsavel, UnidadeResidencial[] unidades, bool condominio, int numAndares) : base(metragemTotal, endereco, responsavel, unidades, condominio)
        {
            this.numAndares = numAndares;
        }

        public int getNumAndares()
        {
            return numAndares;
        }

        public void setNumAndares(int nAnd)
        {
            this.numAndares = nAnd;
        }
    }
}