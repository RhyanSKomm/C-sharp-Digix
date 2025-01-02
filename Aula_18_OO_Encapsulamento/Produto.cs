using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_OO_Encapsulamento
{
    public class Produto
    {
        // private string _nome; //Convençao C#
        //Propriedade autoimplementada
        public string Nome { get; set; }
        private double _preco;
        private int _quantidade;

        //Construtor padrão
        public Produto()
        {
        }

        //Construtor com 2 argumentos
        public Produto(string nome, double preco)
        {
            Nome = nome;
            _preco = preco;
        }

        //Reutilizando construtor dentro de outro
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        //Encapsulamento, Get(retornar) e Set(alterar) de atributos privados
        // public string GetNome()
        // {
        //     return _nome;
        // }

        // public void SetNome(string nome)
        // {
        //     if(nome != null && nome.Length > 1)
        //     {
        //         _nome = nome;
        //     }
        // }
        // public string Nome
        // {
        //     get { return _nome; }
        //     set
        //     {
        //         //O value é o valor que está sendo passado, não precisa declarar.
        //         if (value != null && value.Length > 1)
        //         {
        //             _nome = value;
        //         }
        //     }
        // }
        // public double GetPreco()
        // {
        //     return _preco;
        // }

        // public void SetPreco(double preco)
        // {
        //     if(preco > 0 && preco < 100000)
        //     {
        //         _preco = preco;
        //     }
        // }


        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value > 0 && value < 100000)
                {
                    _preco = value;
                }
            }
        }

        // public double GetQuantidade()
        // {
        //     return _quantidade;
        // }

        // public void SetQuantidade(int quantidade)
        // {
        //     _quantidade = quantidade;
        // }


        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                _quantidade = value;
            }
        }

        public void RemoverProdutos(int quantidade)
        {
            if(_quantidade <= 0)
            {
                _quantidade -= quantidade;
            }
            else{
                System.Console.WriteLine("Produto sem estoque!");
            }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + _preco.ToString("F2") + ", " + _quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2");
        }
    }
}