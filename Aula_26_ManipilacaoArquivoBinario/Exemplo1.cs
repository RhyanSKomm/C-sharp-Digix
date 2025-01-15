using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_26_ManipilacaoArquivoBinario
{
    public class Exemplo1
    {
        static void Main1(string[] args)
        {
            string filePath = "dados.bin";

            using(BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(123);
                writer.Write(45.3546);
                writer.Write("Hello World");
            }

            System.Console.WriteLine("Dados gravados no: " + filePath);
        }
    }
}