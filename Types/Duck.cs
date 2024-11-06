using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    internal class Duck
    {

        public string colour = "yellow";

        public Duck()
        {
            
        }

        public void Quack()
        {
            Console.WriteLine($"Quack! This duck is {colour}!");
        }


    }
}
