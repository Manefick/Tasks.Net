using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Airoport
{
    class Program
    {
        static void Main(string[] args)
        {
            AiroportTable.testInfo();
            AiroportTable.ShowTableInfo();
            Console.WriteLine("If you wont input fly info press '1'\nIf you wont delete fly info press '2'\n" +
                "If you wont etit fly info press '3'\nShow fly table press '4', end press 'ENTER'");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    AiroportTable.AddFly();
                    break;
                case 2:
                    AiroportTable.DeleteFly();
                    break;
                case 3:
                    AiroportTable.EditFly();
                    break;
                case 4:
                    AiroportTable.ShowTableInfo();
                    break;
                default:
                    AiroportTable.ShowTableInfo();
                    break;
            }
            Console.ReadLine();
        }
    }
}
