namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var outShopping = true;
            while (outShopping == true)
            {
                Console.WriteLine("What should we add to the zoo?");
                string newAnimal = Console.ReadLine();
                IZoo animal = ZooFactory.GetAnimal(newAnimal);
                animal.Get();
                Console.WriteLine("Would you like to add another animal?");
                string keepAdding = Console.ReadLine();
                if (keepAdding.ToLower() == "no")
                {
                    outShopping = false;
                }
            }
        }
    }
}
