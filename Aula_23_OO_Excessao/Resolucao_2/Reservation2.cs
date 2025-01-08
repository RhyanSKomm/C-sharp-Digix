using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Excessao.Resolucao_2
{
    public class Reservation2
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation2(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime chekIn, DateTime checkOut)
        {
    
            if (chekIn < DateTime.Now && checkOut < DateTime.Now)
            {
                return "Erro na reserva: Data de check-in e check-out devem ser futuras" ;
            }
            if (checkOut <= chekIn)
            {
                return "Erro na reserva: Data de check-out deve ser posterior a data de check-in";
            }
            CheckIn = chekIn;
            CheckOut = checkOut;
            return null;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}