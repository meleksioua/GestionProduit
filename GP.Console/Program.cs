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
            bool verif,login;
            Provider P1 = new Provider() { Email="meleksioua23@gmail.com",UserName="meleksioua",Password="meleksioua",ConfirmePassword="meleksioua"};
            System.Console.WriteLine("Email value: " + P1.Email);
            verif = Provider.VerifPassword(P1.Password,P1.ConfirmePassword,P1.IsApproved);
            //Provider.SetIsApproved(P1);
            if (verif) { 
                P1.IsApproved = true;
                System.Console.WriteLine("Approved value: " + P1.IsApproved);

            }
            else
            {
                P1.IsApproved = false;
                System.Console.WriteLine("Approved value: " + P1.IsApproved);

            }


            login = P1.Login("meleksioua", "meleksioua");
            if (login) {
                System.Console.WriteLine("Login Succ");
            }
            else
            {
                System.Console.WriteLine("Login failed");
            }
            
        }
    }
}
