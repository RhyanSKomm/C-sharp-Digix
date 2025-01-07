using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Exercicios_07_01_25
{
    public class Pessoa
    {
        protected string sName;

        public Pessoa()
        {
        }

        public Pessoa(string nome)
        {
            this.sName = nome;
        }

        public void SetName(string nome)
        {
            this.sName = nome;
        }
        
        public string GetName()
        {
            return sName;
        }

    }
}