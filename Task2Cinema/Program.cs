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
            Console.WriteLine("If you want see list of viewers, please write 1 and press 'Enter'");
            int choise = int.Parse(Console.ReadLine());//добавить проверку на то что пользователь ничего не введет
            if(choise==1)
                cinema.ShowViewers();
            cinema.agregate();

            Console.ReadLine();
        }
    }
}
