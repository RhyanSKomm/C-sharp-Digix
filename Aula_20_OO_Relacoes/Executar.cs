using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes.Exemplo
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Escola escola = new Escola("João");

            // Professor professor = new Professor("Maria");

            // escola.ContratarProfessor(professor);

            // escola.MostrarInfo();

            System.Console.WriteLine("Herança");
            PortaCozinha portaCozinha = new PortaCozinha("Branca", 1.5f, 2.5f,10);
            portaCozinha.Abrir();
            portaCozinha.Fechar();
            System.Console.WriteLine($"PortaCozinha: Cor: {portaCozinha.Cor}, Largura: {portaCozinha.Largura}, Altura: {portaCozinha.Altura}, Peso: {portaCozinha.Peso}");

            System.Console.WriteLine("Agragação");
            Cozinha cozinha = new Cozinha(true,20);
            cozinha.Entrar(portaCozinha);

            System.Console.WriteLine("Composição");
            PortaQuarto portaQuarto = new PortaQuarto("Marrom", 1.5f, 2.5f,10);
            Quarto quarto = new Quarto(true,20);
            System.Console.WriteLine($"quarto: {quarto.PortaQuarto.Cor}");
            

            System.Console.WriteLine("Associação Simples");
            PortaSala portaSala = new PortaSala("Azul", 1.5f, 2.5f,10);
            Sala sala = new Sala(portaSala,portaQuarto,20);
            sala.AbrirPortaAuxiliar();
        }
    }
}