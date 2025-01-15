using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula27ManipulacaoarquivoBinario
{
    public class Exemplo2
    {
        static void Main2(string[] args)
        {
            string filePath = "dados.bin";
            using(BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                int inteiro = reader.ReadInt32();
                double numeroReal = reader.ReadDouble();
                string texto = reader.ReadString();

                System.Console.WriteLine("Numero inteiro do arquivo: " + inteiro);
                System.Console.WriteLine("Numero inteiro do arquivo: " + numeroReal);
                System.Console.WriteLine("Texto do arquivo: " + texto);
            }    
        }
    }
}