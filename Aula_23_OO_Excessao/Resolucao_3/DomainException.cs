using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Excessao.Resolucao_3
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}