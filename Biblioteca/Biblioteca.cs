using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biblioteca
    {
        string Nome {get;set;}
        public CatalogoDeLivros Catalogo{get;set;}
        public List<Funcionario> ListaDeFuncionarios { get; set; } = new List<Funcionario>();

        public Biblioteca(string nome)
        {
            Nome = nome;
            this.Catalogo = new CatalogoDeLivros();
        }

        public void AdicionarLivro(Livro livro) 
        { 
            this.Catalogo.Catalogo.Add(livro);
        }

        public void RemoverLivro(Livro livro) 
        {
             Catalogo.Catalogo.Remove(livro);
        }

        public void AdicionarFuncionario(Funcionario funcionario) 
        { 
            ListaDeFuncionarios.Add(funcionario);
        }

        public void RemoverFuncionario(Funcionario funcionario) 
        { 
            ListaDeFuncionarios.Remove(funcionario);
        }
    }
}