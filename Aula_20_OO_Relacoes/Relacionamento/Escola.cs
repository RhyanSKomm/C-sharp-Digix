using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes
{
    public class Escola
    {
        private Aluno estudante;

        private Professor professor;

        public Escola(string nomeEstudante)
        {
            estudante = new Aluno(nomeEstudante);
        }

        public void ContratarProfessor(Professor professor)
        {
            this.professor = professor;
        }

        public void MostrarInfo()
        {
            System.Console.WriteLine($"Nome do Aluno: {estudante.Nome}");
            System.Console.WriteLine($"Nome do Professor: {professor.Nome}");
            professor.Ensinar();
        }
    }
}