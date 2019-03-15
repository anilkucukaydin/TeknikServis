﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Person : IdentityUser
    {
        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public string Email { get; set; }   IdentityUserdan geliyor zaten
        //public string Password { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
    }
}
