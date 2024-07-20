using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Wolf : IZoo
    {
        public void Get()
        {
            Console.WriteLine("Added a wolf to the zoo!");
        }
    }
}