using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public class Executar
    {
        static void Main(string[] args)
        {
            CartaoCredito cartao = new CartaoCredito("1234 5678 9012 3456", DateTime.Now, 100);
            cartao.RealizarPagamento(500);
            cartao.ExibirComprovante();
        }
    }
}