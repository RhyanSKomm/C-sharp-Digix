using System;
using System.Collections.Generic;

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

        public float GetMetragemTotal()
        {
            return metragemTotal;
        }

        public void SetMetragemTotal(float met)
        {
            metragemTotal = met;
        }

        public string? GetEndereco()
        {
            return endereco;
        }

        public void SetEndereco(string end)
        {
            endereco = end;
        }

        public Engenheiro GetResponsavel()
        {
            return responsavel;
        }

        public void SetResponsavel(Engenheiro eng)
        {
            responsavel = eng;
        }

        public UnidadeResidencial[] GetUnidades()
        {
            return unidades;
        }

        public bool CadastrarUnidade(UnidadeResidencial novaUni)
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