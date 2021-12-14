using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GP.Domain;

namespace GP.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Provider P1 = new Provider();
            Provider.VerifPassword("melek","sioua",P1.IsApproved);
            Provider.SetIsApproved(P1);
            System.Console.WriteLine("Approved value: "+ P1.IsApproved);
            P1.Password = "meleksioua";
            P1.ConfirmePassword = "melek";
        }
    }
}
