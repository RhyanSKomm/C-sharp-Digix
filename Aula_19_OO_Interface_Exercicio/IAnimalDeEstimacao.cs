using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface_Exercicio
{
    public interface IAnimalDeEstimacao
    {
        string getNome();
        void setNome(string nome);

        void Brinca();
    }
}