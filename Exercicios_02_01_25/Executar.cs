using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_01_02_25
{
    public class Executar
    {
        static void Main(string[] args)
        {

            // Exercicio 01
            // Homem homem = new Homem();
            // Cao cao = new Cao();
            // Mosca mosca = new Mosca();

            // homem.obterDescricao();
            // cao.obterDescricao();
            // mosca.obterDescricao();

            // Exercicio 02
            

            //exercicio 03
            Veiculo caminhao = new Caminhao("ABC1234", "Caminhão X", 200, 50, 3); 
            Veiculo categoriaA = new CarroDePasseio("DEF5678", "Carro A", 100, 20); 
            Veiculo moto = new Moto("GHI9012", "Moto Y", 80, 10, 250); 
            Console.WriteLine($"Valor diária do caminhão: {caminhao.CalcularValorDiaria(4)}"); 
            Console.WriteLine($"Valor diária do carro categoria A: {categoriaA.CalcularValorDiaria(0)}"); 
            Console.WriteLine($"Valor diária da moto: {moto.CalcularValorDiaria(300)}");
        }
    }
}