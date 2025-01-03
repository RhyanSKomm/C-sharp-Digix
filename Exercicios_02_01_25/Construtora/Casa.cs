using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_01_02_25
{
    public class Casa : Edificacao
    {
        protected bool condominio;

        public Casa(float metragemTotal, string endereco, Engenheiro responsavel, UnidadeResidencial[] unidades, bool condominio) : base(metragemTotal, endereco, responsavel, unidades)
        {
            this.condominio = condominio;
        }

        public bool getCondominio()
        {
            return condominio;
        }

        public void setCondominio(bool cond)
        {
            condominio = cond;
        }

        public override string DescricaoDoImovel()
        {
            if (condominio)
            {
                return $"\nCasa em Condominio.\nSituado a {GetEndereco()}.\nArea total: {this.GetMetragemTotal()} metros quadrados.\nResponsavel: Eng. {this.GetResponsavel()}. CREA {this.responsavel.getCrea()}.\nUnidade 1\nPropriedade de {this.unidades[1].getProprietario}.\nPossui {this.unidades[1].getMetragemUnidade} metros quadrados, {this.unidades[1].getNumQuartos} quartos, {this.unidades[1].getNumBanheiros} banheiros.\nUnidade 2\nPropriedade de {this.unidades[2].getProprietario}.\nPossui {this.unidades[2].getMetragemUnidade} metros quadrados, {this.unidades[2].getNumQuartos} quartos, {this.unidades[2].getNumBanheiros} banheiros.\nUnidade 3\nPropriedade de {this.unidades[3].getProprietario}.\nPossui {this.unidades[3].getMetragemUnidade} metros quadrados, {this.unidades[3].getNumQuartos} quartos, {this.unidades[3].getNumBanheiros} banheiros.";
            }
            else
            {
                return $"\nCasa.\nSituado a {this.GetEndereco()}.\nArea total: {this.GetMetragemTotal()} metros quadrados.\nResponsavel: Eng. {this.GetResponsavel()}. CREA {this.responsavel.getCrea()}.\nUnidade 1\nPropriedade de {this.unidades[1].getProprietario}.\nPossui {this.unidades[1].getMetragemUnidade} metros quadrados, {this.unidades[1].getNumQuartos} quartos, {this.unidades[1].getNumBanheiros} banheiros.\nUnidade 2\nPropriedade de {this.unidades[2].getProprietario}.\nPossui {this.unidades[2].getMetragemUnidade} metros quadrados, {this.unidades[2].getNumQuartos} quartos, {this.unidades[2].getNumBanheiros} banheiros.\nUnidade 3\nPropriedade de {this.unidades[3]}.";
            }
        }
    }  
}
