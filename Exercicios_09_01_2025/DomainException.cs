using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_09_01_2025
{
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}