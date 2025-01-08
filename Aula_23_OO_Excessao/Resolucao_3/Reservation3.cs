using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Excessao.Resolucao_3
{
    public class Reservation3
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation3(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkIn < DateTime.Now && checkOut < DateTime.Now)
            {
                throw new DomainException("Erro na reserva: Data de check-in e check-out devem ser futuras");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException( "Erro na reserva: Data de check-out deve ser posterior a data de check-in");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut, int roomNumber)
        {
            if (checkIn < DateTime.Now && checkOut < DateTime.Now)
            {
                throw new DomainException("Erro na reserva: Data de check-in e check-out devem ser futuras");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException( "Erro na reserva: Data de check-out deve ser posterior a data de check-in");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
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