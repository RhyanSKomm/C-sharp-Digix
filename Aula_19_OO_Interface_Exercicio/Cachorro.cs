using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface_Exercicio
{
    public class Cachorro : Animal, IAnimalDeEstimacao
    {
        
        private string _Nome;

        public Cachorro(int pernas) : base(pernas)
        {
        }

        public Cachorro(string nome) : base(5)
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