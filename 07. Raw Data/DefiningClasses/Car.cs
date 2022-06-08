using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public Car(string model, Engine engine, Cargo cargo,List<Tiers> tiers)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tiers = tiers;
        }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tiers> Tiers { get; set; }
    }
}
