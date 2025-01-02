using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_01_02_25
{
    public class UnidadeResidencial
    {
        protected float metragemUnidade;
        protected int numQuartos;
        protected int numBanheiros;
        protected Pessoa proprietario;

        public UnidadeResidencial(float metragemUnidade, int numQuartos, int numBanheiros, Pessoa proprietario)
        {
            this.metragemUnidade = metragemUnidade;
            this.numQuartos = numQuartos;
            this.numBanheiros = numBanheiros;
            this.proprietario = proprietario;
        }

        public float getMetragemUnidade()
        {
            return metragemUnidade;
        }

        public void setMetragemUnidade(float metragem)
        {
            this.metragemUnidade = metragem;
        }

        public int getNumQuartos()
        {
            return numQuartos;
        }

        public void setNumQuartos(int nQuartos)
        {
            this.numQuartos = nQuartos;
        }

        public int getNumBanheiros()
        {
            return numBanheiros;
        }

        public void setNumBanheiros(int nBan)
        {
            this.numBanheiros = nBan;
        }

        public Pessoa getProprietario()
        {
            return proprietario;
        }

        public void setProprietario(Pessoa prop)
        {
            this.proprietario = prop;
        }
    }
}