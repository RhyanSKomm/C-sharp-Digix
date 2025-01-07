using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_07_01_25
{
    public class Empregado : Pessoa
    {
        protected double dSalario;
        protected double dSalarioMinimo = 240.00;
        protected int iLicencasPremioRecebidas;
        protected Cargo cargo;

        public Empregado(double salario, int licencas, string nome, Cargo cargo) : base(nome)
        {
            this.dSalario = salario;
            this.iLicencasPremioRecebidas = licencas;
            this.cargo = cargo;
        }

        public double GetSalario()
        {
            return dSalario;
        }

        public int GetLicencasPremioRecebidas()
        {
            return iLicencasPremioRecebidas;
        }

        public void SetSalario(double salario)
        {
            this.dSalario = salario;
        }

        public void setLicencasPremioRecebidas(int licencas)
        {
            this.iLicencasPremioRecebidas += licencas;
        }

        public void SetCargo(Cargo cargo)
        {
            this.cargo = cargo;
        }

        public Cargo GetCargo()
        {
            return cargo;
        }
    }
}