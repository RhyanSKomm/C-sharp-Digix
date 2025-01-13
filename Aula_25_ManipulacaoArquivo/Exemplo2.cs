using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25_ManipulacaoArquivo
{
    public class Exemplo2
    {
        static void Main2(string[] args)
        {
            string inicioPath = @"C:\Users\rhyansantiago\Desktop\teste1.txt";
            FileStream fs = null; // Essa é uma classe que permite leitura e escrita de arquivos, classe de baixo de nível.
            StreamReader sr = null; //Também classe de manipulação, mas de alto nível
            
            try
            {
                fs = new FileStream(inicioPath, FileMode.Open);
                
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                System.Console.WriteLine(line);
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}