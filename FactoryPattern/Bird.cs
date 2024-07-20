using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Bird : IZoo
    {
        public void Get()
        {
            Console.WriteLine("Added a bird to the zoo!");
        }
    }
}