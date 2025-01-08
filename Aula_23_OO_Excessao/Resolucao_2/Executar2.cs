using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_23_OO_Excessao.Resolucao_2;

namespace Aula_23_OO_Excessao
{
    public class Executar2
    {
        static void Maina(string[] args)
        {
            System.Console.WriteLine("Entre com os dados Room Number");
            int roomNumber = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com a data de Check-out (dd/MM/yyyy)");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation2 reservation2 = new Reservation2(roomNumber, checkIn, checkOut);

            string error = reservation2.UpdateDates(checkIn, checkOut);
            if (error != null)
            {
                System.Console.WriteLine(error);
            }
            else
            {
                System.Console.WriteLine("Reserva: " + reservation2);
            }
        }
    }
}