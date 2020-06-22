using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Interfase
{
    class Program
    {
        static void Main(string[] args)
        {
            Entity bmw = new Entity(1, "BMW", 8, "German car");
            Entity mazda = new Entity(2, "Mazda", 3, "Red car");
            Entity toyota = new Entity(3, "Toyota", 5, "Grean car");
            Entity mers = new Entity(4, "Mersedes", 10, "German president car");

            Storage garage = new Storage();
            garage.Add(bmw);
            garage.Add(mazda);
            garage.Add(toyota);
            garage.Add(mers);
            garage.ShowAll();
            garage.Delete(toyota);
            Console.ForegroundColor = ConsoleColor.Red;
            garage.ShowAll();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(garage.Find(2));
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var i in garage.GetAll())
                Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
