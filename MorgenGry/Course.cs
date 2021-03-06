﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public class Course : Merchandise
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }

        public Course(string name, int duration)
        {
            Name = name;
            DurationInMinutes = duration;
        }
        public Course(string name) : this(name, 0)
        {
        }

        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
        }
    }
}
