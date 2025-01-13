using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25_ManipulacaoArquivo
{
    public class Exemplo5
    {
        static void Main5(string[] args)
        {
            string path = @"C:\Users\rhyansantiago\Desktop\teste";

            try
            {
                IEnumerable<string> pastas = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                System.Console.WriteLine("Pastas: ");
                foreach (string item in pastas)
                {
                    System.Console.WriteLine(item);
                }



                IEnumerable<string> arquivos = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                foreach (string item in arquivos)
                {
                    System.Console.WriteLine(item);
                }

                Directory.CreateDirectory(path + @"\Teste2");

                Directory.Delete(path + @"\teste2");

                bool existe = Directory.Exists(path + @"\Teste1");
                System.Console.WriteLine("A pasta existe: " + existe);
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}