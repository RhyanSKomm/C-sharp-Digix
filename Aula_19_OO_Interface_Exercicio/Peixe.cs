using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface_Exercicio
{
    public class Peixe : Animal,IAnimalDeEstimacao
    {
        
        private string _Nome;

        public Peixe(int pernas, string nome) : base(pernas)
        {
            _Nome = nome;
        }

        public string getNome()
        {
            return _Nome;
        }

        public void setNome(string nome)
        {
            _Nome = nome;
        }
        public void Brinca()
        {
            System.Console.WriteLine("Brincano");
        }

        public override void Come()
        {
            System.Console.WriteLine("Comeno");
        }
    }
}