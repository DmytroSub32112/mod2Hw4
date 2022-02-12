using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4.Plants.Mosses
{
    public class Areal
    {
        public Plant[] Plants = new Plant[]
        {
            new Hypnales { Color = "Green", Amount = 200, Height = 10, Name = "Hypnales" },
            new Sphagnum { Color = "White", Amount = 100, Height = 5, Name = "Sphagnum" },
            new HigherPlants.Maple { Color = "Green", Amount = 10, Height = 500, Name = "Maple" },
            new HigherPlants.Oak { Color = "Green", Amount = 5, Height = 800, Name = "Oak" },
            new HigherPlants.Pines { Color = "Green", Amount = 5, Height = 800, Name = "Pines" }
        };

        public Plant[] Print()
        {
            Console.WriteLine("Sort Areal - Amount");
            Array.Sort(Plants);
            foreach (var item in Plants)
            {
                Console.WriteLine($"Name:{item.Name}.Amount:{item.Amount}.Color:{item.Color}.Height{item.Height}sm");
            }

            return Plants;
        }
    }
}
