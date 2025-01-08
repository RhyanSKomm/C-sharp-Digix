using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_23_OO_Excessao.Resolucao_3;

namespace Aula_23_OO_Excessao
{
    public class Executar3
    {
        static void Maina(string[] args)
        {
            System.Console.WriteLine("Entre com os dados Room Number");
            int roomNumber = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com a data de Check-out (dd/MM/yyyy)");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation3 reservation3 = new Reservation3(roomNumber, checkIn, checkOut);
            System.Console.WriteLine("Reserva: " + reservation3);
            

            System.Console.WriteLine("Escreva os dados para atualizar a reserva: ");
            System.Console.WriteLine("Entre coma a data de Check-in (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Entre com a data de Check-out (dd/MM/yyyy)");
            checkOut = DateTime.Parse(Console.ReadLine());

            reservation3.UpdateDates(checkIn, checkOut, roomNumber);
            System.Console.WriteLine("Reserva atualizada: " + reservation3);
        }
    }
}