using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDia09
{
    public class ATM
    {
        public string Location { get; set; }
        public string ManagedBy { get; set; }
        public List<ATMTransactions> Transactions { get; set; }

        public ATM(string location, string managedBy, List<ATMTransactions> transactions)
        {
            Location = location;
            ManagedBy = managedBy;
            Transactions = transactions;
        }
        public void Identifies()
        {
            System.Console.WriteLine("Location:" + Location);
            System.Console.WriteLine("Manage by:" + ManagedBy);
        }
    }
}