using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Lion : IZoo
    {
        public void Get()
        {
            Console.WriteLine("Added a lion to the zoo!");
        }
    }
}