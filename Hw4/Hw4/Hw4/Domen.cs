using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4.Plants.Mosses
{
    public class Domen
    {
       private Plant[] _plants;
       public int SumPlants()
        {
            Console.WriteLine("Sum plants:");
            var areal = new Areal();
            var sum = 0;
            _plants = areal.Plants;
            for (var i = 0; i < _plants.Length; i++)
            {
                sum += _plants[i].Amount;
            }

            Console.WriteLine($"{sum} plants");
            return sum;
        }

       public int AveragHeight()
       {
            Console.WriteLine("Averag height:");
            var areal = new Areal();
            var averagHeight = 0;
            _plants = areal.Plants;
            for (var i = 0; i < _plants.Length; i++)
            {
                averagHeight += _plants[i].Height;
            }

            Console.WriteLine($"{averagHeight / _plants.Length} sm");

            return averagHeight / _plants.Length;
       }

       public void ChoisePlant(string color)
        {
            var areal = new Areal();
            var index = 0;
            for (var i = 0; i < areal.Plants.Length; i++)
            {
                if (areal.Plants[i].Color == color)
                {
                    index++;
                    Console.WriteLine($"{index}){areal.Plants[i].Name}");
                }
            }
        }
    }
}
