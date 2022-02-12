using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4.Plants
{
   public class Plant : IComparable
    {
        protected bool spore;
        public int Height { get; set; }
        public string Color { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            var secondItem = obj as Plant;
            if (secondItem == null)
            {
                throw new ArgumentException();
            }

            if (Amount < secondItem.Amount)
            {
                return -1;
            }

            if (Amount > secondItem.Amount)
            {
                return +1;
            }

            return 0;
        }
    }
}
