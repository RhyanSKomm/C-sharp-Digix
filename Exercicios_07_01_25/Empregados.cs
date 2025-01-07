using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_07_01_25
{
    public class Empregados
    {
        private int iNumeroMaximo = 50;
        private Empregado[] empregados = new Empregado[50];
        private int iNumeroEmpregados;

        public Empregados(Empregado[] empregados, int numeroEmpregados)
        {
            this.empregados = empregados;
            this.iNumeroEmpregados = numeroEmpregados;
        }

        public void insere(double salario, int licencas, string nome, Cargo cargo)
        {
            if (iNumeroEmpregados < iNumeroMaximo)
            {
                empregados[iNumeroEmpregados] = new Empregado(salario, licencas, nome, cargo);
            }
            else
            {
                Console.WriteLine("Número máximo de empregados atingido.");
            }
        }

        public void imprime()
        {
            for (int i = 0; i < iNumeroEmpregados - 1; i++)
            {
                Console.WriteLine("\nNome: " + empregados[i].GetName());
                Console.WriteLine("Salário: " + empregados[i].GetSalario());
                Console.WriteLine("Licenças prêmio recebidas: " + empregados[i].GetLicencasPremioRecebidas());
                System.Console.WriteLine("Cargo: " + empregados[i].GetCargo());
            }
        }

        public void write(String write)
        {
            Console.WriteLine(write);
        }

        public void read(String read)
        {
            Console.WriteLine(read);
        }

        public void doFolhaPagamento()
        {
            for (int i = 0; i < iNumeroEmpregados; i++)
            {
                Console.WriteLine("Nome: " + empregados[i].GetName());
                Console.WriteLine("Salário: " + empregados[i].GetSalario());
                Console.WriteLine("Licenças prêmio recebidas: " + empregados[i].GetLicencasPremioRecebidas());
            }
        }
    }
}