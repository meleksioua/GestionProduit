﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Provider:Concept
    {
        public string ConfirmePassword {
            get { return ConfirmePassword; }
            set
            {
                if (value.Equals(Password)) {
                    ConfirmePassword = value;
                }
                else
                {
                    Console.WriteLine("Il faut confirme MDP");
                }
            } 
        }
        public string Password {
            get { return Password; }
            set {
                if (value.Length >= 5 && value.Length <= 20) { 
                    Password = value;
                }
                else
                {
                    Console.WriteLine("la taille de MDP doit être enter 5 et 20");
                }
                } 
        }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        public string UserName{ get; set; }
        public List<Product> Products { get; set; }

        public override void GetDetails()
        {
            throw new NotImplementedException();
        }

        public static void SetIsApproved(Provider P)
        {
            P.IsApproved = !P.IsApproved;
        }
        public static void VerifPassword(string password, string confirmPassword, bool isApproved)
        {
            if (password.Equals(confirmPassword))
            {
                isApproved = true;
                Console.WriteLine("Is approved");
            }
            else
            {
                isApproved = false;
                Console.WriteLine("Is not approved!!");
            }
        }
    }
}
