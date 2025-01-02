using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro
    {
        public string Titulo {get;set;}
        public string Autor {get;set;}
        public int AnoPublicacao {get;set;}
        public int NumeroExemplares {get;set;}

        public Livro(string titulo, string autor, int anoPublicacao, int numeroExemplares)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            NumeroExemplares = numeroExemplares;        }
    }
}