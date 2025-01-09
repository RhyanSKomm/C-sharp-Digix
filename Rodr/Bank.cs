using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDia09
{
    public class Bank
    {
        public int Code { get; set; }
        public string Adress { get; set; }

        public Bank(int code, string adress)
        {
            Code = code;
            Adress = adress;
        }
        public void Menages()
        {
            Console.WriteLine("Bank Code: " + Code);
            Console.WriteLine("Bank Adress: " + Adress);
        }
        public void Maintains()
        {
            foreach (var bank in Bank)
            {
                bank.Menages();
            }
        }
            public void SearchAccount()
            {   
                foreach (var account in Accounts)
                {
                    if (account.AccountNumber == accountNumber)
                    {
                        account.Menages();
                        return;
                    }
                }
                Console.WriteLine("Account not found");
            }

        }

    }
}