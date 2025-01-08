using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula21_OO_Enumerate
{
    public class Client
    {
        string name;
        string email;
        DateTime birthDate;

        public Client(string name, string email, DateTime birthDate)
        {
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
        }
    }
}