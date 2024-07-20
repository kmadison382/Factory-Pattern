using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Bear : IZoo
    {
        public void Get()
        {
            Console.WriteLine("Added a bear to the zoo!");
        }
    }
}