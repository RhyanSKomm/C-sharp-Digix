using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25_ManipulacaoArquivo
{
    public class Exemplo6
    {
        static void Main6(string[] args)
        {
            string inicioPath = @"C:\Users\rhyansantiago\Desktop\teste1.txt";

            System.Console.WriteLine("Directory Separator Char " + Path.DirectorySeparatorChar);

            System.Console.WriteLine("Separador de caminho " + Path.PathSeparator);

            System.Console.WriteLine("Retorna o diretorio do arquivo " + Path.GetDirectoryName(inicioPath));

            System.Console.WriteLine("Retorna o nome do arquivo " + Path.GetFileName(inicioPath));

            System.Console.WriteLine("Retorna o nome do arquivo sem extenção " + Path.GetFileNameWithoutExtension(inicioPath));

            System.Console.WriteLine("Retorna somente extenção do arquivo " + Path.GetExtension(inicioPath));
            
        }
    }
}