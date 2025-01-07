using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_07_01_25
{
    public class GerenteProducao : Empregado, IGerente
    {
        
        public GerenteProducao(double salario, int licencas, string nome, Cargo cargo) : base(salario, licencas, nome, cargo)
        {
        }

        public void autorizar()
        {
            Console.WriteLine("Gerente de Produção autorizando...");
        }

        public bool concedeAumento()
        {
            if (dSalario > dSalarioMinimo)
            {
                dSalario += 100.00;
                return true;
            }
            return false;
        }
        public double GetSalario()
        {
            return dSalario;
        }

        
        public bool autorizarLicenca(Empregado empregado)
        {
            if (empregado.GetLicencasPremioRecebidas() < 3)
            {
                empregado.setLicencasPremioRecebidas(1);
                return true;
            }
            return false;
        }
    }
}