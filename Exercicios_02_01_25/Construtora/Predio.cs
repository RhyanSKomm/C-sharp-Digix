using System;
using System.Collections.Generic;

namespace Exercicios_01_02_25
{
    public class Predio : Edificacao
        {
        private string? nome;
        private int numAndares;
        private int apPorAndar;

        public Predio(float metragemTotal, string endereco, Engenheiro responsavel, UnidadeResidencial[] unidades, string nome, int numAndares, int apPorAndar) 
            : base(metragemTotal, endereco, responsavel, unidades)
        {
            this.nome = nome;
            this.numAndares = numAndares;
            this.apPorAndar = apPorAndar;
        }

        public string? GetNome()
        {
            return nome;
        }

        public void SetNome(string nom)
        {
            nome = nom;
        }

        public int GetNumAndares()
        {
            return numAndares;
        }

        public void SetNumAndares(int nAnd)
        {
            numAndares = nAnd;
        }

        public int GetApPorAndar()
        {
            return apPorAndar;
        }

        public void SetApPorAndar(int nAp)
        {
            apPorAndar = nAp;
        }

        public override string DescricaoDoImovel()
        {
            string descricao = $"\nPredio {GetNome()}\nSituado a {GetEndereco()}\nArea total: {GetMetragemTotal()} metros quadrados\nResponsavel: Eng. {GetResponsavel().GetNome()} CREA {GetResponsavel().GetCrea()}\nNumero de Andares: {GetNumAndares()}\nNumero de Apartamentos por Andar: {GetApPorAndar()}";

            for (int i = 0; i < unidades.Length; i++)
            {
                if (unidades[i] != null)
                {
                    descricao += $"\nUnidade {i + 1}\nPropriedade de {unidades[i].GetProprietario()}\nPossui {unidades[i].GetMetragemUnidade()} metros quadrados, {unidades[i].GetNumQuartos()} quartos, {unidades[i].GetNumBanheiros()} banheiros.";
                }
            }

            return descricao;
        }
    }
}