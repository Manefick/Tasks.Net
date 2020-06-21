using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema();
            cinema.ShowViewers();
            cinema.agregate();

            Console.ReadLine();
        }
    }
}
