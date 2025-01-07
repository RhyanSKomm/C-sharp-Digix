using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_07_01_25
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Empregado empregado = new Empregado(1000, 2, "João", Cargo.Vendedor);
            Vendedor vendedor = new Vendedor(1000, 2, "Maria",Cargo.Vendedor, 100);
            GerenteProducao gerente = new GerenteProducao(1000, 2, "José", Cargo.GerenteProducao);
            Empregado empregado2 = new Vendedor(1000, 2, "Pedro", Cargo.Vendedor, 100);
            Vendedor vendedor2 = new Vendedor(1000, 2, "Ana", Cargo.Vendedor, 100);
            GerenteVendas gerente2 = new GerenteVendas(1000, 2, "Marta", Cargo.GerenteVendas, 100, Regiao.MS);



            List<Empregado> listaEmpregados = new List<Empregado> 
            {
                empregado,
                vendedor,
                gerente,
                empregado2,
                vendedor2,
                gerente2
            };
            Empregado[] vetorEmpregados = listaEmpregados.ToArray();
            Empregados empregados = new Empregados(vetorEmpregados, 7);

            empregados.imprime();
            

        }
    }
}