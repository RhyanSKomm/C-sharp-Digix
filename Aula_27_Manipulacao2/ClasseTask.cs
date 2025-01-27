using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Aula_27_Manipulacao2
{
    public class ClasseTask
    {
        static async Task Main1(string[] args)
        {
            System.Console.WriteLine("Inicio do programa");
            int resultado = await Soma(10,20);
            System.Console.WriteLine("Resultado " + resultado);
        }

        static Task<int> Soma(int a, int b)
        {
            return  Task.Run(() => {
                Task.Delay(2000).Wait();
                return a + b;
            });
        }
    }
}