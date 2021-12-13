﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Category:Concept
    {
        public  int CategoryID { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public override void GetDetails()
        {
            throw new NotImplementedException();
        }
    }
}
