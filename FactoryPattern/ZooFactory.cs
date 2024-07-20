using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class ZooFactory
    {
        public static IZoo GetAnimal(string newAnimal)
        {
            switch (newAnimal.ToLower())
            {
                case "bear":
                    return new Bear();
                case "bird":
                    return new Bird();
                case "lion":
                    return new Lion();
                case "tiger":
                    return new Tiger();
                case "wolf":
                    return new Wolf();
                default:
                    return new Unicorn();
            }
        }
    }
}