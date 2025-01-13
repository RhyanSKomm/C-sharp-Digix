using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using ClosedXML.Excel;
using Aula_25_ManipulacaoArquivo.Banco;

namespace Aula_25_ManipulacaoArquivo
{
    public class ExecutarBanco
    {
        static void Main(string[] args)
        {
            var cliente = new Customer("João de Deus");
            var contaCorrente = new CurrentAccount(1234, cliente, 500);
            var contaPoupanca = new SavingAccount(4321, cliente, 0.01);

            contaCorrente.Depositar(100);
            contaCorrente.Sacar(200);

            contaPoupanca.Depositar(500);
            contaPoupanca.AplicarRendimento();

            GerarExcel(new List<Account> {contaCorrente, contaPoupanca});
        }
        public static void GerarExcel(List<Account> contas)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.AddWorksheet("Contas Bancarias");

                worksheet.Cell(1,1).Value = "Numero da Conta";
                worksheet.Cell(1,2).Value = "Numero do Cliente";
                worksheet.Cell(1,3).Value = "Tipo da Conta";
                worksheet.Cell(1,4).Value = "Saldo";

                int row = 2;
                foreach (var item in contas)
                {
                    worksheet.Cell(row, 1).Value = item.NumeroConta;
                    worksheet.Cell(row, 2).Value = item.Cliente.Nome;
                    worksheet.Cell(row, 3).Value = item.TipoConta.ToString();
                    worksheet.Cell(row, 4).Value = item.Saldo;
                    row++;
                }

                workbook.SaveAs("ContasBancarias.xlsx");
                System.Console.WriteLine("Arquivo excel gerado com sucesso");
            }
        }
    }

}