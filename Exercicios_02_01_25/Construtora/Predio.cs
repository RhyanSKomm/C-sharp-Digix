using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_01_02_25
{
    public class Predio : Edificacao
    {
        private string? nome;
        private int numAndares;
        private int apPorAndar;

        public Predio(float metragemTotal, string endereco, Engenheiro responsavel, UnidadeResidencial[] unidades, string nome, int numAndares, int apPorAndar) : base(metragemTotal, endereco, responsavel, unidades)
        {
            this.nome = nome;
            this.numAndares = numAndares;
            this.apPorAndar = apPorAndar;
        }

        public string? getNome()
        {
            return nome;
        }

        public void setNome(string nom)
        {
            this.nome = nom;
        }

        public int getNumAndares()
        {
            return numAndares;
        }

        public void setNumAndares(int nAnd)
        {
            this.numAndares = nAnd;
        }

        public int getApPorAndar()
        {
            return apPorAndar;
        }

        public void setApPorAndar(int nAp)
        {
            this.apPorAndar = nAp;
        }

        public override string DescricaoDoImovel()
        {
            return $"\nPredio {getNome()}.\nSituado a {getEndereco()}.\nArea total: {getMetragemTotal()} metros quadrados.\nResponsavel: Eng. {getResponsavel()}. CREA {responsavel.getCrea()}.\nNumero de Andares: {getNumAndares()}.\nNumero de Apartamentos por Andar: {getApPorAndar}.\nUnidade 1\nPropriedade de {unidades[1].getProprietario}.\nPossui {unidades[1].getMetragemUnidade} metros quadrados, {unidades[1].getNumQuartos} quartos, {unidades[1].getNumBanheiros} banheiros.\nUnidade 2\nPropriedade de {unidades[2].getProprietario}.\nPossui {unidades[2].getMetragemUnidade} metros quadrados, {unidades[2].getNumQuartos} quartos, {unidades[2].getNumBanheiros} banheiros.\nUnidade 3\nPropriedade de {unidades[3].getProprietario}.\nPossui {unidades[3].getMetragemUnidade} metros quadrados, {unidades[3].getNumQuartos} quartos, {unidades[3].getNumBanheiros} banheiros.";
        }
    }
}