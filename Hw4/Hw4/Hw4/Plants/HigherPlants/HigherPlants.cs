using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4.Plants.HigherPlants
{
    public class HigherPlants : Plant
    {
        public virtual void PrintInfo()
        {
            Console.WriteLine("I have seeds");
        }
    }
}
