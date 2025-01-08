using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_23_OO_Excessao.Resolucao_1;

namespace Aula24Excessoes
{
    public class Executar1
    {
        static void Maina(string[] args)
        {
            System.Console.WriteLine("Entre com os dados Room Number");
            int roomNumber = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com a data de Check-out (dd/MM/yyyy)");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if(checkIn < DateTime.Now || checkOut < DateTime.Now)
            {
                System.Console.WriteLine("Erro na reserva: As datas para a reserva devem ser futuras");
            }
            else if (checkOut <= checkIn)
            {
                System.Console.WriteLine("Erro na reserva: A data de saida deve ser posterior a data de entrada");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                System.Console.WriteLine("Reserva: " + reservation);
            }
        }   
    }
}