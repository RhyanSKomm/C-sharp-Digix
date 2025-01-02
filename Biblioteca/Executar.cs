using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca("Biblio01");

            Funcionario func1 = new Funcionario ("Ana","123.456.789-00","Bibliotecária"); 
            Funcionario func2 = new Funcionario ("Carlos","987.654.321-00","Assistente"); 
            biblioteca.AdicionarFuncionario(func1); 
            biblioteca.AdicionarFuncionario(func2);


            Livro livro1 = new Livro ("O Senhor dos Anéis","J.R.R. Tolkien", 1954,5 ); 
            Livro livro2 = new Livro ("1984","George Orwell", 1949,3); 
            biblioteca.AdicionarLivro(livro1); 
            biblioteca.AdicionarLivro(livro2);

            Console.WriteLine("Funcionários da Biblioteca:"); 
            foreach (var func in biblioteca.ListaDeFuncionarios) 
            { 
                Console.WriteLine($"Nome: {func.Nome}, Cargo: {func.Cargo}");
            }

            Console.WriteLine("\nCatálogo de Livros:"); 
            foreach (var livro in biblioteca.Catalogo.Catalogo) 
            { 
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Exemplares Disponíveis: {livro.NumeroExemplares}"); 
            }
        }
    }
}