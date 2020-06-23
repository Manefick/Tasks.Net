using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_CustomColection
{
    class Program
    {
        static void Main(string[] args)
        {
            NewColection newColection = new NewColection(9,80);// как сделать по условию?
            foreach (var i in newColection)
                Console.WriteLine(i);

            Console.ReadLine();

        }
    }
}
