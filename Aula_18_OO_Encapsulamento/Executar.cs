using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Aula_18_OO_Encapsulamento
{
    public class Executar
    {
        static void Mainq(string[] args)
        {
            Produto p = new Produto("Bomba Atomica", 10000);
            
            // p.SetNome("Bomba Nuclear");
            p.Nome = "Bomba Nuclear";
            p.Preco = 20000;
            p.Quantidade = 10;

            // System.Console.WriteLine("Nome: " + p.Nome + " Preço: " + p.Preco + " Quantidade: " + p.Quantidade);

            // //Imprimir pelo ToString
            // System.Console.WriteLine(p.ToString());

            Type t = typeof(Produto);
            System.Console.WriteLine(t.Name); 

            System.Console.WriteLine("Propriedade: ");
            foreach (PropertyInfo prop in t.GetProperties())
            {
                System.Console.WriteLine(prop.Name);
            }
        }
    }
}