using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tiers
    {
        public int Age { get; set; }
        public double Presure { get; set; }
        public Tiers(int age, double presure)
        {
            Age = age;
            Presure = presure;
        }
    }
}
