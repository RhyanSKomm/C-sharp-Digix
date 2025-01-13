using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25_ManipulacaoArquivo
{
    public class Exemplo3
    {
        static void Main3(string[] args)
        {
            string inicioPath = @"C:\Users\rhyansantiago\Desktop\teste1.txt";

            try
            {
                using (FileStream fs = new FileStream(inicioPath, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();
                        System.Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}