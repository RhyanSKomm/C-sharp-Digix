using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Relacoes.Composicao
{
    public class Computador
    {
        public Processador processador;

        public Computador()
        {
            processador = new Processador();
        }

        public void iniciar()
        {
            System.Console.WriteLine("Iniciando...");
            processador.Processar();
        }
    }
}