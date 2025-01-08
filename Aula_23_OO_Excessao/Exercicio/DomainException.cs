using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Excessao.Exercicio
{
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}