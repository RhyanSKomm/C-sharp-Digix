using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Leitores : Usuario
    {
        public Biblioteca Biblioteca { get; set; }
         public Leitores(string nome,string cpf, Biblioteca biblioteca) : base(nome, cpf)
        {
            Biblioteca = biblioteca;
        }

        public CatalogoDeLivros ObterCatalogo()
        {
            return Biblioteca.Catalogo; 
        }
    }
}