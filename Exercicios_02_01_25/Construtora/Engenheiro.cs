using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_01_02_25
{
    public class Engenheiro : Pessoa
    {
        private int crea;

        public Engenheiro(string nome, string cpf, int crea) : base(nome, cpf)
        {
            this.crea = crea;
        }
        

        public int getCrea()
        {
            return crea;
        }

        public void setCrea(int crea)
        {
            this.crea = crea;
        }
        
    }
}