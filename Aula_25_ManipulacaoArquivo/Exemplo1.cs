using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Aula_25_ManipulacaoArquivo
{
    public class Exemplo1
    {
        static void Main1(string[] args)
        {
            // File é uma classe static que contem metodos para manipulação de arquivos

            string inicioPath = @"C:\Users\rhyansantiago\Desktop\teste1.txt";

            string finalFile = @"C:\Users\rhyansantiago\Desktop\teste2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(inicioPath);
                fileInfo.CopyTo(finalFile);
                
                string[] line = File.ReadAllLines(inicioPath);
                foreach (string item in line)
                {
                    System.Console.WriteLine(item);
                }
            }
            catch (IOException e) // Tratamento de erro especifico para manipular arquivo
            {
                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}