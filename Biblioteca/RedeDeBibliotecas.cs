using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class RedeDeBibliotecas
    {
        List<Biblioteca> ListaDeBiblioteca {get;set;} = new List<Biblioteca>();

        public void AdicionarBiblioteca(Biblioteca biblioteca)
        {
            ListaDeBiblioteca.Add(biblioteca);
        }
        public void RemoverBiblioteca(Biblioteca biblioteca)
        {
            ListaDeBiblioteca.Remove(biblioteca);
        }
    }
}