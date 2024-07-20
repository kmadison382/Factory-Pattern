using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Unicorn : IZoo
    {
        public void Get()
        {
            Console.WriteLine("Added a unicorn to the zoo!");
        }
    }
}