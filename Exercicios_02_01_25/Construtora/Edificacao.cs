using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_01_02_25
{
    public abstract class Edificacao
    {
        protected float metragemTotal;
        protected string? endereco;
        protected Engenheiro responsavel;
        protected UnidadeResidencial[] unidades;

        public Edificacao(float metragemTotal, string endereco, Engenheiro responsavel, UnidadeResidencial[] unidades)
        {
            this.metragemTotal = metragemTotal;
            this.endereco = endereco;
            this.responsavel = responsavel;
            this.unidades = unidades;
        }

        public float getMetragemTotal()
        {
            return metragemTotal;
        }

        public void setMetragemTotal(float met)
        {
            this.metragemTotal = met;
        }

        public string? getEndereco()
        {
            return endereco;
        }

        public void setEndereco(string end)
        {
            this.endereco = end;
        }

        public Engenheiro getResponsavel()
        {
            return responsavel;
        }

        public void setResponsavel(Engenheiro eng)
        {
            this.responsavel = eng;
        }

        public UnidadeResidencial[] getUnidades()
        {
            return unidades;
        }

        public bool cadastrarUnidade(UnidadeResidencial novaUni)
        {
            for (int i = 0; i < unidades.Length; i++)
            {
                if (unidades[i] == null)
                {
                    unidades[i] = novaUni;
                    return true;
                }
            }
            return false;
        }

        public abstract string DescricaoDoImovel();
    }
}