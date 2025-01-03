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
            string descricao = $"\nPredio {GetNome()}\nSituado a {GetEndereco()}\nArea total: {GetMetragemTotal()} metros quadrados\nResponsavel: Eng. {responsavel.getNome()} CREA {responsavel.getCrea()}\nNumero de Andares: {GetNumAndares()}\nNumero de Apartamentos por Andar: {GetApPorAndar()}";

            for (int i = 0; i < unidades.Length; i++)
            {
                if (unidades[i] != null)
                {
                    descricao += $"\nUnidade {i + 1}\nPropriedade de {unidades[i].getProprietario()}\nPossui {unidades[i].getMetragemUnidade()} metros quadrados, {unidades[i].getNumQuartos()} quartos, {unidades[i].getNumBanheiros()} banheiros.";
                }
            }

            return descricao;
        }
    }
}