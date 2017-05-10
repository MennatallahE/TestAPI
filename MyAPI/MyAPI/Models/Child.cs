using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAPI.Models
{
    public class Child: ApplicationUser
    {  
        public string age { get; set; }
        public DateTime bd { get; set; }
        public int sss { get; set; }
    }
}