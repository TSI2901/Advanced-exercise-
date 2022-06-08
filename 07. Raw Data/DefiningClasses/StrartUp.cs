using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    internal class StrartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int rnginePower = int.Parse(input[2]);
                Engine engine = new Engine(engineSpeed, rnginePower);
                int weight = int.Parse(input[3]);
                string cargoType = input[4];
                Cargo cargo = new Cargo(cargoType, weight);
                double tier1presure = double.Parse(input[5]);
                int age = int.Parse(input[6]);
                double tier2presure = double.Parse(input[7]);
                int age2 = int.Parse(input[8]);
                double tier3presure = double.Parse(input[9]);
                int age3 = int.Parse(input[10]);
                double tier4presure = double.Parse(input[11]);
                int age4 = int.Parse(input[12]);
                List<Tiers> tiers = new List<Tiers>();
                Tiers tier1 = new Tiers(age, tier1presure);
                Tiers tier2 = new Tiers(age2, tier2presure);
                Tiers tier3 = new Tiers(age3, tier3presure);
                Tiers tier4 = new Tiers(age4, tier4presure);
                tiers.Add(tier1);
                tiers.Add(tier2);
                tiers.Add(tier3);
                tiers.Add(tier4);
                Car car = new Car(model, engine, cargo, tiers);
                cars.Add(car);
            }
            string cmd = Console.ReadLine();
            

            if (cmd == "fragile")
            {
                
                foreach (var item in cars)
                {
                    if (item.Cargo.Type == "fragile")
                    {
                        if (tier(item.Tiers))
                        {
                            Console.WriteLine(item.Model);
                        }
                    }
                }
            }
            else if (cmd == "flammable")
            {
                foreach (var item in cars)
                {
                    if (item.Cargo.Type == "flammable")
                    {
                        if (item.Engine.Power > 250)
                        {
                            Console.WriteLine(item.Model);
                        }
                    }
                }
            }
        }
        static bool tier(List<Tiers> tiers)
        {
            foreach (var item in tiers)
            {
                if (item.Presure < 1)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
