using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_07_01_25
{
    public interface IGerente 
    {
        public void autorizar();

        public bool concedeAumento();

        public bool autorizarLicenca(Empregado empregado);
    }
}