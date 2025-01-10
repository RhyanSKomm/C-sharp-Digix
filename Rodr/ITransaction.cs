using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDia09
{
    public interface ITransaction
    {
        void Deposit(double amount);

        void Transfer(double amount, string targetAccount);

        void WithDraw(double amount);
    }
}