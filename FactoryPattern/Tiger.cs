using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Tiger : IZoo
    {
        public void Get()
        {
            Console.WriteLine("Added a tiger to the zoo!");
        }
    }
}