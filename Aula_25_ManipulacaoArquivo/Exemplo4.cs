using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25_ManipulacaoArquivo
{
    public class Exemplo4
    {
        static void Main4(string[] args)
        {
            string inicioPath = @"C:\Users\rhyansantiago\Desktop\teste1.txt";
            string finalPath = @"C:\Users\rhyansantiago\Desktop\teste2.txt";

            try
            {
                string[] lines = File.ReadAllLines(inicioPath);
                
                using (StreamWriter sw = new StreamWriter(finalPath, false))
                {
                    foreach (string item in lines)
                    {
                        sw.WriteLine(item.ToUpper());
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