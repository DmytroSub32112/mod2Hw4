using System;

namespace Hw4.Plants.Mosses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var areal = new Areal();
            areal.Print();
            var domen = new Domen();
            domen.SumPlants();
            domen.AveragHeight();
            Console.WriteLine("User selected green color");
            domen.ChoisePlant("Green");
        }
    }
}
