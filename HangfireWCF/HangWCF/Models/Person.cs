﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangWCF.Models
{
    public class Person
    {
        public int Id { get; set; }
        public int AgeInDays { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Profession { get; set; }
    }
}
