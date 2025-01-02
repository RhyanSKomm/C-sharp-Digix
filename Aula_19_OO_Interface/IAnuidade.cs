using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public interface IAnuidade
    {
        DateTime CalcularDataVencimento();

        double CalcularValorAnuidade();
    }
}