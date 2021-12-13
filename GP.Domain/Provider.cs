﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Provider:Concept
    {
        public string ConfirmePassword { get; set; }
        public string Password { get; set; }
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
    }
}
