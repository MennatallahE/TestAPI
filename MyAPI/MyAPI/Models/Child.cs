﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAPI.Models
{
    public class Child: ApplicationUser
    {  
        public string Name { get; set; }
        public int MyProperty { get; set; }
    }
}