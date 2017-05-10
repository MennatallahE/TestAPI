using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAPI.Models
{
    public class Child: ApplicationUser
    {  
        public int age { get; set; }
        public int bd { get; set; }
    }
}