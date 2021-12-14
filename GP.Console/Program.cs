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
            bool test;
            Provider P1 = new Provider();
            test = Provider.VerifPassword("melek","sioua",P1.IsApproved);
            //Provider.SetIsApproved(P1);
            if (test) { 
                P1.IsApproved = true;
            }else
                P1.IsApproved=false;

            System.Console.WriteLine("Approved value: "+ P1.IsApproved);
            P1.Password = "meleksioua";
            P1.ConfirmePassword = "sioua";
        }
    }
}
